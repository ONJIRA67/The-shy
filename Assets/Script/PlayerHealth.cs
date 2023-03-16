using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Kino;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public float healthMax = 100;
    public Slider healthSlider;
    public GameObject healthPanel;
    public GameObject finishPanel;
    public GameObject enemy;
    public AnalogGlitch GlitchEffect;
    public SetRecordTime RecTime;
    public LayerMask enemyLayer;
    public bool gameover;

    void Start()
    {
        // Set default health
        health = healthMax;
        healthSlider.GetComponent<Slider>().maxValue = healthMax;
        healthSlider.GetComponent<Slider>().value = health;
    }

    void Update()
    {
        healthSlider.GetComponent<Slider>().value = health;
    }

    public void HealthOnClick()
    {
        Debug.Log(health);
        // float health = 100;
        // healthSlider.GetComponent<Slider>().maxValue = health;
        // healthSlider.GetComponent<Slider>().value = health;
        // healthPanel.SetActive(true);   
        //StartCoroutine(StartHealth(value, time));
        health = healthMax;
        healthSlider.GetComponent<Slider>().maxValue = healthMax;
        healthSlider.GetComponent<Slider>().value = health;
        Debug.Log("Healt update" + health);
    }

    public IEnumerator RemoveHealth(float value, float time)
    {
        // Collider hitColliders = Physics.OverlapSphere(transform.position, 1.3f, enemyLayer);
        // Debug.Log(hitColliders.gameObject.CompareTag("Enemy"));

        while (true)
        {
            yield return new WaitForSeconds(time);

            if (health > 0)
            {
                health -= value;
                // RecTime.LevelEnded();
            }
            else if (health == 0)
            {
                finishPanel.SetActive(true);
                //float record = RecTime.Update();
                RecTime.LevelEnded();
                GlitchEffect.GetComponent<AnalogGlitch>().enabled = false;
                healthPanel.SetActive(false);   
            }

        }
    }

    public IEnumerator StartHealth(float value, float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);

            if (health > 0 && health<healthMax)
            {
                health += value;
            }
            else
            {
                health = healthMax;
            }
        }
    }

    
}
