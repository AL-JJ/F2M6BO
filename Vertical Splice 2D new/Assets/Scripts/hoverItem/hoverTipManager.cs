using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class hoverTipManager : MonoBehaviour
{
    public TextMeshProUGUI tipText;

    public static Action<string, Vector3> onMouseHover;
    public static Action onMouseExit;

    private void OnEnable()
    {
        onMouseHover += ShowTip;
        onMouseExit += HideTip;
    }

    private void OnDisable()
    {
        onMouseHover -= ShowTip;
        onMouseExit -= HideTip;

    }

    void Start()
    {
        HideTip();
    }

    private void ShowTip(string tip, Vector3 mousPos)
    {
        tipText.text = tip;
        tipText.transform.position = new Vector3(tipText.preferredWidth, tipText.preferredHeight);

        tipText.gameObject.SetActive(true);
        tipText.transform.position = new Vector3(mousPos.x, mousPos.y+100);
    }

    private void HideTip()
    {
        tipText.text = default;
        tipText.gameObject.SetActive(false);
    }
}
