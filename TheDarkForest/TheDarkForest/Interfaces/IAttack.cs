namespace TheDarkForest.Interfaces
{
    using TheDarkForest.Classes;
    using TheDarkForest.Enumerations;

    public interface IAttack
    {
        void Attack(Character gameObject, AttackType attackType);
    }
}
