using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Inventory : Item
{
    public SlotIconChecker iconChecker;

    public TextMeshProUGUI Slot1amount;
    public TextMeshProUGUI Slot2amount;
    public TextMeshProUGUI Slot3amount;
    public TextMeshProUGUI Slot4amount;
    public TextMeshProUGUI Slot5amount;
    List<Image> Itemslots = new List<Image>();

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

    
    public FreeSlot Slot1OB;
    public FreeSlot Slot2OB;
    public FreeSlot Slot3OB;
    public FreeSlot Slot4OB;
    public FreeSlot Slot5OB;
    public FreeSlot Slot6OB;
    public FreeSlot Slot7OB;
    public FreeSlot Slot8OB;
    public FreeSlot Slot9OB;
    public FreeSlot Slot10OB;
    public FreeSlot Slot11OB;
    public FreeSlot Slot12OB;



    
    [HideInInspector] public bool _Slot1Free = true;
    [HideInInspector] public bool _Slot2Free = true;
    [HideInInspector] public bool _Slot3Free = true;
    [HideInInspector] public bool _Slot4Free = true;
    [HideInInspector] public bool _Slot5Free = true;
    [HideInInspector] public bool _Slot6Free = true;
    [HideInInspector] public bool _Slot7Free = true;
    [HideInInspector] public bool _Slot8Free = true;
    [HideInInspector] public bool _Slot9Free = true;
    [HideInInspector] public bool _Slot10Free = true;
    [HideInInspector] public bool _Slot11Free = true;
    [HideInInspector] public bool _Slot12Free = true;
    [HideInInspector] public bool _Slot13Free = true;
    [HideInInspector] public bool _Slot14Free = true;
    [HideInInspector] public bool _Slot15Free = true;
    

    


    [HideInInspector] public int _Amount_grass;
    [HideInInspector] public int _Amount_stick;
    [HideInInspector] public int _Amount_rock;
    [HideInInspector] public int _Amount_Berries;
    [HideInInspector] public int _Amount_Flowers;



    private void Update()
    {
        _Slot1Free = Slot1OB.SlotFree();
        _Slot2Free = Slot2OB.SlotFree();
        _Slot3Free = Slot3OB.SlotFree();
        _Slot4Free = Slot4OB.SlotFree();
        _Slot5Free = Slot5OB.SlotFree();
        _Slot6Free = Slot6OB.SlotFree();
        _Slot7Free = Slot7OB.SlotFree();
        _Slot8Free = Slot8OB.SlotFree();
        _Slot9Free = Slot9OB.SlotFree();

    }
    public void PickUpLimit(string itemName)
    {
        switch (itemName)
        {
            case "Grass":
                if (_Amount_grass < 40)
                {
                    _Amount_grass++;
                }
                else if (_Amount_grass >= 40)
                {
                    //display error msg
                    print("max grass");
                }
                break;

            case "Stick":
                if (_Amount_stick < 40)
                {
                    _Amount_stick++;
                }
                else if (_Amount_stick >= 40)
                {
                    //display error msg
                    print("max stick");
                }
                break;


            case "Rock":
                if (_Amount_rock < 40)
                {
                    _Amount_rock++;
                }
                else if (_Amount_rock >= 40)
                {
                    //display error msg
                    print("max rock");
                }
                break;
            case "Flower":
                if (_Amount_Flowers < 40)
                {
                    _Amount_Flowers++;
                }
                else if (_Amount_Flowers >= 40)
                {
                    //display error msg
                    print("max Flowers");
                }
                break;
            case "Berries":
                if (_Amount_Berries < 40)
                {
                    _Amount_Berries++;
                }
                else if (_Amount_Berries >= 40)
                {
                    //display error msg
                    print("max Flowers");
                }
                break;
        }
    }



    public void UpdateAmount()
    {
        if (Slot1.sprite == grass)
        {
            Slot1amount.text = _Amount_grass.ToString();
        }
        else if (Slot1.sprite == rock)
        {
            Slot1amount.text = _Amount_rock.ToString();
        }
        else if (Slot1.sprite == stick)
        {
            Slot1amount.text = _Amount_stick.ToString();
        }
        else if(Slot1.sprite == flower)
        {
            Slot1amount.text = _Amount_Flowers.ToString();
        }
        else if (Slot1.sprite == berries)
        {
            Slot1amount.text = _Amount_Berries.ToString();
        }


        if (Slot2.sprite == grass)
        {
            Slot2amount.text = _Amount_grass.ToString();
        }
        else if (Slot2.sprite == rock)
        {
            Slot2amount.text = _Amount_rock.ToString();
        }
        else if (Slot2.sprite == stick)
        {
            Slot2amount.text = _Amount_stick.ToString();
        }
        else if(Slot2.sprite == flower)
        {
            Slot2amount.text = _Amount_Flowers.ToString();
        }
        else if (Slot2.sprite == berries)
        {
            Slot2amount.text = _Amount_Berries.ToString();
        }


        if (Slot3.sprite == grass)
        {
            Slot3amount.text = _Amount_grass.ToString();
        }
        else if (Slot3.sprite == rock)
        {
            Slot3amount.text = _Amount_rock.ToString();
        }
        else if (Slot3.sprite == stick)
        {
            Slot3amount.text = _Amount_stick.ToString();
        }
        else if(Slot3.sprite == flower)
        {
            Slot3amount.text = _Amount_Flowers.ToString();
        }
        else if (Slot3.sprite == berries)
        {
            Slot3amount.text = _Amount_Berries.ToString();
        }


        if (Slot4.sprite == grass)
        {
            Slot4amount.text = _Amount_grass.ToString();
        }
        else if (Slot4.sprite == rock)
        {
            Slot4amount.text = _Amount_rock.ToString();
        }
        else if (Slot4.sprite == stick)
        {
            Slot4amount.text = _Amount_stick.ToString();
        }
        else if(Slot4.sprite == flower)
        {
            Slot4amount.text = _Amount_Flowers.ToString();
        }
        else if (Slot4.sprite == berries)
        {
            Slot4amount.text = _Amount_Berries.ToString();
        }


        if (Slot5.sprite == grass)
        {
            Slot5amount.text = _Amount_grass.ToString();
        }
        else if (Slot5.sprite == rock)
        {
            Slot5amount.text = _Amount_rock.ToString();
        }
        else if (Slot5.sprite == stick)
        {
            Slot5amount.text = _Amount_stick.ToString();
        }
        else if (Slot5.sprite == flower)
        {
            Slot5amount.text = _Amount_Flowers.ToString();
        }
        else if (Slot5.sprite == berries)
        {
            Slot5amount.text = _Amount_Berries.ToString();
        }

    }

    public void Additem(string ItemName, Sprite ItemSprite)
    {
                

                switch (ItemName)
                {
                    case "Grass":


                        if (_Slot1Free == true)
                        {
                            SlotCheck(1, ItemSprite);
                        }
                        else if (_Slot1Free == false && Slot1.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot2Free == true)
                        {
                            SlotCheck(2, ItemSprite);
                        }
                        else if (_Slot2Free == false && Slot2.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot3Free == true)
                        {
                            SlotCheck(3, ItemSprite);
                        }
                        else if (_Slot3Free == false && Slot3.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot4Free == true)
                        {
                            SlotCheck(4, ItemSprite);
                        }
                        else if (_Slot4Free == false && Slot4.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot5Free == true)
                            {
                                SlotCheck(5, ItemSprite);
                            }
                        else if(_Slot5Free == false && Slot5.sprite == ItemSprite)
                        {
                            UpdateAmount();
                    }
                    //incase het er meer items komen
                    /*
                        else if (_Slot6Free == true)
                        {
                            SlotCheck(6, ItemSprite);
                        }
                        else if (_Slot7Free == true)
                        {
                            SlotCheck(7, ItemSprite);
                        }
                        else if (_Slot8Free == true)
                        {
                            SlotCheck(8, ItemSprite);
                        }
                        else if(_Slot9Free == true)
                        {
                            SlotCheck(9, ItemSprite);
                        }
                        else if(_Slot10Free == true)
                        {
                            SlotCheck(10, ItemSprite);
                        }
                        else if (_Slot11Free == true)
                        {
                            SlotCheck(11, ItemSprite);
                        }
                        else if (_Slot12Free == true)
                        {
                            SlotCheck(12, ItemSprite);
                        }
                   
                        else
                        {
                            UpdateAmount();
                        }
                    */

                        break;

                    case "Rock":
                        if (_Slot1Free == true)
                        {
                            SlotCheck(1, ItemSprite);
                        }
                        else if (_Slot1Free == false && Slot1.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot2Free == true)
                        {
                            SlotCheck(2, ItemSprite);
                        }
                        else if (_Slot2Free == false && Slot2.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot3Free == true)
                        {
                            SlotCheck(3, ItemSprite);
                        }
                        else if (_Slot3Free == false && Slot3.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot4Free == true)
                        {
                            SlotCheck(4, ItemSprite);
                        }
                        else if (_Slot4Free == false && Slot4.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot5Free == true)
                        {
                            SlotCheck(5, ItemSprite);
                        }
                        else if (_Slot5Free == false && Slot5.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                    break;


                    case "Stick":
                        if (_Slot1Free == true)
                        {
                            SlotCheck(1, ItemSprite);
                        }
                        else if (_Slot1Free == false && Slot1.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot2Free == true)
                        {
                            SlotCheck(2, ItemSprite);
                        }
                        else if (_Slot2Free == false && Slot2.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot3Free == true)
                        {
                            SlotCheck(3, ItemSprite);
                        }
                        else if (_Slot3Free == false && Slot3.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot4Free == true)
                        {
                            SlotCheck(4, ItemSprite);
                        }
                        else if (_Slot4Free == false && Slot4.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot5Free == true)
                        {
                            SlotCheck(5, ItemSprite);
                        }
                        else if (_Slot5Free == false && Slot5.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }

                     break;
                    case "Flower":
                        if (_Slot1Free == true)
                        {
                            SlotCheck(1, ItemSprite);
                        }
                        else if (_Slot1Free == false && Slot1.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot2Free == true)
                        {
                            SlotCheck(2, ItemSprite);
                        }
                        else if (_Slot2Free == false && Slot2.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot3Free == true)
                        {
                            SlotCheck(3, ItemSprite);
                        }
                        else if (_Slot3Free == false && Slot3.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot4Free == true)
                        {
                            SlotCheck(4, ItemSprite);
                        }
                        else if (_Slot4Free == false && Slot4.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot5Free == true)
                        {
                            SlotCheck(5, ItemSprite);
                        }
                        else if (_Slot5Free == false && Slot5.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        break;
                    case "Berries":
                        if (_Slot1Free == true)
                        {
                            SlotCheck(1, ItemSprite);
                        }
                        else if (_Slot1Free == false && Slot1.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot2Free == true)
                        {
                            SlotCheck(2, ItemSprite);
                        }
                        else if (_Slot2Free == false && Slot2.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot3Free == true)
                        {
                            SlotCheck(3, ItemSprite);
                        }
                        else if (_Slot3Free == false && Slot3.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot4Free == true)
                        {
                            SlotCheck(4, ItemSprite);
                        }
                        else if (_Slot4Free == false && Slot4.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        else if (_Slot5Free == true)
                        {
                            SlotCheck(5, ItemSprite);
                        }
                        else if (_Slot5Free == false && Slot5.sprite == ItemSprite)
                        {
                            UpdateAmount();
                        }
                        break;


        }

}
    

    private void SlotCheck(int SlotNumber , Sprite ItemSprite)
    {
        switch (SlotNumber)
        {
            case 1:
            //    _Slot1Free = false;
                iconChecker.SlotsIconcheck(Slot1, ItemSprite);
                break;
            case 2:
             //   _Slot2Free = false;
                iconChecker.SlotsIconcheck(Slot2, ItemSprite);
                break;
            case 3:
             //   _Slot3Free = false;
                iconChecker.SlotsIconcheck(Slot3, ItemSprite);
                break;
            case 4:
              //  _Slot4Free = false;
                iconChecker.SlotsIconcheck(Slot4, ItemSprite);
                break;
            case 5:
              //  _Slot5Free = false;
                iconChecker.SlotsIconcheck(Slot5, ItemSprite);
                break;
            case 6:
              //  _Slot5Free = false;
                iconChecker.SlotsIconcheck(Slot6, ItemSprite);
                break;
            case 7:
               // _Slot7Free = false;
                iconChecker.SlotsIconcheck(Slot7, ItemSprite);
                break;
            case 8:
              //  _Slot8Free = false;
                iconChecker.SlotsIconcheck(Slot8, ItemSprite);
                break;
            case 9:
              //  _Slot9Free = false;
                iconChecker.SlotsIconcheck(Slot9, ItemSprite);
                break;
            case 10:
              //  _Slot10Free = false;
                iconChecker.SlotsIconcheck(Slot10, ItemSprite);
                break;
            case 11:
               // _Slot11Free = false;
                iconChecker.SlotsIconcheck(Slot11, ItemSprite);
                break;
            case 12:
               // _Slot12Free = false;
                iconChecker.SlotsIconcheck(Slot12, ItemSprite);
                break;

            default:
                print("case out of bouns");
                break;
        }
        
    

    
    if (_Slot1Free == true)
    {
        if (Slot2.sprite != ItemSprite && Slot3.sprite != ItemSprite && Slot4.sprite != ItemSprite && Slot5.sprite != ItemSprite && Slot6.sprite != ItemSprite && Slot7.sprite != ItemSprite && Slot8.sprite && Slot9.sprite != ItemSprite && Slot10.sprite != ItemSprite && Slot11.sprite != ItemSprite && Slot12.sprite != ItemSprite)
        {
           // _Slot1Free = false;
            iconChecker.SlotsIconcheck(Slot1, ItemSprite);
        }
    }

    //als je het voor het eerst koopt
    else if (_Slot2Free == true)
    {
        if (Slot1.sprite != ItemSprite && Slot3.sprite != ItemSprite && Slot4.sprite != ItemSprite && Slot5.sprite != ItemSprite && Slot6.sprite != ItemSprite && Slot7.sprite != ItemSprite && Slot8.sprite && Slot9.sprite != ItemSprite && Slot10.sprite != ItemSprite && Slot11.sprite != ItemSprite && Slot12.sprite != ItemSprite)
        {
            //_Slot2Free = false;
            iconChecker.SlotsIconcheck(Slot2, ItemSprite);
        }
    }

        //als je het voor het eerst koop
        else if (_Slot3Free == true)
        {
            if (Slot1.sprite != ItemSprite && Slot2.sprite != ItemSprite && Slot4.sprite != ItemSprite && Slot5.sprite != ItemSprite && Slot6.sprite != ItemSprite && Slot7.sprite != ItemSprite && Slot8.sprite && Slot9.sprite != ItemSprite && Slot10.sprite != ItemSprite && Slot11.sprite != ItemSprite && Slot12.sprite != ItemSprite)
            {
                //_Slot3Free = false;
                iconChecker.SlotsIconcheck(Slot3, ItemSprite);
            }
        }
        if (_Slot4Free == true)
        {
            if (Slot1.sprite != ItemSprite && Slot2.sprite != ItemSprite && Slot3.sprite != ItemSprite  && Slot5.sprite != ItemSprite && Slot6.sprite != ItemSprite && Slot7.sprite != ItemSprite && Slot8.sprite && Slot9.sprite != ItemSprite && Slot10.sprite != ItemSprite && Slot11.sprite != ItemSprite && Slot12.sprite != ItemSprite)
            {
               // _Slot1Free = false;
                iconChecker.SlotsIconcheck(Slot1, ItemSprite);
            }
        }
        if(_Slot5Free == true)
        {

            if (Slot1.sprite != ItemSprite && Slot2.sprite != ItemSprite && Slot3.sprite != ItemSprite && Slot4.sprite != ItemSprite  && Slot6.sprite != ItemSprite && Slot7.sprite != ItemSprite && Slot8.sprite && Slot9.sprite != ItemSprite && Slot10.sprite != ItemSprite && Slot11.sprite != ItemSprite && Slot12.sprite != ItemSprite)
            {
                // _Slot1Free = false;
                iconChecker.SlotsIconcheck(Slot5, ItemSprite);
            }
        } 
    }
}



