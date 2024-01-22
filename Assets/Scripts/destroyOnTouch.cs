using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class destroyOnTouch : MonoBehaviour
{
    public string destroyTag;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(destroyTag))
        {
            Destroy(gameObject);
            audioSource.Play();
        }
    }
}
