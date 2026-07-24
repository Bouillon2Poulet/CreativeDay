using UnityEngine;

public class SpaceState : AliveState
{
    public SpaceState(ExpFSM fsm) : base(fsm)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();
        DataManager.Instance.SwitchToUniverse(EnvironmentDataManager.UniverseType.SPACE);
    }

    public override void ConsumeEvent(AbstractEvent myEvent)
    {
        base.ConsumeEvent(myEvent);
    }
}
