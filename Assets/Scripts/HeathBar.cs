using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeathBar : MonoBehaviour
{

    public Player player;
    public Slider slider;
    public Gradient gradient;
    public Image fillimage;
   
   



    void Awake()
    {
        slider = GetComponent<Slider>();
    } 

    void Update()
    {
        float fillValue = player.currentHealth / player.maxHealth;
        slider.value = fillValue;
    }



    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fillimage.color = gradient.Evaluate(1f);
   
    }
    
    public void Sethealth(int health)
     {
        slider.value = health;

        fillimage.color = gradient.Evaluate(slider.normalizedValue);
    
     }

   

    }





