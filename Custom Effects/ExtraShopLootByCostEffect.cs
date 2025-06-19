using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ExtraShopLootByCostEffect : EffectSO
    {
        public int _cost = 0;
        public bool _costsLess = true;
        public bool _getLocked = true;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = entryVariable;
            IEnumerable<string> items = LoadShopItemIds(_cost, _costsLess, _getLocked);
            for (int i = 0; i < entryVariable; i++)
            {
                stats.AddExtraLootAddition(items.ElementAt(UnityEngine.Random.Range(0, items.Count())));
            }

            return exitAmount > 0;
        }

        private static IEnumerable<string> LoadShopItemIds(int cost, bool costsLess, bool getLocked)
        {
            List<string> processed = [];

            foreach (var kvp in LoadedAssetsHandler.LoadedWearables)
            {
                if (kvp.Value != null && !processed.Contains(kvp.Key.ToLowerInvariant()) && kvp.Value.shopPrice != cost && ((kvp.Value.shopPrice < cost) == costsLess) && kvp.Value.isShopItem)
                {
                    processed.Add(kvp.Key.ToLowerInvariant());

                    yield return kvp.Key;
                }
            }
        }
    }
}
