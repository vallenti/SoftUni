namespace Empires.Contracts
{
    /// <summary>
    /// Defines a method that a class implents in order to produce instances of IUnit
    /// </summary>
    /// <see cref="IUnit"/>
    public interface IUnitFactory
    {
        /// <summary>
        /// Creates a new instance of IUnit
        /// </summary>
        /// <param name="unitType">type of the unit needed to be created</param>
        /// <returns>new instance of IUnit</returns>
        /// <seealso cref="IUnit"/>
        IUnit CreateUnit(string unitType);
    }
}
