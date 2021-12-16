using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaxwelDialogue : MonoBehaviour
{
    public Animator MaxwelAnimator;
    public TextMeshProUGUI dialoguebox;
    public float timer;
    private bool _LineOneDone = false;
    private bool _LineTwoDone = false;


 

    public void LineOne()
    {
        dialoguebox.text = "Say Pal, you don't look so good";
        timer = 5;
        _LineOneDone = true;
        
    }
    public void LineTwo()
    {
        dialoguebox.text = "You'd better find something to eat before night comes!";
        timer = 5;
        _LineTwoDone = true;
    }
    private void Dissapear()
    {
        dialoguebox.text = "";
        MaxwelAnimator.SetBool("Done", true);
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && _LineOneDone == true && _LineTwoDone == false)
        {
            LineTwo();
            _LineTwoDone = true;
        }
        if (timer <= 0 && _LineOneDone == true && _LineTwoDone == true)
        {
            Dissapear();
        }
    }
}
