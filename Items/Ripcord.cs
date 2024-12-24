using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Ripcord
    {
        public static void Add()
        {
            Ability spinDial = new Ability("Spin Dial", "SpinDial_A")
            {
                Description = "Perform 17 random effects from party member's abilities.",
                AbilitySprite = ResourceLoader.LoadSprite("ItemSpinDial"),
                Cost = [Pigments.Yellow, Pigments.Blue, Pigments.Red],
                Effects =
                    [
                        Effects.GenerateEffect(ScriptableObject.CreateInstance<PerformRandomEffectsEffect>(), 17, Targeting.Slot_SelfSlot),
                    ]
            };
            spinDial.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            ExtraAbility_Wearable_SMS cogsTurner = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            cogsTurner._extraAbility = spinDial.GenerateCharacterAbility();

            PerformEffect_Item ripcord = new PerformEffect_Item("Ripcord_ID", null, false)
            {
                Item_ID = "Ripcord_SW",
                Name = "Ripcord",
                Flavour = "\"Teeth on a line designed to make cogs spin.\"",
                Description = "Adds \"Spin Dial\" as an additional ability, a chaotic blend of effects.",
                IsShopItem = true,
                ShopPrice = 9,
                DoesPopUpInfo = false,
                StartsLocked = true,
                TriggerOn = TriggerCalls.Count,
                EquippedModifiers =
                [
                    cogsTurner,
                ],
                Icon = ResourceLoader.LoadSprite("UnlockHeavenHoftstoldt")
            };
            Connection_PerformEffectPassiveAbility connection_PerformEffectPassiveAbility = LoadedAssetsHandler.GetCharacter("Doll_CH").passiveAbilities[0] as Connection_PerformEffectPassiveAbility;
            CasterAddRandomExtraAbilityEffect casterAddRandomExtraAbilityEffect = connection_PerformEffectPassiveAbility.connectionEffects[1].effect as CasterAddRandomExtraAbilityEffect;
            casterAddRandomExtraAbilityEffect._extraData = new List<ExtraAbility_Wearable_SMS>(casterAddRandomExtraAbilityEffect._extraData)
            {
                cogsTurner
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(ripcord.Item, new ItemModdedUnlockInfo("Ripcord_SW", ResourceLoader.LoadSprite("UnlockHeavenHoftstoldtLocked", null, 32, null), "HIF_Hoftstoldt_Divine_ACH"));
        }
    }
}
