using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static EnvironmentDataManager;

public class ReachyItemsManager : MonoBehaviour
{
    [SerializeField]
    private EnvironmentDataManager m_EnvironmentManager;

    private int m_CurrentNbHoldItems;

    private List<ReachyItem> m_FarmItems;
    private List<ReachyItem> m_WarriorItems;
    private List<ReachyItem> m_SpaceItems;



    public const int MAX_ITEMS_BEFORE_UNIVERSE_CHANGE = 3;


    void Start()
    {
        m_CurrentNbHoldItems = 0;
        m_FarmItems = new List<ReachyItem>();
        m_WarriorItems = new List<ReachyItem>();
        m_SpaceItems = new List<ReachyItem>();
    }


    public void AddItem(UniverseType universe)
    {
        switch (universe)
        {
            case UniverseType.FARM:
                // Si on est déjà au max d'objets de ce type, réinitialise l'équipement et change l'environnement
                if (m_FarmItems.Count >= MAX_ITEMS_BEFORE_UNIVERSE_CHANGE)
                {
                    ResetItems();
                    m_EnvironmentManager.SetNextUniverse(universe);
                }
                // Sinon, active un objet de ce type au hasard
                else
                {
                    ReachyItem newItem = new ReachyItem(UniverseType.FARM);
                    m_FarmItems.Add(newItem);
                    m_CurrentNbHoldItems++;
                    UIManager.Instance.OnFarmItemAdded();
                }
                break;

            case UniverseType.WARRIOR:
                // Si on est déjà au max d'objets de ce type, réinitialise l'équipement et change l'environnement
                if (m_WarriorItems.Count >= MAX_ITEMS_BEFORE_UNIVERSE_CHANGE)
                {
                    ResetItems();
                    m_EnvironmentManager.SetNextUniverse(universe);
                }
                // Sinon, active un objet de ce type au hasard
                else
                {
                    ReachyItem newItem = new ReachyItem(UniverseType.WARRIOR);
                    m_WarriorItems.Add(newItem);
                    m_CurrentNbHoldItems++;
                    UIManager.Instance.OnWarriorItemAdded();
                }
                break;

            case UniverseType.SPACE:
                // Si on est déjà au max d'objets de ce type, réinitialise l'équipement et change l'environnement
                if (m_SpaceItems.Count >= MAX_ITEMS_BEFORE_UNIVERSE_CHANGE)
                {
                    ResetItems();
                    m_EnvironmentManager.SetNextUniverse(universe);
                }
                // Sinon, active un objet de ce type au hasard
                else
                {
                    ReachyItem newItem = new ReachyItem(UniverseType.SPACE);
                    m_SpaceItems.Add(newItem);
                    m_CurrentNbHoldItems++;
                    UIManager.Instance.OnSpaceItemAdded();
                }
                break;

            default:
                throw new System.ArgumentException("I don't know how to add an item of type " + universe + ". Add operation cancelled");
        }
    }




    public void ResetItems()
    {
        m_CurrentNbHoldItems = 0;
        m_FarmItems.Clear();
        m_WarriorItems.Clear();
        m_SpaceItems.Clear();

        UIManager.Instance.OnClearAllItems();
    }


}
