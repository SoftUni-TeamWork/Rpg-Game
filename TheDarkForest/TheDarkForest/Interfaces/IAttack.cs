namespace TheDarkForest.Resources.Interfaces
{
    using TheDarkForest.Resources.Classes;
    using TheDarkForest.Resources.Enumerations;

    public interface IAttack
    {
        void Attack(Character gameObject, AttackType attackType);
    }
}
