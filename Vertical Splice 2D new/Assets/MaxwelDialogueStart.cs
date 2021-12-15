using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxwelDialogueStart : MonoBehaviour
{
    public MaxwelDialogue Dialogue;
    public Animator WilsonAnimator;

    public void StartDialogue()
    {
        Dialogue.LineOne();
    }

    public void DialogueEnd()
    {
        WilsonAnimator.SetBool("getUp", true);
    }
}
