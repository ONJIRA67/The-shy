using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDoll : MonoBehaviour
{
    public GameObject dollObjects;

    // when start the game will spawn 13 dolls
    void Start()
    {
        for(int i = 0; i < 100 ; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-16, 12), 0.25f, Random.Range(-2, 36));
            Instantiate(dollObjects, randomSpawnPosition, Quaternion.Euler( -90, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
