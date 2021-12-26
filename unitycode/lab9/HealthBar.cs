using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(float health)
    {
        // max of maxValue and health
        if (health > slider.maxValue)
        {
            slider.value = slider.maxValue;
        }
        else if (health < slider.minValue)
        {
            slider.value = slider.minValue;
        }
        else
        {
            slider.value = health;
        }
       
    }



}
