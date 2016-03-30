namespace Empires.Contracts
{
    using Enums;

    /// <summary>
    /// Defines a method that a class implents in order to produce instances of IResource
    /// </summary>
    /// <see cref="IResource"/>
    public interface IResourceFactory
    {
        /// <summary>
        /// Creates a new instance of IResource
        /// </summary>
        /// <param name="resourceType">Type of resource needs to be produced</param>
        /// <param name="quantity">Quantity needed to be produced</param>
        /// <seealso cref="IResource"/>
        /// <seealso cref="ResourceType"/>
        /// <returns></returns>
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}
