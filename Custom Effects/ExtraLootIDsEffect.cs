using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ExtraLootIDsEffect : EffectSO
    {
        public bool _getLocked;

        public string _itemID;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = entryVariable;
            IEnumerable<string> itemsByID = LoadItemIdsById(_itemID, _getLocked);
            for (int i = 0; i < entryVariable; i++)
            {
                stats.AddExtraLootAddition(itemsByID.ElementAt(UnityEngine.Random.Range(0, itemsByID.Count())));
            }

            return exitAmount > 0;
        }
        private static IEnumerable<string> LoadItemIdsById(string itemID, bool getLocked)
        {
            var processed = new List<string>();
            var unlocks = LoadedDBsHandler.ItemUnlocksDB;

            foreach (var i in unlocks.ShopItems)
            {
                BaseWearableSO item = LoadedAssetsHandler.GetWearable(i.itemName);
                if (!processed.Contains(i.itemName.ToLowerInvariant()) && item._ItemTypeIDs != null && item.IsItemType(itemID) && (i.IsItemUnlocked || getLocked))
                {
                    processed.Add(i.itemName.ToLowerInvariant());

                    yield return i.itemName;
                }
            }

            foreach (var i in unlocks.TreasureItems)
            {
                BaseWearableSO item = LoadedAssetsHandler.GetWearable(i.itemName);
                if (!processed.Contains(i.itemName.ToLowerInvariant()) && item._ItemTypeIDs != null && item.IsItemType(itemID) && (i.IsItemUnlocked || getLocked))
                {
                    processed.Add(i.itemName.ToLowerInvariant());

                    yield return i.itemName;
                }
            }

            foreach (var i in unlocks.ExtraItems)
            {
                BaseWearableSO item = LoadedAssetsHandler.GetWearable(i.itemName);
                if (!processed.Contains(i.itemName.ToLowerInvariant()) && item._ItemTypeIDs != null && item.IsItemType(itemID) && (i.IsItemUnlocked || getLocked))
                {
                    processed.Add(i.itemName.ToLowerInvariant());

                    yield return i.itemName;
                }
            }

            foreach (var kvp in LoadedAssetsHandler.LoadedWearables)
            {
                if (kvp.Value != null && !processed.Contains(kvp.Key.ToLowerInvariant()) && kvp.Value._ItemTypeIDs != null && kvp.Value.IsItemType(itemID))
                {
                    processed.Add(kvp.Key.ToLowerInvariant());

                    yield return kvp.Key;
                }
            }
        }
    }
}
