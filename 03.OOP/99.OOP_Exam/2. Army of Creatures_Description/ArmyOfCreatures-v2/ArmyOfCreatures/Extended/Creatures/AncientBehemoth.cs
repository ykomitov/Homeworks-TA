namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    class AncientBehemoth : Creature
    {
        //int attack, int defense, int healthPoints, decimal damage
        public AncientBehemoth()
            : base(19, 19, 300, 40)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}
