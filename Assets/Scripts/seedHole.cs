using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedHole : MonoBehaviour
{
    bool isEmpty = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Seed") && isEmpty)
        {
            Destroy(collision.gameObject);
            isEmpty = false;
        }
    }
}