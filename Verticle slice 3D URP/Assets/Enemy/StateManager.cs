using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{ //different kinds of states
   [HideInInspector]
    public enum State
    {
        Inactive,
        FoundPlayer,
        OutOfRange
    }
    public State state;


    private void Update()
    {
        switch (state)
        {
            case State.Inactive:
                    GetComponent<Shoot>().enabled = false;
                    GetComponent<TrackPlayer>().enabled = false;
                    break;

            case State.FoundPlayer:
                GetComponent<Shoot>().enabled = true;
                GetComponent<TrackPlayer>().enabled = true;
                break;

            case State.OutOfRange:
                //laat enemy naar player bewegen tot hij in range is
                break;
        }
    }

    public void ChangeBehavoir(string Type)
    {
        switch (Type)
        {
            case "Found":
                state = State.FoundPlayer;
                break;
            case "OutOfRange":
                state = State.OutOfRange;
                break;
        }
    }
}
