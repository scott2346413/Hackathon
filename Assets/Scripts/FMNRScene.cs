using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FMNRScene : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            Debug.Log("Player entered FMNR scene");
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("FMNR");
        }
    }
}
