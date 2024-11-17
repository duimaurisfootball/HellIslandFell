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
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = entryVariable;
            IEnumerable<string> items = LoadShopItemIds(_cost, _costsLess);
            for (int i = 0; i < entryVariable; i++)
            {
                stats.AddExtraLootAddition(items.ElementAt(UnityEngine.Random.Range(0, items.Count())));
            }

            return exitAmount > 0;
        }

        private static IEnumerable<string> LoadShopItemIds(int cost, bool costsLess)
        {
            var processed = new List<string>();
            var unlocks = LoadedDBsHandler.ItemUnlocksDB;

            foreach (var i in unlocks.ShopItems)
            {
                if (!processed.Contains(i.itemName.ToLowerInvariant()))
                {
                    if (i.LoadedItem.shopPrice < cost && costsLess)
                    {
                        processed.Add(i.itemName.ToLowerInvariant());
                    }
                    if (i.LoadedItem.shopPrice > cost && !costsLess)
                    {
                        processed.Add(i.itemName.ToLowerInvariant());
                    }

                    yield return i.itemName;
                }
            }
        }
    }
}
