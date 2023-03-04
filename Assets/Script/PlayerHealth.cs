using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public float healthMax = 100;
    public Slider healthSlider;
    public GameObject finishPanel;

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

    public IEnumerator RemoveHealth(float value, float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);

            if (health > 0)
            {
                health -= value;
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
