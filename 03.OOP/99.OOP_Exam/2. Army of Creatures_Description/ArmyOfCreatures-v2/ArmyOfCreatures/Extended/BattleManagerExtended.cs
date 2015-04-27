namespace ArmyOfCreatures.Extended
{
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;
    using System.Collections.Generic;

    class BattleManagerExtended : BattleManager, IBattleManager
    {
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

        public BattleManagerExtended(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
        }
    }
}
