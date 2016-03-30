namespace Empires.Contracts
{
    using Models.EventHandlers;

    /// <summary>
    /// Defines an event that a class implents in order to notify its listeners that unit is produced
    /// </summary>
    public interface IUnitProducer
    {
        /// <summary>
        /// Notify event listeners that unit is produced
        /// </summary>
        event UnitProducedEventHandler OnUnitProduced;
    }
}
