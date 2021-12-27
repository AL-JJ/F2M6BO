using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject Player;
    public Camera Camera;

    private void Forward()
    {
        Player.transform.position += new Vector3(0, 0, -1.0f * Time.deltaTime);
        //1.0f * Time.deltaTime;
    }

    private void Backward()
    {
        Player.transform.position += new Vector3(0, 0, 1.0f * Time.deltaTime);
    }

    private void StrafeLeft()
    {
        Player.transform.position += new Vector3(1.0f * Time.deltaTime, 0, 0);
    }

    private void StrafeRight()
    {
        Player.transform.position += new Vector3(-1.0f * Time.deltaTime, 0, 0);
    }

    void Update()
    {

        if (Input.GetKey("w"))
        {
            Forward();
        }

        if (Input.GetKey("s"))
        {
            Backward();
        }

        if (Input.GetKey("a"))
        {
            StrafeLeft();
        }

        if (Input.GetKey("d"))
        {
            StrafeRight();
        }
    }
}
