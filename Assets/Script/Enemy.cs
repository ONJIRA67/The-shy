using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    public GameObject player;
    public float speed;
    public float maxDistance = 10.0f;

    private AudioSource audioSource;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Enemy is moving to player with look direction
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(lookDirection.x, 0f, lookDirection.z));
        transform.rotation = lookRotation;

        enemyRb.AddForce(lookDirection * speed);

        // The sound is playing louder when gets closer to player
        float distance = Vector3.Distance(player.transform.position, transform.position);
        float volume = Mathf.InverseLerp(maxDistance, 0.0f, distance);
        volume = Mathf.Clamp01(volume);

        audioSource.volume = volume;
    }
}
