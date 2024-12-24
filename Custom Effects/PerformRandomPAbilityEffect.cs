using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class PerformRandomPAbilityEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;

            foreach (AbilitySO randomCharacterAbility in GetRandomCharacterPAbilities(entryVariable))
            {
                if (caster.TryPerformRandomAbility(randomCharacterAbility))
                {
                    exitAmount++;
                }
            }

            return exitAmount > 0;
        }
        public List<AbilitySO> GetRandomCharacterPAbilities(int amount)
        {
            List<string> abilities = LoadedDBsHandler.AbilityDB._characterAbilityPool;
            List<AbilitySO> abilityL = [];
            for (int i = 0; i < abilities.Count; i++)
            {
                if (LoadedAssetsHandler.GetCharacterAbility(abilities[i])._abilityName.ToLowerInvariant().Contains("p"))
                {
                    abilityL.Add(LoadedAssetsHandler.GetCharacterAbility(abilities[i]));
                }
            }
            List<AbilitySO> performL = [];
            while (amount > 0 && abilityL.Count > 0)
            {
                int index = UnityEngine.Random.Range(0, abilityL.Count);
                AbilitySO abilityName = abilityL[index];
                abilityL.RemoveAt(index);
                if (!(abilityName == null) && !abilityName.Equals(null))
                {
                    performL.Add(abilityName);
                    amount--;
                }
            }
            return performL;
        }
    }
}
