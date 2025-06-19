using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class TradeHealthColorsEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            ManaColorSO swapColor = Pigments.Grey;

            if (caster.ContainsPassiveAbility(Passives.Pure.m_PassiveID))
            {
                CombatManager.Instance.AddUIAction(new ShowPassiveInformationUIAction(caster.ID, caster.IsUnitCharacter, "Pure", Passives.Pure.passiveIcon));
                return false;
            }

            foreach (TargetSlotInfo target in targets)
            {
                if (target.HasUnit && caster.HealthColor != target.Unit.HealthColor)
                {
                    swapColor = target.Unit.HealthColor;
                    if (target.Unit.ChangeHealthColor(caster.HealthColor))
                    {
                        exitAmount++;
                    }
                }
            }

            if (exitAmount > 0)
            {
                caster.ChangeHealthColor(swapColor);
            }

            return exitAmount > 0;
        }
    }
}
