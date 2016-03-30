namespace Empires.Contracts
{
    using Enums;

    /// <summary>
    /// Defines properties that a class implents in order to be a Resource
    /// </summary>
    /// <seealso cref="Enums.ResourceType"/>
    public interface IResource
    {
        ResourceType ResourceType { get; }

        int Quantity { get; }
    }
}
