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
        Rock,
        Berries,
        Flower
    };
    [HideInInspector] public Sprite stick;
    [HideInInspector] public Sprite rock;
    [HideInInspector] public Sprite grass;
    [HideInInspector] public Sprite berries;
    [HideInInspector] public Sprite flower;


    private void Update()
    {
        //find inventory script
        try
        {
            inv = GameObject.Find("UI").GetComponent<Inventory>();
        }
        catch
        {
            //ignore this dit is puur zodat je geen error spam krijg totdat de cutscene klaar is
        }
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
            else if(ItemType == MyEnum.Rock)
            {
                RockPickUp();
                inv.UpdateAmount();
                Destroy(gameObject);
            }
            else if(ItemType == MyEnum.Berries)
            {
                BerriesPickUp();
                //Vector3 spawn = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                //Instantiate(berryBushEmpty, spawn, Quaternion.identity,ParentforBush.transform);
                inv.UpdateAmount();
                Destroy(gameObject);
            }
            else if(ItemType == MyEnum.Flower)
            {
                FlowerPickup();
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
    public void BerriesPickUp()
    {
        inv.PickUpLimit("Berries");
        inv.Additem("Berries", berries);
    }
    public void FlowerPickup()
    {
        inv.PickUpLimit("Flower");
        inv.Additem("Flower", flower);
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
        }
    }


    private void OnTriggerExit(Collider collision)
    {
        inrange = false;
    }

}
