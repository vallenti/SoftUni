namespace Empires.Contracts
{
    using Models.EventHandlers;

    /// <summary>
    /// Defines an event that a class implents in order to notify its listeners that a resource is produced
    /// </summary>
    public interface IResourceProducer
    {
        /// <summary>
        /// Notify event listeners that unit is produced
        /// </summary>
        event ResourceProducedEventHandler OnResourceProduced;
    }
}
