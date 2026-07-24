using UnityEngine;

public class FarmerState : AliveState
{
    public FarmerState(ExpFSM fsm) : base(fsm)
    {
    }

    public override void OnEnter()
    {
        base.OnEnter();
        DataManager.Instance.SwitchToUniverse(EnvironmentDataManager.UniverseType.FARM);
    }

    public override void ConsumeEvent(AbstractEvent myEvent)
    {
        base.ConsumeEvent(myEvent);
    }
}
