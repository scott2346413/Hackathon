using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growOnActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.one*0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, Time.deltaTime*0.5f);
    }
}
