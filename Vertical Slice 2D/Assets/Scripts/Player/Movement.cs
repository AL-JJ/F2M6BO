using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public MeshRenderer MR;
    public BoxCollider BC;
    public bool isTouch = false;
    private CharacterController Player;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    private float gravityValue = -9.81f;




    private void Start()
    {
        gameObject.tag = "Player";
        Player = gameObject.AddComponent<CharacterController>();
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
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Player.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

    }
}
