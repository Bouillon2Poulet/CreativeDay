using UnityEngine;
using static EnvironmentDataManager;

public class DataManager : MonoBehaviour
{
    [SerializeField]
    private ReachyItemsManager m_ReachyDataManager;

    [SerializeField]
    private EnvironmentDataManager m_EnvironmentManager;


    private static DataManager instance = null;
    public static DataManager Instance => instance;



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


    public void AddItemToReachy(UniverseType universe)
    {
        m_ReachyDataManager.AddItem(universe);
    }

    public UniverseType GetCurrentUniverse()
    {
        return m_EnvironmentManager.m_CurrentUniverse;
    }

    public bool NeedUniverseTransition()
    {
        return m_EnvironmentManager.IsUniverseTransitionNeeded();
    }

    public void SwitchToUniverse(UniverseType target)
    {
        Debug.Log("Switch to universe " + target);
        m_EnvironmentManager.ChangeUniverseTo(target);
    }
}
