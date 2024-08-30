using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class exitController : MonoBehaviour
{
    Button myButton;
    private void Awake()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(() => OnClick());
    }

    void OnClick()
    {
        
        Application.Quit();
    }
}
