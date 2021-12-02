using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool isTouch = false;
    // public CharacterController Player;
    public Rigidbody rb;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    private float gravityValue = -9.81f;




    private void Start()
    {
        gameObject.tag = "Player";

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

        if (Input.GetKey("w"))
        {

            rb.velocity = new Vector3(0, 0, -playerSpeed);
        }
        //rechts
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(playerSpeed, 0, 0);
        }
        //achter
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(0, -0, playerSpeed);
        }
        //links
        if (Input.GetKey("d"))
        {
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
            rb.velocity = new Vector3(playerSpeed, 0, -playerSpeed);
        }
        //links beneden
        if (Input.GetKey("a") && Input.GetKey("s"))
        {
            rb.velocity = new Vector3(playerSpeed, 0, playerSpeed);
        }



        if (Input.GetKeyUp("w"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp("a"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp("s"))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp("d"))
        {
            rb.velocity = new Vector3(0, 0, 0);
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
