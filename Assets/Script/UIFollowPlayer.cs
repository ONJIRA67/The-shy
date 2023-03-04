using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    void Update()
    {
        // Health UI follows the player's view direction
        transform.position = Camera.main.transform.position + Camera.main.transform.rotation * offset;
        transform.rotation = Camera.main.transform.rotation;
        transform.position = player.position;
    }
}