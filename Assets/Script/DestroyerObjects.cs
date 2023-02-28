using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerObjects : MonoBehaviour
{
    private bool destroyed = false;
    // Start is called before the first frame update
    void OnDestroy()
    {
        destroyed = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
