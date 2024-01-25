using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenScene : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            Debug.Log("Player entered Sen scene");
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("senigal");
        }
    }
}