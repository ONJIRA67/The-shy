using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHealth : MonoBehaviour
{
    public Slider healthSlider;
    public Button restartBtn;
    public PlayerHealth play;
    public GameObject healthPanel;
    
    // void Start()
    // {
    //     restartBtn.onClick.AddListener(play.StartHealth);
    // }

    public void HealthOnClick()
    {
        // Debug.Log("Button clicked.");
        float health = 100;
        healthSlider.GetComponent<Slider>().maxValue = health;
        healthSlider.GetComponent<Slider>().value = health;
        healthPanel.SetActive(true);   
    }
}
