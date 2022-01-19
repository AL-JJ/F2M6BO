using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthComponent : MonoBehaviour
{
  
    public int health =3;

    private void Start()
    {
        print(health);
    }
    public void TakeDamage()
    {
        health--;
        print(health);
    }
}
