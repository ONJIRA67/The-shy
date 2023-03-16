using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHealth : MonoBehaviour
{
    public Slider healthSlider;
    public Button restartBtn;
    
    void Start()
    {
        restartBtn.onClick.AddListener(HealthOnClick);
    }

    public void HealthOnClick()
    {
        // Debug.Log("Button clicked.");
        healthSlider.GetComponent<Slider>().value = 100;
    }
}
