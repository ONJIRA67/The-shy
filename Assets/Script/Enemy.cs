using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    public GameObject player;
    public float speed;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(lookDirection.x, 0f, lookDirection.z));
        transform.rotation = lookRotation;
        enemyRb.AddForce(lookDirection * speed);


        // if (transform.position.y < -10)
        // {
        //     Destroy(gameObject);
        // }
    }
}
