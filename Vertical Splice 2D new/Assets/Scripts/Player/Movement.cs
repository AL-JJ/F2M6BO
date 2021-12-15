using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public PlayerAnimation playerAnimation;
    public bool isTouch = false;
    // public CharacterController Player;
    public Rigidbody rb;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    private float gravityValue = -9.81f;
    [HideInInspector] public bool canMove;




    private void Start()
    {
        gameObject.tag = "Player";
        playerAnimation.Idle("W");
        canMove = false;



    }

  

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Item")
        {
            isTouch = true;
        }
    }

    void Update()
    {
        if (canMove == true)
        {
            if (Input.GetKey("w"))
            {
                playerAnimation.AnimTrigger(true, "W");
                rb.velocity = new Vector3(0, 0, -playerSpeed);
            }
            //rechts
            if (Input.GetKey("a"))
            {
                playerAnimation.AnimTrigger(true, "A");
                rb.velocity = new Vector3(playerSpeed, 0, 0);
            }
            //achter
            if (Input.GetKey("s"))
            {
                playerAnimation.AnimTrigger(true, "S");
                rb.velocity = new Vector3(0, -0, playerSpeed);
            }
            //links
            if (Input.GetKey("d"))
            {
                playerAnimation.AnimTrigger(true, "D");
                rb.velocity = new Vector3(-playerSpeed, 0, 0);
            }



            //rechts boven
            if (Input.GetKey("w") && Input.GetKey("d"))
            {

                rb.velocity = new Vector3(-playerSpeed, 0, -playerSpeed);
            }
            //rechts beneden
            if (Input.GetKey("s") && Input.GetKey("d"))
            {
                rb.velocity = new Vector3(-playerSpeed, 0, playerSpeed);
            }
            //links boven
            if (Input.GetKey("w") && Input.GetKey("a"))
            {
                playerAnimation.AnimTrigger(true, "A");
                rb.velocity = new Vector3(playerSpeed, 0, -playerSpeed);
            }
            //links beneden
            if (Input.GetKey("a") && Input.GetKey("s"))
            {
                rb.velocity = new Vector3(playerSpeed, 0, playerSpeed);
            }



            if (Input.GetKeyUp("w"))
            {
                playerAnimation.Idle("W");
                rb.velocity = new Vector3(0, 0, 0);
            }

            if (Input.GetKeyUp("a"))
            {
                playerAnimation.Idle("A");
                rb.velocity = new Vector3(0, 0, 0);
            }

            if (Input.GetKeyUp("s"))
            {
                playerAnimation.Idle("S");
                rb.velocity = new Vector3(0, 0, 0);
            }

            if (Input.GetKeyUp("d"))
            {
                playerAnimation.Idle("D");
                rb.velocity = new Vector3(0, 0, 0);
            }
        }
        /*
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Player.Move(move * Time.deltaTime * -playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
        */

    }
}
