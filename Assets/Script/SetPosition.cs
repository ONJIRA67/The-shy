using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveToPosition(Transform target)
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}