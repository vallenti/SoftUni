namespace Empires.Contracts
{
    /// <summary>
    /// Defines a property that a class implements to make a unit able to be destroyed
    /// </summary>
    public interface IDestroyable
    {
        int Health { get; set; }
    }
}
