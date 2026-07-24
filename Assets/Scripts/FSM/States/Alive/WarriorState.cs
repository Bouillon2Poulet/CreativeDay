using UnityEngine;

public class WarriorState : AliveState
{
    public WarriorState(ExpFSM fsm) : base(fsm)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();
        DataManager.Instance.SwitchToUniverse(EnvironmentDataManager.UniverseType.WARRIOR);
    }

    public override void ConsumeEvent(AbstractEvent myEvent)
    {
        base.ConsumeEvent(myEvent);
    }

}
