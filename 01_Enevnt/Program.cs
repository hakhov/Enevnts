
//պետք է լինի օբյեկտ, որին կվերաբերվի իրադարձությունը և նրա ներսում մեթոդ որը կմշակի այդ իրադարձությունը

MyClass instance = new MyClass();

instance.MyEvent += Handler1; //new DelegateForEvent(Handler1);
instance.MyEvent += Handler2;

// մեթոդ որը կանչում է իրադարձություն
instance.MethodWichInvokeEvent();

Console.WriteLine(new string('-', 20));

// անջատում ենք Handler2().
instance.MyEvent -= new DelegateForEvent(Handler2);

instance.MethodWichInvokeEvent();

