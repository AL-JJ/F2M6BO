using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playanim : MonoBehaviour
{
    public Item item;
    public Pickup pickup;

    private void Update()
    {
        item = pickup.col.GetComponent<Item>();
    }
    public void PickUpAnimation()
    {

        switch (item.ID)
        {
            case "grass":
                item.GrassPickUp();
                item.inv.UpdateAmount();

                item.animatorWalkLeft.SetBool("pickup", false);
                item.animatorWalkDown.SetBool("pickup", false);
                item.animatorWalkRight.SetBool("pickup", false);
                item.animatorWalkUp.SetBool("pickup", false);
                item.movement.canMove = true;

                Destroy(pickup.col);
                break;
            case "stick":
                item.StickPickUp();
                item.inv.UpdateAmount();

                item.animatorWalkLeft.SetBool("pickup", false);
                item.animatorWalkDown.SetBool("pickup", false);
                item.animatorWalkRight.SetBool("pickup", false);
                item.animatorWalkUp.SetBool("pickup", false);
                item.movement.canMove = true;

                Destroy(pickup.col);
                break;
            case "rock":
                item.RockPickUp();
                item.inv.UpdateAmount();

                item.animatorWalkLeft.SetBool("pickup", false);
                item.animatorWalkDown.SetBool("pickup", false);
                item.animatorWalkRight.SetBool("pickup", false);
                item.animatorWalkUp.SetBool("pickup", false);
                item.movement.canMove = true;

                Destroy(pickup.col);
                break;
            case "berries":
                item.BerriesPickUp();
                item.inv.UpdateAmount();

                item.animatorWalkLeft.SetBool("pickup", false);
                item.animatorWalkDown.SetBool("pickup", false);
                item.animatorWalkRight.SetBool("pickup", false);
                item.animatorWalkUp.SetBool("pickup", false);
                item.movement.canMove = true;

                Destroy(pickup.col);
                break;
            case "flower":
                item.FlowerPickup();
                item.inv.UpdateAmount();


                item.animatorWalkLeft.SetBool("pickup", false);
                item.animatorWalkDown.SetBool("pickup", false);
                item.animatorWalkRight.SetBool("pickup", false);
                item.animatorWalkUp.SetBool("pickup", false);
                item.movement.canMove = true;

                Destroy(pickup.col);
                break;
        }
    }
}
