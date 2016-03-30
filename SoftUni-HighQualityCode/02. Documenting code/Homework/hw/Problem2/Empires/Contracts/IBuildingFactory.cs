namespace Empires.Contracts
{
    /// <summary>
    /// Defines a method that a class implents in order to produce instances of IBuilding
    /// </summary>
    /// <see cref="IBuilding"/>
    public interface IBuildingFactory
    {
        /// <summary>
        /// Creates intance of object IBuilding
        /// </summary>
        /// <param name="buildingType">type of building</param>
        /// <param name="unitFactory"></param>
        /// <param name="resourceFactory"></param>
        /// <see cref="IBuilding"/>
        /// <returns>new instance of IBuilding</returns>
        IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory);
    }
}
