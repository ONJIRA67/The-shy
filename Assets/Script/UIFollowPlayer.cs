using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowPlayer : MonoBehaviour
{
    public GameObject healthPanel;
    public GameObject finishPanel;
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        healthPanel.SetActive(true);
        finishPanel.SetActive(false);
    }

    void Update()
    {
        // Health UI follows the player's view direction
        transform.rotation = player.transform.rotation;
        transform.position = player.transform.position + player.transform.rotation * offset;
    }
}