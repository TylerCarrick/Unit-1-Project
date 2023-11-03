using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeathBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }
    
    public void Sethealth(int health)
     {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    
     }
}