using UnityEngine;
using static ReachyItem;

public class EnvironmentDataManager : MonoBehaviour
{
    public enum UniverseType {NEUTRAL = 0, FARM = 0, WARRIOR = 1, SPACE = 2 };

    public UniverseType m_CurrentUniverse { get; protected set; }
    public UniverseType m_NextUniverse { get; protected set; }


    void Start()
    {
        m_CurrentUniverse = UniverseType.NEUTRAL;
        m_NextUniverse = UniverseType.NEUTRAL;
    }


    public void ChangeUniverseTo(UniverseType targetUniverse)
    {
        if (targetUniverse != m_CurrentUniverse)
        {
            m_CurrentUniverse = targetUniverse;
            m_NextUniverse = targetUniverse;
        }
    }

    public void SetNextUniverse(UniverseType targetUniverse)
    {
        m_NextUniverse = targetUniverse;
    }

    public bool IsUniverseTransitionNeeded()
    {
        return m_CurrentUniverse != m_NextUniverse;
    }

}
