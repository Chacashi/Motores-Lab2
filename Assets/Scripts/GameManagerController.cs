using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManagerController : MonoBehaviour
{
    [SerializeField]  private int maxLife;
    [SerializeField] private int currentLife;
    private Slider _compSlider;
    [SerializeField] private int damageEnemys;

    public float currentTime;
    public TMP_Text timerText;

    private void Update()
    {
        currentTime += Time.deltaTime;
        
        UpdateTimer();
        
    }

    void UpdateTimer()
    {
        
        timerText.text = Mathf.FloorToInt(currentTime).ToString();
    }
    public float GetCurrentTime()
    {
        
        return currentTime;
    }
    void Start()
    {
        currentTime = 0.0f;
        _compSlider = GetComponent<Slider>();
    }
    public void ChangueLifeMax (float maxLife)
    {
        _compSlider.maxValue = maxLife;
    }

    public void ChangueCurrentLife(float currentLife)
    {
        _compSlider.value = currentLife;
    }

    public void SetLifeBar(float currentLife)
    {
        ChangueCurrentLife(currentLife);
        ChangueLifeMax(currentLife);
    }

    public int GetDamageEnemys() { return damageEnemys; }
   
    
}
