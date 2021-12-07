using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public Inventory inv;
    private bool inrange = false;

    //drop down menu
    public MyEnum ItemType = new MyEnum();
    public enum MyEnum
    {
        Grass,
        Stick,
        Rock
    };
    public Sprite stick;
    public Sprite rock;
    public Sprite grass;


    private void Update()
    {
        if (inrange == true && Input.GetKey("space"))
        {
            if (ItemType == MyEnum.Grass)
            {
                GrassPickUp();
                inv.UpdateAmount();
                Destroy(gameObject);
            }
            else if (ItemType == MyEnum.Stick)
            {
                StickPickUp();
                inv.UpdateAmount();
                Destroy(gameObject);
            }
        }
    }


    public void GrassPickUp()
    {
        inv.PickUpLimit("Grass");
        inv.Additem("Grass", grass);
    }

    public void RockPickUp()
    {
        inv.PickUpLimit("Rock");
        inv.Additem("Rock", rock);
    }

    public void StickPickUp()
    {
        inv.PickUpLimit("Stick");
        inv.Additem("Stick", stick);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inrange = true;
            print("player in range");
        }
    }


    private void OnTriggerExit(Collider collision)
    {
        inrange = false;
        print("player not in range");
    }

}
