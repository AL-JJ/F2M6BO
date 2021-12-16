using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActivation : MonoBehaviour
{
    public Movement movement;
    public GameObject PlayerUI;
    public GameObject Transition;
    public GameObject getup;
    public GameObject frontIdle;

    public void ActiveateCanvas()
    {
        PlayerUI.SetActive(true);
        Transition.SetActive(true);
        getup.SetActive(false);
        frontIdle.SetActive(true);
        movement.playerAnimation.Idle("S");
    }
}
