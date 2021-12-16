using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotIconChecker : MonoBehaviour
{
    List<Image> Items = new List<Image>();
    public Image Slot1;
    public Image Slot2;
    public Image Slot3;
    public Image Slot4;
    public Image Slot5;
    public Image Slot6;
    public Image Slot7;
    public Image Slot8;
    public Image Slot9;
    public Image Slot10;
    public Image Slot11;
    public Image Slot12;
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

