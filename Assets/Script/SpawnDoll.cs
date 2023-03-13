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
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-18, 13), 0.25f, Random.Range(-4, 37));
            GameObject doll = Instantiate(dollObjects, randomSpawnPosition, Quaternion.Euler( -90, 0, 0));
        }
    }
}
