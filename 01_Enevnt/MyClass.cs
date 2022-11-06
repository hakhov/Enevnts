
    public class MyClass
    {
        public event DelegateForEvent? MyEvent = null;

        public void MethodWichInvokeEvent()
        {
            MyEvent?.Invoke();
        }
    }
