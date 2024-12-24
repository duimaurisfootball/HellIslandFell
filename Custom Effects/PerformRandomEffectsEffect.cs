using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class PerformRandomEffectsEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = entryVariable;

            CombatManager.Instance.AddSubAction(new EffectAction(GetRandomCharacterEffects(entryVariable), caster));

            return true;
        }
        public EffectInfo[] GetRandomCharacterEffects(int amount)
        {
            List<string> abilities = LoadedDBsHandler.AbilityDB._characterAbilityPool;
            List<EffectInfo> effects = [];
            for (int i = 0; i < abilities.Count; i++)
            {
                for (int j = 0; j < LoadedAssetsHandler.GetCharacterAbility(abilities[i]).effects.Length; j++)
                {
                    effects.Add(LoadedAssetsHandler.GetCharacterAbility(abilities[i]).effects[j]);
                }
            }
            EffectInfo[] outEffects = new EffectInfo[amount];
            int idx = 0;
            while (amount > 0 && effects.Count > 0)
            {
                int index = UnityEngine.Random.Range(0, effects.Count);
                EffectInfo effectInfo = effects[index];
                effects.RemoveAt(index);
                if (!(effectInfo == null) && !effectInfo.Equals(null))
                {
                    outEffects[idx] = effectInfo;
                    idx++;
                    amount--;
                }
            }
            return outEffects;
        }
    }

}
