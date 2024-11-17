using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class Element83
    {
        public static void Add()
        {
            CopyCasterAndSpawnCharacterAnywhereEffect Clone = ScriptableObject.CreateInstance<CopyCasterAndSpawnCharacterAnywhereEffect>();
            Clone._permanentSpawn = true;
            Clone._rankIsAdditive = true;
            Clone._rank = 0;
            Clone._canGetDeadCharacter = true;
            Clone._maximizeHealth = true;
            Clone._extraModifiers = [];

            PercentageEffectCondition DestructionChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            DestructionChance.percentage = 83;

            PerformEffect_Item element83 = new PerformEffect_Item("Element83_ID", null, false)
            {
                Item_ID = "Element83_TW",
                Name = "Element 83",
                Flavour = "\"Thousands of islets, like a continent shattered across the sea...\"",
                Description = "Summon a permanent clone of this party member on combat end. 83% chance to be consumed upon use.",
                IsShopItem = false,
                ShopPrice = 83,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanSalad"),
                TriggerOn = TriggerCalls.OnCombatEnd,
                Effects =
                [
                    Effects.GenerateEffect(Clone, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Slot_SelfSlot, DestructionChance),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(element83.Item, new ItemModdedUnlockInfo("Element83_TW", ResourceLoader.LoadSprite("UnlockOsmanSaladLocked", null, 32, null), "HIF_Salad_Witness_ACH"));
        }
    }
}
