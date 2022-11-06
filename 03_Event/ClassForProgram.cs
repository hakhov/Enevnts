public delegate void PressKeyEventHandler();
public partial class Program
{
    static private void PressKeyA_Handler()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("    X    ");
        Console.WriteLine("   X X   ");
        Console.WriteLine("  X   X  ");
        Console.WriteLine(" X  x  X ");
        Console.WriteLine("X       X");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static private void PressKeyB_Handler()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("XXXXX  ");
        Console.WriteLine("X    X ");
        Console.WriteLine("XXXXXX ");
        Console.WriteLine("X     X");
        Console.WriteLine("XXXXXX ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}