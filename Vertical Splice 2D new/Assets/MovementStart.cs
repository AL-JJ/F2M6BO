using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStart : MonoBehaviour
{
    public Movement movement;
    public GameObject getup;
    public GameObject frontIdle;
    public GameObject PlayerUI;
    public GameObject Transition;
    public void canWalk()
    {
        movement.canMove = true;
        getup.SetActive(false);
        frontIdle.SetActive(true);
        PlayerUI.SetActive(true);
        Transition.SetActive(true);
        movement.playerAnimation.Idle("S");
    }
}
