using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndExpState : ExpState
{
    public EndExpState(ExpFSM fsm) : base(fsm)
    {
    }

    public override void OnEnter()
    {
    }

    public override string GetDisplayName()
    {
        return "Exp terminée, merci !";
    }
}
