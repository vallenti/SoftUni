namespace Empires.Contracts
{
    /// <summary>
    /// Combines properties and methods of IUnitProducer, IResourceProducer and IUpdatable
    /// </summary>
    /// <seealso cref="IUnitProducer"/>
    /// <seealso cref="IResourceProducer"/>
    /// <seealso cref="IUpdateable"/>
    public interface IBuilding : IUnitProducer, IResourceProducer, IUpdateable
    {
    }
}
