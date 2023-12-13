using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnPull : MonoBehaviour
{
    float startY;
    public float targetElevationY;
    public AudioSource audioSource;

    private void Start()
    {
        startY = transform.position.y;
    }

    private void Update()
    {
        if(transform.position.y > startY + targetElevationY)
        {
            Destroy(gameObject);
            audioSource.Play();
        }
    }
}
