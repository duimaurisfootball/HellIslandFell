using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RerollOneCostInOneAbilityToSpecificColorEffect : EffectSO
    {
        public ManaColorSO _color;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;

            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit is CharacterCombat cc)
                {
                    CombatAbility ab = cc.CombatAbilities[UnityEngine.Random.Range(0, cc.CombatAbilities.Count - 1)];
                    ab.cost[UnityEngine.Random.Range(0, ab.cost.Length - 1)] = _color;
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
