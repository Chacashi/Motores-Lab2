using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseController : MonoBehaviour
{
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject menuPause;
    Button myButton;

    private void Awake()
    {
   
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(() => OnClick());
    }

   
    void OnClick()
    {
        if (myButton.gameObject.tag == "Pause") 
        { 
        Pause();

        }
        else if (myButton.gameObject.tag == "Reanudar")
        {
            Reanudar();
        }
        else if (myButton.gameObject.tag == "Restart")
        {
            Restart();
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        buttonPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);
    }

   
}
