using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedHole : MonoBehaviour
{
    bool isEmpty = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Seed") && isEmpty)
        {
            Destroy(other.gameObject);
            isEmpty = false;
        }
    }
}