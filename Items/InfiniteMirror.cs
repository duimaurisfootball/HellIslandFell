using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class InfiniteMirror
    {
        public static void Add()
        {
            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;

            PercentageEffectCondition repeatChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            repeatChance.percentage = 50;

            PerformEffect_Item infiniteMirror = new PerformEffect_Item("InfiniteMirror_ID", null)
            {
                Item_ID = "InfiniteMirror_TW",
                Name = "Infinite Mirror",
                Flavour = "\"Tree falling no one would hear...\"",
                Description = "Perform a random party member ability upon taking damage. 50% chance to deal 1 indirect damage to this party member upon being damaged.",
                IsShopItem = false,
                ShopPrice = 3,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenHills"),
                TriggerOn = TriggerCalls.OnDamaged,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<PerformRandomAbilityFromCharacterEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(IndirectDamage, 1, Targeting.Slot_SelfSlot, repeatChance),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(infiniteMirror.Item, new ItemModdedUnlockInfo("InfiniteMirror_TW", ResourceLoader.LoadSprite("UnlockHeavenHillsLocked", null, 32, null), "HIF_Hills_Divine_ACH"));
        }
    }
}
