using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class Groanbroad
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            StatusEffectCheckerEffect OilCheck = ScriptableObject.CreateInstance<StatusEffectCheckerEffect>();
            OilCheck._status = StatusField.OilSlicked;

            PreviousEffectCondition Fail = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Fail.wasSuccessful = false;

            Ability lacerationStupendous = new Ability("Laceration Stupendous", "LacerationStupendous_A")
            {
                Description = "If the Opposing enemy is not Oil Slicked, deal 11 damage to them.\nApply 4 Oil Slicked to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("ItemLacerationStupendous"),
                Cost = [Pigments.Yellow, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                    [
                        Effects.GenerateEffect(OilCheck, 1, Targeting.Slot_Front),
                        Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 11, Targeting.Slot_Front, Fail),
                        Effects.GenerateEffect(OilApply, 4, Targeting.Slot_Front),
                    ]
            };
            lacerationStupendous.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            lacerationStupendous.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_OilSlicked)]);

            ExtraAbility_Wearable_SMS oilyCutter = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            oilyCutter._extraAbility = lacerationStupendous.GenerateCharacterAbility();

            PerformEffect_Item groanbroad = new PerformEffect_Item("Groanbroad_ID", null, false)
            {
                Item_ID = "Groanbroad_TW",
                Name = "Groanbroad",
                Flavour = "\"Skewer their hearts.\"",
                Description = "Adds \"Laceration Stupendous\" as an additional ability, a strong attack that cannot damage the same target in quick succession.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = false,
                StartsLocked = false,
                TriggerOn = TriggerCalls.Count,
                EquippedModifiers =
                [
                    oilyCutter,
                ],
                Icon = ResourceLoader.LoadSprite("TreasureGroanbroad")
            };
            Connection_PerformEffectPassiveAbility connection_PerformEffectPassiveAbility = LoadedAssetsHandler.GetCharacter("Doll_CH").passiveAbilities[0] as Connection_PerformEffectPassiveAbility;
            CasterAddRandomExtraAbilityEffect casterAddRandomExtraAbilityEffect = connection_PerformEffectPassiveAbility.connectionEffects[1].effect as CasterAddRandomExtraAbilityEffect;
            casterAddRandomExtraAbilityEffect._extraData = new List<ExtraAbility_Wearable_SMS>(casterAddRandomExtraAbilityEffect._extraData)
            {
                oilyCutter
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(groanbroad.Item);
        }
    }
}