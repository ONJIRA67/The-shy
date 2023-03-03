using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    void Update()
    {
        transform.position = player.position + player.rotation * offset;
        transform.rotation = player.rotation;
        // transform.position = player.position;
    }

    // public Transform player;

    // void Update()
    // {
    //     transform.position = player.position;
    //     transform.rotation = player.rotation;
    // }
}
