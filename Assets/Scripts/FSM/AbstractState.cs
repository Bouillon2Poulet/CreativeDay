
using System.Collections.Generic;

public abstract class AbstractState
{
    public int m_StateId { get; protected set; }
    protected BasicFSM m_BaseFSM;
    protected LinkedList<int> m_AcceptedEvents;

    public static int INTRO_ID = 0;
    public static int NEUTRAL = 1;
    public static int FARMER = 2;
    public static int WARRIOR = 3;
    public static int SPACE = 4;
    public static int EXP_END_ID = 99;


    public AbstractState(BasicFSM fsm)
    {
        m_StateId = -1;
        m_BaseFSM = fsm;
        m_AcceptedEvents = new LinkedList<int>();
    }

    // Do not forget to override these methods in each subclass when required
    public virtual void OnEnter() { }
    public virtual void ConsumeEvent(AbstractEvent userEvent) { }
    public virtual void OnExit() { }
    public virtual void Update() { }


    // Upon receiving a given event, only handle it if it belongs to our "authorized event" collection
    // If it is not the case, nothing happens
    public void OnUserEvent(AbstractEvent myEvent)
    {
        if (m_AcceptedEvents.Contains(myEvent.m_Id))
        {
            ConsumeEvent(myEvent);
        }
    }

    public void AddAcceptedEvent(int id)
    {
        m_AcceptedEvents.AddLast(id);
    }

    public virtual void AcceptAllEvents()
    {
        // Add all possible UserEvents
        //AddAcceptedEvent(UserEvent.NEXT_CLICKED);

        // Add all possible AutoEvents

    }

    public virtual string GetDisplayName()
    {
        return "AbstractState";
    }
}
