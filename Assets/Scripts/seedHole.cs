using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedHole : MonoBehaviour
{
    bool isEmpty = true;
    MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Seed") && isEmpty)
        {
            Color colour = meshRenderer.material.color;
            colour.g += 0.1f;
            colour.b += 0.1f;
            colour.r += 0.1f;
            meshRenderer.material.color = colour;
            Destroy(collision.gameObject);
            isEmpty = false;
        }
    }
}