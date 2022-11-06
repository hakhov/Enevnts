public class SomeProcess
{
    // declaring an event using built-in EventHandler
    public event EventHandler? ProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        // some code here..
        OnProcessCompleted(EventArgs.Empty); //No event data
    }

    protected virtual void OnProcessCompleted(EventArgs? e)
    {
        if (e is not null)
            ProcessCompleted?.Invoke(this, e);
    }
}

