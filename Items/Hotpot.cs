using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Hotpot
    {
        public static void Add()
        {
            SpecialDamageEffect DirectFireDamage = ScriptableObject.CreateInstance<SpecialDamageEffect>();
            DirectFireDamage._selfCast = true;
            DirectFireDamage._usePreviousExitValue = false;
            DirectFireDamage._randomBetweenPreviousExitValue = true;
            DirectFireDamage._ignoreShield = false;
            DirectFireDamage._addHealthMana = true;
            DirectFireDamage._direct = true;
            DirectFireDamage._returnKillAsSuccess = false;
            DirectFireDamage._damageType = CombatType_GameIDs.Dmg_Fire.ToString();

            Ability flamelash = new Ability("Flamelash", "Flamelash_A")
            {
                Description = "Deal 0-20 direct fire damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("ItemFlamelash"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Effects =
                    [
                        Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0, Targeting.Slot_Front),
                        Effects.GenerateEffect(DirectFireDamage, 20, Targeting.Slot_Front),
                    ]
            };
            flamelash.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);

            ExtraAbility_Wearable_SMS fireBreather = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            fireBreather._extraAbility = flamelash.GenerateCharacterAbility();

            PerformEffect_Item hotpot = new PerformEffect_Item("Hotpot_ID", null, false)
            {
                Item_ID = "Hotpot_SW",
                Name = "Hotpot",
                Flavour = "\"Sizzle sizzle!\"",
                Description = "Adds \"Flamelash\" as an additional ability, an inconsistent fire attack.",
                IsShopItem = true,
                ShopPrice = 7,
                DoesPopUpInfo = false,
                StartsLocked = false,
                TriggerOn = TriggerCalls.Count,
                EquippedModifiers =
                [
                    fireBreather,
                ],
                Icon = ResourceLoader.LoadSprite("ShopHotPot")
            };
            Connection_PerformEffectPassiveAbility connection_PerformEffectPassiveAbility = LoadedAssetsHandler.GetCharacter("Doll_CH").passiveAbilities[0] as Connection_PerformEffectPassiveAbility;
            CasterAddRandomExtraAbilityEffect casterAddRandomExtraAbilityEffect = connection_PerformEffectPassiveAbility.connectionEffects[1].effect as CasterAddRandomExtraAbilityEffect;
            casterAddRandomExtraAbilityEffect._extraData = new List<ExtraAbility_Wearable_SMS>(casterAddRandomExtraAbilityEffect._extraData)
            {
                fireBreather
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(hotpot.Item, new ItemModdedUnlockInfo(hotpot.Item_ID, ResourceLoader.LoadSprite("ShopHotPot")));
        }
    }
}
