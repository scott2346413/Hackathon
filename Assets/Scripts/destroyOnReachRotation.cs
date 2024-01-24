using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnReachRotation : MonoBehaviour
{
    public float targetRotation;

    // Update is called once per frame
    void Update()
    {
        if(transform.localRotation.eulerAngles.y == targetRotation)
        {
            Destroy(gameObject);
        }
    }
}
