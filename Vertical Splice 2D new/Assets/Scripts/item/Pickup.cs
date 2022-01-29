using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{

    public GameObject col;
    private void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "Item")
        {
            collider.gameObject.GetComponent<Item>().inrange = true;
            col = collider.gameObject;
        }
    }




    private void OnTriggerExit(Collider collision)
    {
        collision.gameObject.GetComponent<Item>().inrange = false;
    }

}
