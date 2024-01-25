using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class tooltip : MonoBehaviour
{
    public GameObject canvas;
    Transform player;

    private void Start()
    {
        canvas.SetActive(false);
        player = Camera.main.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(false);
        }
    }

    private void Update()
    {
        transform.LookAt(player);
    }
}
