using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

/// <summary>
/// Workflow_Manager: Singleton
/// Main entry point to manage the state of the experiment (the M of MVC)
/// It uses a Finite State Machine (FSM) to handle received events
/// </summary>
public class WorkflowManager : MonoBehaviour
{
    private static WorkflowManager instance = null;
    public static WorkflowManager Instance => instance;

    private ExpFSM m_ExpFSM;


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);

        // Rest of the initialization goes here
    }


    void Start()
    {
        m_ExpFSM = new ExpFSM();
        m_ExpFSM.SwitchTo(AbstractState.INTRO_ID);
    }


    public void RaiseAutoEvent(AutoEvent myEvent)
    {
        m_ExpFSM.OnEventReceived(myEvent);
    }


    public void PassUserEventToFSM(UserEvent uEvent)
    {
        m_ExpFSM.OnEventReceived(uEvent);
    }


    public string GetCurrentStateName()
    {
        return m_ExpFSM.GetCurrentStateName();
    }
}
