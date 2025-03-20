using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class SymbolOfPeace
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS EnfeebledAdd = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            EnfeebledAdd._extraPassiveAbility = Passives.Enfeebled;

            CopyAndSpawnCustomCharacterAnywhereEffect HolesSpawn = ScriptableObject.CreateInstance<CopyAndSpawnCustomCharacterAnywhereEffect>();
            HolesSpawn._rank = 0;
            HolesSpawn._permanentSpawn = false;
            HolesSpawn._usePreviousAsHealth = false;
            HolesSpawn._characterCopy = "VandanderHoles_CH";
            HolesSpawn._extraModifiers = [];
            HolesSpawn._nameAddition = 0;

            PerformEffect_Item symbolOfPeace = new PerformEffect_Item("SymbolOfPeace_ID", null, false)
            {
                Item_ID = "SymbolOfPeace_TW",
                Name = "Symbol Of Peace",
                Flavour = "\"Tiny, Shining holes in the sky. And we shall become them.\"",
                Description = "This party member now has Enfeebled as a passive. Summon Vandander's other bits on combat start.",
                IsShopItem = false,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = true,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanVandander"),
                Effects =
                [
                    Effects.GenerateEffect(HolesSpawn, 4, Targeting.Slot_SelfSlot),
                ],
                EquippedModifiers =
                [
                    EnfeebledAdd,
                ],
            };
            
            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(symbolOfPeace.Item, new ItemModdedUnlockInfo("SymbolOfPeace_TW", ResourceLoader.LoadSprite("UnlockOsmanVandanderLocked", null, 32, null), "HIF_Vandander_Witness_ACH"));
        }
    }
}
