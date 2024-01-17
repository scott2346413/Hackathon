using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapManager : MonoBehaviour
{
    public void GoToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
