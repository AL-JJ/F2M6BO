using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animatorWalkUp;
    public Animator animatorWalkLeft;
    public Animator animatorWalkRight;
    public Animator animatorWalkDown;
    public GameObject BackSprite;
    public GameObject LeftSprite;
    public GameObject RightSprite;
    public GameObject BottomSprite;

    public void AnimTrigger(bool enabled, string Input)
    {

        switch (Input)
        {
            case "W":
                if (enabled == true)
                {
                    animatorWalkUp.SetBool("WalkUp", enabled);

                    BackSprite.SetActive(true);
                    LeftSprite.SetActive(false);
                    RightSprite.SetActive(false);
                    BottomSprite.SetActive(false);


                }
            break;

            case "A":
                if (enabled == true)
                {
                    animatorWalkLeft.SetBool("WalkingLeft", enabled);

                    BackSprite.SetActive(false);
                    LeftSprite.SetActive(true);
                    RightSprite.SetActive(false);
                    BottomSprite.SetActive(false);


                }
            break;

            case "S":
                if (enabled == true)
                {
                    animatorWalkDown.SetBool("WalkDown", enabled);

                    BackSprite.SetActive(false);
                    LeftSprite.SetActive(false);
                    RightSprite.SetActive(false);
                    BottomSprite.SetActive(true);
                }
            break;

            case "D":
                if (enabled == true)
                {
                    BackSprite.SetActive(false);
                    LeftSprite.SetActive(false);
                    RightSprite.SetActive(true);
                    BottomSprite.SetActive(false);

                    animatorWalkRight.SetBool("WalkingLeft", enabled);

                   
                }
            break;
        }
    }
    public void Idle(string Input)
    {
        switch (Input)
        {
            case "W":
                if (enabled == true)
                {
                    animatorWalkUp.SetBool("WalkUp", false);
                    animatorWalkUp.SetBool("WalkUpIdle", true);

                }
                break;

            case "A":
                if (enabled == true)
                {
                    animatorWalkLeft.SetBool("WalkingLeft", false);
                    animatorWalkLeft.SetBool("Left Idle", true);

                 
                }
                break;

            case "S":
                if (enabled == true)
                {
                    animatorWalkDown.SetBool("WalkDown", false);
                    animatorWalkDown.SetBool("FrontIdle", true);
                }
                break;

            case "D":
                if (enabled == true)
                {
                     animatorWalkRight.SetBool("WalkingLeft", false);
                     animatorWalkRight.SetBool("Left Idle", true);
                }
                break;
        }
    }
}
