using UnityEngine;
using static EnvironmentDataManager;

public class ItemButtonClickedEvent : UserEvent
{
    public UniverseType m_SelectedCategory;


    public ItemButtonClickedEvent(int id, UniverseType itemCategory) : base(id)
    {
        m_SelectedCategory = itemCategory;
    }

}
