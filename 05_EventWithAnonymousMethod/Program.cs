
MyClass instance = new MyClass();

// +
instance.MyEvent += new EventDelegate(Handler1);
instance.MyEvent += new EventDelegate(Handler2);
instance.MyEvent += delegate { Console.WriteLine("Event Handler from the Anonymouse Method1"); };

instance.InvokeEvent();

Console.WriteLine(new string('-', 20));

// - Handler2().
instance.MyEvent -= new EventDelegate(Handler2);

// չի կարա աշխատի
instance.MyEvent -= delegate { Console.WriteLine("Event Handler from the Anonymouse Method1"); };

instance.InvokeEvent();
