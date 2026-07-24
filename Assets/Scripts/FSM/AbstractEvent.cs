// Generic mother class for FSM events
public class AbstractEvent
{
    public int m_Id { get; protected set; }

    public AbstractEvent(int id) 
    {
        m_Id = id;
    }


}
