namespace Empires.Contracts
{
    using System.Collections.Generic;

    using Enums;

    /// <summary>
    /// Defines methods and properties that holds and maintain game data
    /// </summary>
    /// <see cref="IBuilding"/>
    /// <see cref="IUnit"/>
    /// <see cref="ResourceType"/>
    /// <seealso cref="System.Collections.Generic.IDictionary"/>
    public interface IEmpiresData
    {
        /// <summary>
        /// Collection of all the buildings that are in the game
        /// </summary>
        /// <seealso cref="IBuilding"/>
        IEnumerable<IBuilding> Buildings { get; }

        /// <summary>
        /// Add building to the collection of buildings
        /// </summary>
        /// <param name="building"></param>
        /// <seealso cref="IBuilding"/>
        void AddBuilding(IBuilding building);

        /// <summary>
        /// Collection of all units in the game
        /// </summary>
        IDictionary<string, int> Units { get; }

        /// <summary>
        /// Add unit ot the collection of units
        /// </summary>
        /// <param name="unit"></param>
        /// <<seealso cref="IUnit"/>
        void AddUnit(IUnit unit);

        /// <summary>
        /// Collection of all the resources in the game
        /// </summary>
        /// <seealso cref="ResourceType"/>
        IDictionary<ResourceType, int> Resources { get; } 
    }
}
