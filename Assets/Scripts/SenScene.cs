using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenScene : MonoBehaviour
{
    //
    private void OnTriggerEnter(Collider other)
    {   // If the player enters the trigger area, load the Sen scene
        if (other.gameObject.CompareTag("Tree"))
        {   // Log the event
            Debug.Log("Player entered Sen scene");
            // Load the scene
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("senigal");
        }
    }
}