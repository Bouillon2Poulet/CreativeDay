using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoEvent : AbstractEvent
{
    // AutoEvent ids should begin at 100 to make sure not to mix them with UserEvent ids
    public const int DATA_PROCESSING_FINISHED = 100;

    public const int TRAVELLING_FINISHED = 101; 
    public const int TRAVELLING_GUIDANCE_EXPIRED = 102; 

    public const int BLOCK_STARTING = 112;
    public const int BLOCK_TRAINING_ENDED = 113;
    public const int BLOCK_ENDED = 114;

    public AutoEvent(int id) : base(id)
    {
    }
}
