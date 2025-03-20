using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class UnboundedExtraLootEffect : EffectSO
    {
        public int _cycles = 1;

        public int _repeatChance = 50;

        public bool _isTreasure;

        public bool _getLocked;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            int ball = entryVariable;
            for (int i = 0; i < _cycles; i++)
            {
                ball += (int)Math.Ceiling(Math.Log(UnityEngine.Random.value) / Math.Log(_repeatChance / 100.0));
            }
            exitAmount = ball;
            if (_isTreasure)
            {
                stats.AddTreasureLoot(ball, _getLocked);
            }
            else
            {
                stats.AddShopItemLoot(ball, _getLocked);
            }
            return exitAmount > _cycles;
        }
    }
}
