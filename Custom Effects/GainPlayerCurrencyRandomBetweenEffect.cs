using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class GainPlayerCurrencyRandomBetweenEffect : EffectSO
    {
        public bool _gainForPlayer = true;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = stats.TryGainCurrency(UnityEngine.Random.Range(entryVariable, PreviousExitValue), _gainForPlayer);
            if (exitAmount > 0)
            {
                CombatManager.Instance.AddUIAction(new PlayCurrencyEffectUIAction(caster.ID, caster.IsUnitCharacter, exitAmount, isMultiplier: false));
            }

            return exitAmount > 0;
        }
    }
}
