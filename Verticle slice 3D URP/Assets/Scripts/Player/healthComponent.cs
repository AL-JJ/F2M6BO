using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthComponent : MonoBehaviour
{
  
    public int health = 110;
    public Slider slider;

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void TakeDamage()
    {
        health= health -1;
    }
}
