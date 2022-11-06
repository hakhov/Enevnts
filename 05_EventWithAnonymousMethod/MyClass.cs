public delegate void EventDelegate();

public class MyClass
{
    public event EventDelegate? MyEvent = null;

    public void InvokeEvent()
    {
        MyEvent?.Invoke();
    }
}
