using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStart : MonoBehaviour
{

    public Movement movement;

    public void canWalk()
    {
        movement.canMove = true;
        
    }
}
