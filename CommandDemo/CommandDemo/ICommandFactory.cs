namespace CommandDemo
{
    public interface ICommandFactory
    {
        PlusCommand CreatePlusCommand();
        GetResultCommand CreateGetResultCommand();
    }
}