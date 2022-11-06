
public class Keyboard
{
    public event PressKeyEventHandler? PressKeyA = null;
    public event PressKeyEventHandler? PressKeyB = null;
    //  C ... Z

    public void PressKeyAEvent()
    {
        if (PressKeyA is not null)
        {
            PressKeyA.Invoke(); //կոնկրետ սրա համար
        }
    }

    public void PressKeyBEvent()
    {
        if (PressKeyB is not null)
        {
            PressKeyB.Invoke();
        }
    }

    public void Start()
    {
        while (true)
        {
            string? s = Console.ReadLine();

            switch (s?.ToUpper())
            {
                case "A":
                    PressKeyAEvent();
                    break;
                case "B":
                    PressKeyBEvent();
                    break;
                case "EXIT":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("This symbol not correct {0}", s?.ToUpper());
                    break;
            }
        }
    }
}

