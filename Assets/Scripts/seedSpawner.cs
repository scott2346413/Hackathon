using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedSpawner : MonoBehaviour
{
    public GameObject[] seeds;

    public float xBound;
    public float zBound;

    public int numberOfSeeds;

    private void Start()
    {
        for(int i = 0; i < numberOfSeeds; i++)
        {
            GameObject seed = seeds[Random.Range(0, seeds.Length)];
            Vector3 spawnPosition = Vector3.zero;
            spawnPosition.x = Random.Range(-xBound, xBound);
            spawnPosition.z = Random.Range(-zBound, zBound);
            spawnPosition += transform.position;
            Instantiate(seed, spawnPosition, Quaternion.identity);
        }
    }

}
