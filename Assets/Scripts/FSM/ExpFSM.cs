using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpFSM : BasicFSM
{

    public ExpFSM() : base()
    {
        Authorize(new IntroState(this), AbstractState.INTRO_ID);

        Authorize(new NeutralState(this), AbstractState.NEUTRAL);
        Authorize(new FarmerState(this), AbstractState.FARMER);
        Authorize(new WarriorState(this), AbstractState.WARRIOR);
        Authorize(new SpaceState(this), AbstractState.SPACE);

        Authorize(new EndExpState(this), AbstractState.EXP_END_ID);
    }

}
