using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class OffsetFlashlight : MonoBehaviour
{
    private Vector3 vectOffest;
    private GameObject goFollow;
    [SerializeField] private float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        goFollow = Camera.main.gameObject;
        vectOffest = transform.position = goFollow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = goFollow.transform.position + vectOffest;
        transform.rotation = Quaternion.Slerp(transform.rotation, goFollow.transform.rotation, speed * Time.deltaTime);
    }
}
