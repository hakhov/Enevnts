// Event (abstract and virtual).

public class DerivedClass : BaseClass
{
    //public override event EventDelegate? MyEvent = null;

    public override event EventDelegate MyEvent // վերաիմաստավորում
    {
        add
        {
            base.MyEvent += value;
            Console.WriteLine($"BaseEvent + {value.Method.Name}");
        }

        remove
        {
            base.MyEvent -= value;
            Console.WriteLine($"BaseEvent - {value.Method.Name}");
        }
    }
}
