using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> m_FarmItemPrefabs;

    [SerializeField]
    private List<GameObject> m_WarriorItemPrefabs;

    [SerializeField]
    private List<GameObject> m_SpaceItemPrefabs;


    void Start()
    {
        
    }

    
}
