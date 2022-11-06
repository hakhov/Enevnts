/*Ընդունված է, որ իրադարձություն մշակողները պետք է վերադարձնեն void և ընդունեն երկու պարամետր։
Առաջին պարամետրը հղում է իրադարձության օբյեկտին, երկրոդը պարամետր է, որը հանդիսանում է 
EventArgs կլասի անդամ կամ նրա ժառանգը, որը նախատեսված է մշակողի համար։
public static readonly EventArgs Empty;
public EventArgs();

Սա էլ պատրաստի delegate որը կիրականացնի աս ամենը
public delegate void EventHandler(object? sender, EventArgs e);
*/

public delegate void Notify();  // delegate

public class SomeProcess
{
    public event Notify? ProcessCompleted; // event

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // some code here..
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted() //protected virtual method
    {
        //if ProcessCompleted is not null then call delegate

        if (ProcessCompleted is not null)
            ProcessCompleted?.Invoke();
    }
}

