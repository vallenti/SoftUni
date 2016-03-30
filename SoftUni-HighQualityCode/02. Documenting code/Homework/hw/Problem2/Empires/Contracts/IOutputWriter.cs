namespace Empires.Contracts
{
    /// <summary>
    /// Defines a method that a class implements to be able to print/render game info
    /// </summary>
    public interface IOutputWriter
    {
        /// <summary>
        /// Print a message given as parameter
        /// </summary>
        /// <param name="message">Message to be printed</param>
        void Print(string message);
    }
}
