using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthComponent : MonoBehaviour
{
  
    public int health =3;


    public void TakeDamage()
    {
        health= health -1;
    }
}
