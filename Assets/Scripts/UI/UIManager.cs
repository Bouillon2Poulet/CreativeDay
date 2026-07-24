using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    private static UIManager instance = null;
    public static UIManager Instance => instance;

    [SerializeField]
    private ItemContainerHandler m_FarmItemsHandler;

    [SerializeField]
    private ItemContainerHandler m_WarriorItemsHandler;

    [SerializeField]
    private ItemContainerHandler m_SpaceItemsHandler;



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
        
    }


    public void OnFarmItemAdded()
    {
        m_FarmItemsHandler.EnableItemAtRandom();
    }

    public void OnWarriorItemAdded()
    {
        m_WarriorItemsHandler.EnableItemAtRandom();
    }

    public void OnSpaceItemAdded()
    {
        m_SpaceItemsHandler.EnableItemAtRandom();
    }

    public void OnClearAllItems()
    {
        m_FarmItemsHandler.DisableAllItems();
        m_WarriorItemsHandler.DisableAllItems();
        m_SpaceItemsHandler.DisableAllItems();
    }


    public void ExpNextButtonClicked()
    {
        //ExpWorkflow_Manager.Instance.PassUserEventToFSM(new UserEvent(UserEvent.NEXT_CLICKED));
    }

}
