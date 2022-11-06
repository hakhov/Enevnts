public delegate void EventDelegate();

public partial class Program
{
    static private void Handler1()
    {
        Console.WriteLine("Event Handler 1");
    }

    static private void Handler2()
    {
        Console.WriteLine("Event Handler 2");
    }
}
