using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeSlot : MonoBehaviour
{
    public bool SlotFree()
    {
        if (GetComponent<Image>().sprite != null)
        {
            print("false");
            return false;
            
        }
        else
        {
            return true;
        }
    }
}
