﻿namespace ArmyOfCreatures.Extended
{
    using System.Globalization;
    using System.Linq;
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;
    using System.Collections.Generic;
    using System;

    class BattleManagerExtended : BattleManager, IBattleManager
    {
        private readonly ICollection<ICreaturesInBattle> firstArmyCreatures;
        private readonly ICollection<ICreaturesInBattle> secondArmyCreatures;
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

        public BattleManagerExtended(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.firstArmyCreatures = new List<ICreaturesInBattle>();
            this.secondArmyCreatures = new List<ICreaturesInBattle>();
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 1)
            {
                this.firstArmyCreatures.Add(creaturesInBattle);
            }

            else if (creatureIdentifier.ArmyNumber == 2)
            {
                this.secondArmyCreatures.Add(creaturesInBattle);
            }
            else if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmyCreatures.Add(creaturesInBattle);
            }

            base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            if (identifier.ArmyNumber == 1)
            {
                return this.firstArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            if (identifier.ArmyNumber == 2)
            {
                return this.secondArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            if (identifier.ArmyNumber == 3)
            {
                return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }
            return base.GetByIdentifier(identifier);
        }
    }
}
