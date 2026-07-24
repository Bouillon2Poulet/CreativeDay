
using UnityEngine;
using static UserEvent;

public class IntroState : ExpState
{

    public IntroState(ExpFSM fsm) : base(fsm)
    {
        AddAcceptedEvent(UserEvent.START_BUTTON_CLICKED);
    }

    public override void OnEnter()
    {
        base.OnEnter();

        // If we don't want an IntroState, we can directly switch to Neutral state
        m_BaseFSM.SwitchTo(NEUTRAL);
    }


    public override void ConsumeEvent(AbstractEvent myEvent)
    {
        switch (myEvent.m_Id)
        {
            case START_BUTTON_CLICKED:
                break;

            //case NEXT_CLICKED:
            //    if (m_HasPreparedExpData)
            //    {
            //        m_BaseFSM.SwitchTo(PERFORMING_BLOCK_ID);
            //    }
            //    break;

            default:
                Debug.LogWarning("Event " + myEvent.m_Id + " cannot be consumed by Intro_State and will thus be ignored");
                break;
        }
    }


    public override void OnExit()
    {
        base.OnExit();
    }

    public override string GetDisplayName()
    {
        return "Introduction";
    }
}
