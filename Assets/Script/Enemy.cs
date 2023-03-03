using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kino;

public class Enemy : MonoBehaviour
{
    // Objects
    private Rigidbody enemyRb;
    public GameObject player;

    // Moving
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    // Animated
    private Animation animator;

    // Take Damage
    public float damage = 10;
    public float damageTime = 1;
    public bool enableDisappear = false;
    public float timeHealth = 3.0f;
    IEnumerator damagePlayer = null;
    IEnumerator healthPlayer = null;

    // Glitch
    public AnalogGlitch GlitchEffect;
    public float Intensity;

    void Start()
    {
        // Get Component
        enemyRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animation>();
    }

    void Update()
    {
        // Enemy is moving to player with look direction
        Vector3 lookDirection = player.transform.position - transform.position;
        float distanceToPlayer = lookDirection.magnitude;

        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(lookDirection.x, 0f, lookDirection.z));
        transform.rotation = lookRotation;

        // When enemy is closing the player then stop following
        if (distanceToPlayer > stoppingDistance)
        {
            enemyRb.velocity = lookDirection.normalized * speed;
        }
        else if (distanceToPlayer < retreatDistance)
        {
            enemyRb.velocity = -lookDirection.normalized * speed;
        }
        else
        {
            enemyRb.velocity = Vector3.zero;
            animator.Play("Attack1");           // Change animation when stop then attack player
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemyRb.velocity = Vector3.zero;    // enemy stop moving

            enableDisappear = true;
            Vector3 distanceVector = other.transform.position - transform.position;
            GlitchEffect.GetComponent<AnalogGlitch>().enabled = true;
            GlitchEffect.scanLineJitter = Intensity / distanceVector.magnitude;

            if (healthPlayer != null)
                StopCoroutine(healthPlayer);
            damagePlayer = other.GetComponent<PlayerHealth>().RemoveHealth(damage,damageTime);
            // GetComponent<AudioSource>().Play();
            StartCoroutine(damagePlayer);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GlitchEffect.GetComponent<AnalogGlitch>().enabled = false;
            GlitchEffect.scanLineJitter = 0;

            StopCoroutine(damagePlayer);
            healthPlayer = other.gameObject.GetComponent<PlayerHealth>().StartHealth(other.gameObject.GetComponent<PlayerHealth>().health, timeHealth);
            StartCoroutine(healthPlayer);
        }
    }
}
