namespace Empires.Contracts
{
    /// <summary>
    /// Defines a property that a class implements to make a unit able to attack
    /// </summary>
    public interface IAttacker
    {
        /// <summary>
        /// Damage that implemented class will be able to make
        /// </summary>
        int AttackDamage { get; }
    }
}
