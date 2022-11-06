
public class MyClass
{
    private DelegateForEvent? _myEvent = null;

    // իրադարձաթյան add և remove
    public event DelegateForEvent MyEvent // նման է property - ին
    {
        add { _myEvent += value; }
        remove { _myEvent -= value; } // կարող ենք պայմաններ դնել
    }

    public void MethodWichInvokeEvent() => _myEvent?.Invoke();
}
