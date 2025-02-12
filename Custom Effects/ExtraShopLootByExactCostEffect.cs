using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ExtraShopLootByExactCostEffect : EffectSO
    {
        public int _cost = 0;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = entryVariable;
            IEnumerable<string> items = LoadShopItemIds(_cost);
            if (items.Count() != 0)
            {
            for (int i = 0; i < entryVariable; i++)
            {
                stats.AddExtraLootAddition(items.ElementAt(UnityEngine.Random.Range(0, items.Count())));
            }
            }

            return exitAmount > 0;
        }

        private static IEnumerable<string> LoadShopItemIds(int cost)
        {
            var processed = new List<string>();

            foreach (var kvp in LoadedAssetsHandler.LoadedWearables)
            {
                if (kvp.Value != null && !processed.Contains(kvp.Key.ToLowerInvariant()) && kvp.Value.isShopItem && kvp.Value.shopPrice == cost)
                {
                    processed.Add(kvp.Key.ToLowerInvariant());

                    yield return kvp.Key;
                }
            }
        }
    }
}
