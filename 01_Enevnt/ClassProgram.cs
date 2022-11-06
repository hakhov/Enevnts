public delegate void DelegateForEvent();

public partial class  Program
{
    static private void Handler1()
    {
        Console.WriteLine("Event hendler 1");
    }

    static private void Handler2()
    {
        Console.WriteLine("Event hendler 2");
    }
}