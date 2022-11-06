
SomeProcess obj = new SomeProcess();
obj.ProcessCompleted += ProcessCompletedHandlerMethod; // register with an event
obj.StartProcess();

static void ProcessCompletedHandlerMethod(object? sender, EventArgs? e)
{
    Console.WriteLine("Process Completed!");
}
