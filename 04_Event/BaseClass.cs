// Event (abstract and virtual).

public class BaseClass : MyInterface
{
    //public virtual event EventDelegate? MyEvent = null;

    private EventDelegate? _myEvent = null;

    public virtual event EventDelegate MyEvent // virtual event
    {
        add { _myEvent += value; }
        remove { _myEvent -= value; }
    }

    public void InvokeEvent()
    {
        _myEvent?.Invoke();
    }
}