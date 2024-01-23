using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class destroyOnMethod : MonoBehaviour
{
    public AudioSource sound;

    public void destroy()
    {
        sound.Play();
        Destroy(gameObject);
    }
}
