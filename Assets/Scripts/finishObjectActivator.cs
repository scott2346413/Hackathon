using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishObjectActivator : MonoBehaviour
{
    public GameObject FinishObject;

    public void Activate()
    {
        FinishObject.SetActive(true);
    }
}
