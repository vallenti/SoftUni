namespace Empires.Contracts
{
    /// <summary>
    /// Defines a method that a class implents in order to be able to start a process. (e.g. Game Engine)
    /// </summary>
    public interface IRunnable
    {
        /// <summary>
        /// Starts a process
        /// </summary>
        void Run();
    }
}
