using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDoll : MonoBehaviour
{
    public GameObject dollObjects;
    // Start is called before the first frame update
    void Start()
    {
        for(int i= 0; i< 13 ; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 20), 1, Random.Range(-10, 30));
            Instantiate(dollObjects, randomSpawnPosition, Quaternion.Euler( -90, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
