using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoll : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "doll")
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    
}
