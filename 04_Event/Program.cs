

//public class MyClass : MyInterface
//{
//    public event EventDelegate MyEvent
//    {
//        add { MyEvent += value; }
//        remove { MyEvent -= value; }
//    }
//}

DerivedClass instance = new DerivedClass();

// add
instance.MyEvent += new EventDelegate(Handler1);
instance.MyEvent += new EventDelegate(Handler2);

// 
instance.InvokeEvent();

Console.WriteLine(new string('-', 20));

// remove Handler2().
instance.MyEvent -= new EventDelegate(Handler2);
instance.InvokeEvent();
