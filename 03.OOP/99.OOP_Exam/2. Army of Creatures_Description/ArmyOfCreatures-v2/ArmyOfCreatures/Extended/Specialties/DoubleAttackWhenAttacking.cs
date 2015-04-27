namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    class DoubleAttackWhenAttacking : Specialty
    {
        private int rounds;

        public DoubleAttackWhenAttacking(int rounds)
        {
            if (rounds < 1)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0.");
            }

            this.rounds = rounds;
        }

        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }

            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return currentDamage;
            }
            this.rounds--;

            return currentDamage * 2;
        }

        public override string ToString()
        {
            return String.Format("DoubleAttackWhenAttacking({0})", this.rounds);
        }
    }
}
