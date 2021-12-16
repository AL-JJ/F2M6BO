using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
    public GameObject canvas;


     public void TurnOffCanvas()
        {
            canvas.SetActive(false);
        }
        
    
}
