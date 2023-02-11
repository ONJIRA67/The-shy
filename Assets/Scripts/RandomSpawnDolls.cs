using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnDolls : MonoBehaviour
{
    public GameObject dollPrefab;

    void Start()
    {
        // random position 13 dolls when start
        for(int i = 0; i < 12; i++)
        {
            Vector3 randonSpawnPosition = new Vector3(Random.Range(-10, 20), 1, Random.Range(-10, 20));
            Instantiate(dollPrefab, randonSpawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
       
    }
}
