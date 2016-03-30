namespace ConsoleApplication1.Core
{
    public interface ICommand
    {
        string Action { get; }
        string[] Parameters { get; }
    }
}