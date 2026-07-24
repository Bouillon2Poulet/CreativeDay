using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasicFSM
{
    protected Dictionary<int, AbstractState> m_States;
    protected AbstractState m_CurrentState;
    //public ExpWorkflow_Manager m_ExpManager;


    public BasicFSM() 
    {
        m_States = new Dictionary<int, AbstractState>();
    }

    public void Authorize(AbstractState state, int id)
    {
        m_States.Add(id, state);
    }


    public AbstractState GetState(int key)
    {
        if (m_States.ContainsKey(key))
        {
            return m_States[key];
        }
        throw new System.Exception("State key " + key + " does not exist in the possible states list");
    }


    // Transitionning to a new state
    public void SwitchTo(int nextStateKey)
    {
        AbstractState next = GetState(nextStateKey);
        if (next != null)
        {
            // Exit the state we were in before
            if (m_CurrentState != null)
            {
                m_CurrentState.OnExit();
            }
            // Enter into the new state
            m_CurrentState = next;
            m_CurrentState.OnEnter();
        }
    }


    public void OnEventReceived(AbstractEvent myEvent)
    {
        m_CurrentState.OnUserEvent(myEvent);
    }

    public string GetCurrentStateName()
    {
        return m_CurrentState.GetDisplayName();
    }
}
