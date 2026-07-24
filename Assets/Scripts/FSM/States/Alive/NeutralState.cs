using UnityEngine;

public class NeutralState : AliveState
{
    public NeutralState(ExpFSM fsm) : base(fsm)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();
        DataManager.Instance.SwitchToUniverse(EnvironmentDataManager.UniverseType.NEUTRAL);
    }

    public override void ConsumeEvent(AbstractEvent myEvent)
    {
        base.ConsumeEvent(myEvent);
    }
}
