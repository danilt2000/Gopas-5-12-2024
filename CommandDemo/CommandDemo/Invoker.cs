using CommandDemo;

internal class Invoker
{
    
    internal void Execute(ICommand command)
    {
        // command preprocessing - telemetrie, polit
        command.Execute();
        // command postprocessing - log success, log error, notify admin...
    }
}