using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
    private BoxCollider boxCollider;

    private void Start()
    {
        // Get the BoxCollider component on this GameObject
        boxCollider = GetComponent<BoxCollider>();

        // Set the BoxCollider to not be a trigger
        boxCollider.isTrigger = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // If any object collides with the invisible wall, prevent it from passing through
        // collision.gameObject.transform.position = collision.gameObject.transform.position - collision.contacts[0].normal * collision.relativeVelocity.magnitude * Time.deltaTime;
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 normal = collision.contacts[0].normal;
            rb.velocity = Vector3.Reflect(rb.velocity, normal);
        }
    }
}
