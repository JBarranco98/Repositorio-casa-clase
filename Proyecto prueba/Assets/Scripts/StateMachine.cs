using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State currentState;

    private void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        State nextstate = currentState.RunCurrentState();
        if (nextstate != null)
        {
            currentState = nextstate;
        }
    }
}