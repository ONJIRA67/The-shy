using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    public GameObject player;
    public float speed;

    public float stoppingDistance;
    public float retreatDistance;

    private Animation animator;

    void Start()
    {
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
            animator.Play("Attack1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemyRb.velocity = Vector3.zero;
        }
    }
}
