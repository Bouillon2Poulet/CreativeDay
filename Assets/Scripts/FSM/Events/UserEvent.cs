using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserEvent : AbstractEvent
{
    // Basic user interaction with GUI
    public const int START_BUTTON_CLICKED = 0;
    public const int ITEM_BUTTON_CLICKED = 1;



    public UserEvent(int id) : base(id)
    {
    }

}
