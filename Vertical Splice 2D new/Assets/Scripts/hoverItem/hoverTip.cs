using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverTip : MonoBehaviour
{
    public string tipToShow;
    void OnMouseOver()
    {
        hoverTipManager.onMouseHover(tipToShow, Input.mousePosition);
    }

    private void OnMouseExit()
    {
        hoverTipManager.onMouseExit();
    }
}