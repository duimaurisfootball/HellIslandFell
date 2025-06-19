using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class WakingScream
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS shadowy = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            shadowy._extraPassiveAbility = Passives.GetCustomPassive("Mirage_PA");

            DamageReceivedPercentageModifierEffect_Item wakingScream = new DamageReceivedPercentageModifierEffect_Item("WakingScream_ID", null)
            {
                Item_ID = "WakingScream_TW",
                Name = "Waking Scream",
                Flavour = "\"You're not in control anymore.\"",
                Description = "Give this party member Mirage as a passive. Decrease all incoming damage by 40%.",
                IsShopItem = false,
                ShopPrice = 4,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("TreasureWakingScream"),
                EffectsTrigger = TriggerCalls.Count,
                Effects =
                [
                ],
                TriggerOn = TriggerCalls.OnBeingDamaged,
                DirectDmgPercentageToModify = 40,
                DoesIncreaseDirectDamage = false,
                IndirectDmgPercentageToModify = 40,
                DoesIncreaseIndirectDamage = false,
                EquippedModifiers =
                [
                    shadowy,
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(wakingScream.Item, new ItemModdedUnlockInfo(wakingScream.Item_ID, ResourceLoader.LoadSprite("TreasureWakingScream")));
        }
    }
}
