using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ChaosLootReplaceEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = entryVariable;

            for (int i = 0; i < entryVariable; i++)
            {
                stats.AddOWItemChange(LoadItemIds().ElementAt(UnityEngine.Random.Range(0, LoadItemIds().Count())));
            }

            return exitAmount > 0;
        }

        private static IEnumerable<string> LoadItemIds()
        {
            var processed = new List<string>();
            var unlocks = LoadedDBsHandler.ItemUnlocksDB;

            foreach (var i in unlocks.ShopItems)
            {
                if (!processed.Contains(i.itemName.ToLowerInvariant()))
                {
                    processed.Add(i.itemName.ToLowerInvariant());

                    yield return i.itemName;
                }
            }

            foreach (var i in unlocks.TreasureItems)
            {
                if (!processed.Contains(i.itemName.ToLowerInvariant()))
                {
                    processed.Add(i.itemName.ToLowerInvariant());

                    yield return i.itemName;
                }
            }

            foreach (var i in unlocks.ExtraItems)
            {
                if (!processed.Contains(i.itemName.ToLowerInvariant()))
                {
                    processed.Add(i.itemName.ToLowerInvariant());

                    yield return i.itemName;
                }
            }

            foreach (var kvp in LoadedAssetsHandler.LoadedWearables)
            {
                if (kvp.Value != null && !processed.Contains(kvp.Key.ToLowerInvariant()))
                {
                    processed.Add(kvp.Key.ToLowerInvariant());

                    yield return kvp.Key;
                }
            }
        }
    }
}
