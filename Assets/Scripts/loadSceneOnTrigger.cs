using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class loadSceneOnTrigger : MonoBehaviour
{
    public string scene;
    public XRGrabInteractable grabber;

    bool loaded = false;

    private void Update()
    {
        if(grabber.isSelected && !loaded)
        {
            loaded = true;
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene);
        }
    }
}
