using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaxwelDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialoguebox;
    


    public void apear()
    {
        //apear animation
    }

    public void LineOne()
    {
        dialoguebox.text = "Say Pal, you don't look so good";
    }
    public void LineTwo()
    {
        dialoguebox.text = "You'd better find something to eat before night comes!";
    }
    public void Dissapear()
    {
        //dissapear animation 
    }
}
