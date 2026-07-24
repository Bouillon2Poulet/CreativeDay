using UnityEngine;
using static EnvironmentDataManager;

public class ReachyItem
{
    public UniverseType m_Category { get; protected set; }
    public GameObject m_Prefab { get; protected set; }


    public ReachyItem(UniverseType category)
    {
        m_Category = category;
    }


    public ReachyItem(UniverseType category, GameObject prefab)
    {
        m_Category = category;
        m_Prefab = prefab;
    }


}
