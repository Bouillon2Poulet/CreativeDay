using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ItemContainerHandler : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> m_Items;


    void Start()
    {
        m_Items = new List<GameObject>();
        DisableAllItems();
    }


    public void EnableItemAtRandom()
    {
        int index = Random.Range(0, m_Items.Count);

        while (m_Items[index].activeInHierarchy) 
        {
            index = Random.Range(0, m_Items.Count);
        }
        m_Items[index].SetActive(true);
    }

    public void DisableAllItems()
    {
        foreach (GameObject item in m_Items)
        {
            item.SetActive(false);
        }
    }

}
