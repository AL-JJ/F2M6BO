using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    public GameObject BackSprite;

    public void AnimTrigger(bool enabled, string Input)
    {

        switch (Input)
        {
            case "W":
                if (enabled == true)
                {
                    
                }
            break;

            case "A":
                if (enabled == true)
                {
                    //speel animatie af
                }
            break;

            case "S":
                if (enabled == true)
                {
                    //speel animatie af
                }
            break;

            case "D":
                if (enabled == true)
                {
                    //speel animatie af
                }
            break;
        }
    }
    public void Idle()
    {
        //speel de idle anim af
    }
}
