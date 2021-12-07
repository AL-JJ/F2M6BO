using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotIconChecker : Inventory
{
    List<Image> Items = new List<Image>();

    //check elke slot voor welke items er zijn
    public void AllSlots()
    {
        Items.Clear();
        Items.Add(Slot1);
        Items.Add(Slot2);
        Items.Add(Slot3);
        Items.Add(Slot4);
        Items.Add(Slot5);
        Items.Add(Slot6);
        Items.Add(Slot7);
        Items.Add(Slot8);
        Items.Add(Slot9);
        Items.Add(Slot10);
        Items.Add(Slot11);
        Items.Add(Slot12);
        Items.Add(Slot13);
        Items.Add(Slot14);
        Items.Add(Slot15);
    }
    public void SlotsIconcheck( Image CurrentSlot,Sprite ItemSprite)
    {
        AllSlots();
        foreach (var item in Items)
        {
            //als de sprite in 1 van de slots voor komt
            if(item.sprite == ItemSprite)
            {
                break;
            }
            //als het er niet is
            else
            {

                CurrentSlot.sprite = ItemSprite;
                break;
            }
        }
    }
}

