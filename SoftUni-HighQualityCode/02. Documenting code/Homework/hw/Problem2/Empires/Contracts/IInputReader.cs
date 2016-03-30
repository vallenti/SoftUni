namespace Empires.Contracts
{
    /// <summary>
    /// Defines a method that a class implements to be able to read commands
    /// </summary>
    public interface IInputReader
    {
        /// <summary>
        /// Reads command and return it as string
        /// </summary>
        /// <returns>command and its parameters</returns>
        string ReadLine();
    }
}
