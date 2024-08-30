using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoonControllerMenu : MonoBehaviour
{
    [SerializeField] ScenesController changueScene;
    [SerializeField]  string scene;
    Button myButton;


    private void Awake()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(() => OnClick());
    }

    void OnClick()
    {
        Time.timeScale = 1f;
        changueScene.LoadScene(scene);
    }
}
