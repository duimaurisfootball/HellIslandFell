using BrutalAPI;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class HoftstoldtHealEffect : EffectSO
    {
        public bool usePreviousExitValue;

        public bool entryAsPercentage;

        public bool _directHeal = true;

        public bool _onlyIfHasHealthOver0;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            if (usePreviousExitValue)
            {
                entryVariable *= PreviousExitValue;
            }

            TargetSlotInfo[] allies = Targeting.GenerateSlotTarget([-4, -3, -2, -1, 0, 1, 2, 3, 4], true).GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);


            exitAmount = 0;
            for (int i = 0; i < allies.Length; i++)
            {
                if (allies[i].HasUnit && (!_onlyIfHasHealthOver0 || allies[i].Unit.CurrentHealth > 0))
                {
                    int num = entryVariable;
                    if (i - 1 >= 0)
                    {
                        if (allies[i - 1].HasUnit && allies[i - 1].Unit.ContainsPassiveAbility(Passives.Construct.m_PassiveID))
                        {
                            if (entryAsPercentage)
                            {
                                num = allies[i].Unit.CalculatePercentualAmount(num);
                            }
                            if (_directHeal)
                            {
                                num = caster.WillApplyHeal(num, allies[i].Unit);
                            }

                            exitAmount += allies[i].Unit.Heal(num, caster, _directHeal);
                        }
                    }
                    num = entryVariable;
                    if (i + 1 < allies.Length)
                    {
                        if (allies[i + 1].HasUnit && allies[i + 1].Unit.ContainsPassiveAbility(Passives.Construct.m_PassiveID))
                        {
                            if (entryAsPercentage)
                            {
                                num = allies[i].Unit.CalculatePercentualAmount(num);
                            }
                            if (_directHeal)
                            {
                                num = caster.WillApplyHeal(num, allies[i].Unit);
                            }

                            exitAmount += allies[i].Unit.Heal(num, caster, _directHeal);
                        }
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
