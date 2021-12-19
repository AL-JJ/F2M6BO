using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Inventory inv;
    [HideInInspector] public bool inrange = false;

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
    public Sprite stick;
    public Sprite rock;
     public Sprite grass;
    public Sprite berries;
    public Sprite flower;

    public Animator animatorWalkUp;
    public Animator animatorWalkLeft;
    public Animator animatorWalkRight;
    public Animator animatorWalkDown;

    public GameObject BackSprite;
    public GameObject LeftSprite;
    public GameObject RightSprite;
    public GameObject BottomSprite;

    [HideInInspector] public static string ItemID;
        public string ID;
    public Movement movement;

    public void Update()
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
                BackSprite.SetActive(true);
                LeftSprite.SetActive(false);
                RightSprite.SetActive(false);
                BottomSprite.SetActive(false);

                animatorWalkLeft.SetBool("WalkingLeft", false);
                animatorWalkDown.SetBool("WalkDown", false);
                animatorWalkRight.SetBool("WalkingLeft", false);
                animatorWalkUp.SetBool("WalkUp", false);

                animatorWalkLeft.SetBool("Left Idle", true);
                animatorWalkDown.SetBool("FrontIdle", true);
                animatorWalkRight.SetBool("Left Idle", true);
                animatorWalkUp.SetBool("WalkUpIdle", true);

                animatorWalkLeft.SetBool("pickup", true);
                animatorWalkDown.SetBool("pickup", true);
                animatorWalkRight.SetBool("pickup", true);
                animatorWalkUp.SetBool("pickup", true);
                movement.canMove = false;
                ItemID = "grass";
                ID = "grass";

            }
            else if (ItemType == MyEnum.Stick)
            {
                BackSprite.SetActive(true);
                LeftSprite.SetActive(false);
                RightSprite.SetActive(false);
                BottomSprite.SetActive(false);

                animatorWalkLeft.SetBool("WalkingLeft", false);
                animatorWalkDown.SetBool("WalkDown", false);
                animatorWalkRight.SetBool("WalkingLeft", false);
                animatorWalkUp.SetBool("WalkUp", false);

                animatorWalkLeft.SetBool("Left Idle", true);
                animatorWalkDown.SetBool("FrontIdle", true);
                animatorWalkRight.SetBool("Left Idle", true);
                animatorWalkUp.SetBool("WalkUpIdle", true);

                animatorWalkLeft.SetBool("pickup", true);
                animatorWalkDown.SetBool("pickup", true);
                animatorWalkRight.SetBool("pickup", true);
                animatorWalkUp.SetBool("pickup", true);
                movement.canMove = false;
                ItemID = "stick";
                ID = "stick";
            }
            else if (ItemType == MyEnum.Rock)
            {

                animatorWalkLeft.SetBool("WalkingLeft", false);
                animatorWalkDown.SetBool("WalkDown", false);
                animatorWalkRight.SetBool("WalkingLeft", false);
                animatorWalkUp.SetBool("WalkUp", false);

                animatorWalkLeft.SetBool("Left Idle", true);
                animatorWalkDown.SetBool("FrontIdle", true);
                animatorWalkRight.SetBool("Left Idle", true);
                animatorWalkUp.SetBool("WalkUpIdle", true);

                animatorWalkLeft.SetBool("pickup", true);
                animatorWalkDown.SetBool("pickup", true);
                animatorWalkRight.SetBool("pickup", true);
                animatorWalkUp.SetBool("pickup", true);
                movement.canMove = false;
                ItemID = "rock";
                ID = "rock";
            }
            else if (ItemType == MyEnum.Berries)
            {
                BackSprite.SetActive(true);
                LeftSprite.SetActive(false);
                RightSprite.SetActive(false);
                BottomSprite.SetActive(false);

                animatorWalkLeft.SetBool("WalkingLeft", false);
                animatorWalkDown.SetBool("WalkDown", false);
                animatorWalkRight.SetBool("WalkingLeft", false);
                animatorWalkUp.SetBool("WalkUp", false);

                animatorWalkLeft.SetBool("Left Idle", true);
                animatorWalkDown.SetBool("FrontIdle", true);
                animatorWalkRight.SetBool("Left Idle", true);
                animatorWalkUp.SetBool("WalkUpIdle", true);

                animatorWalkLeft.SetBool("pickup", true);
                animatorWalkDown.SetBool("pickup", true);
                animatorWalkRight.SetBool("pickup", true);
                animatorWalkUp.SetBool("pickup", true);
                movement.canMove = false;
                ItemID = "berries";
                ID = "berries";
            }
            else if (ItemType == MyEnum.Flower)
            {

                animatorWalkLeft.SetBool("WalkingLeft", false);
                animatorWalkDown.SetBool("WalkDown", false);
                animatorWalkRight.SetBool("WalkingLeft", false);
                animatorWalkUp.SetBool("WalkUp", false);

                animatorWalkLeft.SetBool("Left Idle", true);
                animatorWalkDown.SetBool("FrontIdle", true);
                animatorWalkRight.SetBool("Left Idle", true);
                animatorWalkUp.SetBool("WalkUpIdle", true);

                animatorWalkLeft.SetBool("pickup", true);
                animatorWalkDown.SetBool("pickup", true);
                animatorWalkRight.SetBool("pickup", true);
                animatorWalkUp.SetBool("pickup", true);
                movement.canMove = false;
                ItemID = "flower";
                ID = "flower";
            }

        }
    }
    //zorgt ervoor dat de functions die dingen aan je inv adden aangeroepen worden
    

    //add stuff to inventory
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

}
