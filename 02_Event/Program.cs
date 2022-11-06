
MyClass instance = new MyClass();

// add Handlers
instance.MyEvent += new DelegateForEvent(Handler1);
instance.MyEvent += new DelegateForEvent(Handler2);

//instance.MyEvent += Handler1;
//instance.MyEvent += Handler2;

// մեթոդ որը իրականացնում է իրադարձությունը
instance.MethodWichInvokeEvent();

Console.WriteLine(new string('-', 20));

// remove Handler2().
instance.MyEvent -= new DelegateForEvent(Handler2);
instance.MethodWichInvokeEvent();