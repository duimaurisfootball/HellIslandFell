﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class AddCostEffect : EffectSO
    {
        public bool AddOverSix = true;

        public bool IgnoreSlap = true;

        public ManaColorSO _color;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;

            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit is CharacterCombat cc)
                {
                    foreach (var ab in cc.CombatAbilities)
                    {
                        if ((ab.cost.Length < 6 || AddOverSix) && !(IgnoreSlap && ab.ability._abilityName == "Slap"))
                        {
                            var origLength = ab.cost.Length;
                            var origCost = ab.cost;
                            ab.cost = new ManaColorSO[origLength + entryVariable];
                            for (int i = 0; i < origLength + entryVariable; i++)
                            {
                                ab.cost[i] = _color;
                                if (i < origLength)
                                {
                                    ab.cost[i] = origCost[i];
                                }
                            }
                        }
                    }
                    foreach (CharacterCombatUIInfo characterCombatUIInfo in stats.combatUI._charactersInCombat.Values)
                    {
                        bool flag = characterCombatUIInfo.SlotID == targetSlotInfo.Unit.SlotID;
                        if (flag)
                        {
                            characterCombatUIInfo.UpdateAttacks([.. (targetSlotInfo.Unit as CharacterCombat).CombatAbilities]);
                            break;
                        }
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
