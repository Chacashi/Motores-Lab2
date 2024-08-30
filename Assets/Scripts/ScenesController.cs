using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenesController : MonoBehaviour
{

    [SerializeField] private string scene;



    public void LoadScene( string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
   
}
