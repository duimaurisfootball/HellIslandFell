using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Heartworm
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS wormy = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            wormy._extraPassiveAbility = Passives.ParasiteParasitism;

            CasterStoreValueSetterReturnEffect WormRemoval = ScriptableObject.CreateInstance<CasterStoreValueSetterReturnEffect>();
            WormRemoval.m_unitStoredDataID = UnitStoredValueNames_GameIDs.ParasiteCurrentHealthPA.ToString();

            DamageEffect PrevDamage = ScriptableObject.CreateInstance<DamageEffect>();
            PrevDamage._usePreviousExitValue = true;

            Ability pumpingThump = new Ability("Pumping Thump", "Pumping Thump_A")
            {
                Description = "Reduce this party member's Parasitism to 1.\nDeal 2 damage to the Left and Right enemies for every point of Parasitism removed.",
                AbilitySprite = ResourceLoader.LoadSprite("ItemPumpingThump"),
                Cost = [Pigments.Red],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Leech,
                Effects =
                    [
                        Effects.GenerateEffect(WormRemoval, 1, Targeting.Slot_SelfSlot),
                        Effects.GenerateEffect(PrevDamage, 2, Targeting.Slot_OpponentSides),
                    ]
            };
            pumpingThump.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            pumpingThump.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_3_6)]);

            ExtraAbility_Wearable_SMS wormObliterator = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            wormObliterator._extraAbility = pumpingThump.GenerateCharacterAbility();

            PerformEffect_Item heartworm = new PerformEffect_Item("Heartworm_ID", null, false)
            {
                Item_ID = "Heartworm_TW",
                Name = "Heartworm",
                Flavour = "\"Bump.\"",
                Description = "Give this party member Parasitism as a passive. Adds \"Pumping Thump\" as an additional ability, an attack based around worm removal.",
                IsShopItem = false,
                ShopPrice = 4,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanEras"),
                TriggerOn = TriggerCalls.Count,
                Effects =
                [
                ],
                EquippedModifiers =
                [
                    wormy,
                    wormObliterator,
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(heartworm.Item, new ItemModdedUnlockInfo("Heartworm_TW", ResourceLoader.LoadSprite("UnlockOsmanErasLocked", null, 32, null), "HIF_Eras_Witness_ACH"));
        }
    }
}
