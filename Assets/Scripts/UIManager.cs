using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button RestartButton;
    [SerializeField] private TextMeshProUGUI ScoreText;

    [SerializeField] private TextMeshProUGUI BoxText;
    [SerializeField] private TextMeshProUGUI SphereText;
    [SerializeField] private TextMeshProUGUI CylinderText;


    private void Start()
    {
        RestartButton.onClick.AddListener(GameManager.Instance.RestartLevel);
    }

    public void BoxUI(int amount)
    {
        BoxText.text = amount.ToString();
    }
    
    public void SphereUI(int amount)
    {
        SphereText.text = amount.ToString();
    }

    public void CylinderUI(int amount)
    {
        CylinderText.text = amount.ToString();
    }

    public void ScoreUI(int amount)
    {
        ScoreText.text = "Score : " + amount;
    }
    
    
    
}
