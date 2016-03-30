namespace Empires.Contracts
{
    /// <summary>
    /// Combines properties and methods of IAttacker and IDestroyable interfaces.
    /// </summary>
    /// <seealso cref="IAttacker"/>
    /// <seealso cref="IDestroyable"/>
    public interface IUnit : IAttacker, IDestroyable
    {
    }
}
