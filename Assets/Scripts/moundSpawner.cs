using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moundSpawner : MonoBehaviour
{
    public GameObject mound;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Ground"))
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.y = 0f;
            Instantiate(mound, spawnPosition, Quaternion.identity);
            audioSource.Play();
        }
    }
}
