using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    public Inventory inv;

    [HideInInspector] public Sprite stick;
    [HideInInspector] public Sprite rock;
    [HideInInspector] public Sprite grass;
    public void GrassPickUp()
    {
        inv.PickUpLimit("Grass");
        inv.Additem("Grass" , grass);
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
