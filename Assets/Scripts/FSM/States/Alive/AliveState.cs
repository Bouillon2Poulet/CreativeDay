using UnityEngine;
using static EnvironmentDataManager;

public class AliveState : ExpState
{

    public AliveState(ExpFSM fsm) : base(fsm)
    {
        AddAcceptedEvent(UserEvent.ITEM_BUTTON_CLICKED);
    }


    public override void ConsumeEvent(AbstractEvent myEvent)
    {
        switch (myEvent.m_Id)
        {
            case UserEvent.ITEM_BUTTON_CLICKED:
                ItemButtonClickedEvent tmpEvent = (ItemButtonClickedEvent)myEvent;
                switch (tmpEvent.m_SelectedCategory)
                {
                    case UniverseType.FARM:
                        Debug.Log("Adding a farmer item to Ritchie");
                        DataManager.Instance.AddItemToReachy(UniverseType.FARM);

                        if (DataManager.Instance.NeedUniverseTransition())
                        {
                            m_BaseFSM.SwitchTo(AbstractState.FARMER);
                        }

                        break;

                    case UniverseType.WARRIOR:
                        Debug.Log("Adding a warrior item to Ritchie");
                        DataManager.Instance.AddItemToReachy(UniverseType.WARRIOR);
                        if (DataManager.Instance.NeedUniverseTransition())
                        {
                            m_BaseFSM.SwitchTo(AbstractState.WARRIOR);
                        }
                        break;

                    case UniverseType.SPACE:
                        Debug.Log("Adding a space item to Ritchie");
                        DataManager.Instance.AddItemToReachy(UniverseType.SPACE);

                        if (DataManager.Instance.NeedUniverseTransition())
                        {
                            m_BaseFSM.SwitchTo(AbstractState.SPACE);
                        }
                        break;
                }


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


}
