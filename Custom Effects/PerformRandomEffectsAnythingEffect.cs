using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class PerformRandomEffectsAnythingEffect : EffectSO
    {
        public bool randomBetweenPrevious = false;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            int num = entryVariable;
            if (randomBetweenPrevious)
            {
                num = UnityEngine.Random.Range(PreviousExitValue, num);
            }
            exitAmount = entryVariable;

            CombatManager.Instance.AddSubAction(new EffectAction(GetRandomCharacterEffects(entryVariable), caster));

            return true;
        }
        public EffectInfo[] GetRandomCharacterEffects(int amount)
        {
            List<string> charAbilities = LoadedDBsHandler.AbilityDB._characterAbilityPool;
            List<string> enemAbilities = LoadedDBsHandler.AbilityDB._enemyAbilityPool;
            List<EffectInfo> effects = [];
            for (int i = 0; i < charAbilities.Count; i++)
            {
                for (int j = 0; j < LoadedAssetsHandler.GetCharacterAbility(charAbilities[i]).effects.Length; j++)
                {
                    effects.Add(LoadedAssetsHandler.GetCharacterAbility(charAbilities[i]).effects[j]);
                }
            }
            for (int i = 0; i < enemAbilities.Count; i++)
            {
                for (int j = 0; j < LoadedAssetsHandler.GetEnemyAbility(enemAbilities[i]).effects.Length; j++)
                {
                    effects.Add(LoadedAssetsHandler.GetEnemyAbility(enemAbilities[i]).effects[j]);
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
