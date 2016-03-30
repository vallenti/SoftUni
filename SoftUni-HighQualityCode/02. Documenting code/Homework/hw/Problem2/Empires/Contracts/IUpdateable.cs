namespace Empires.Contracts
{
    /// <summary>
    /// Defines a method that a class implents so it can be updated on every iteration of the game
    /// </summary>
    public interface IUpdateable
    {
        /// <summary>
        /// Method that will be called on every iteration of the game loop.
        /// Any object changing logic should be here
        /// </summary>
        void Update();
    }
}
