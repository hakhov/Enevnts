/*Ընդունված է, որ իրադարձություն մշակողները պետք է վերադարձնեն void և ընդունեն երկու պարամետր։
Առաջին պարամետրը հղում է իրադարձության օբյեկտին, երկրոդը պարամետր է, որը հանդիսանում է 
EventArgs կլասի անդամ կամ նրա ժառանգը, որը նախատեսված է մշակողի համար։
public static readonly EventArgs Empty;
public EventArgs();

Սա էլ պատրաստի delegate որը կիրականացնի աս ամենը
public delegate void EventHandler(object? sender, EventArgs e);
*/

 
    SomeProcess obj = new SomeProcess();
    obj.ProcessCompleted += ProcessCompletedHandleMethod; // register with an event
    obj.StartProcess();
 

// event handler
 static void ProcessCompletedHandleMethod()
{
    Console.WriteLine("Process Completed!");
}


