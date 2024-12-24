using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class AncientWine
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            StatusEffect_Apply_Effect LinkedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            LinkedApply._Status = StatusField.Linked;
            LinkedApply._JustOneRandomTarget = true;

            Ability regretsVows = new Ability("Regrets and Vows", "RegretsVows_A")
            {
                Description = "Apply 3 Oil Slicked to all enemies.\nApply 6 Linked to a random enemy or party member.\nDeal 4 damage to all enemies.",
                AbilitySprite = ResourceLoader.LoadSprite("ItemRegretsVows"),
                Cost = [Pigments.Purple, Pigments.Red],
                Effects =
                    [
                        Effects.GenerateEffect(OilApply, 3, Targeting.Unit_AllOpponents),
                        Effects.GenerateEffect(LinkedApply, 6, Targeting.AllUnits),
                        Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 4, Targeting.Unit_AllOpponents),
                    ]
            };
            regretsVows.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_OilSlicked)]);
            regretsVows.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_Linked)]);
            regretsVows.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Status_Linked)]);
            regretsVows.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Damage_3_6)]);

            ExtraAbility_Wearable_SMS oilLinker = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            oilLinker._extraAbility = regretsVows.GenerateCharacterAbility();

            PerformEffect_Item ancientWine = new PerformEffect_Item("AncientWine_ID", null, false)
            {
                Item_ID = "AncientWine_SW",
                Name = "Ancient Wine",
                Flavour = "\"Aged fifty thousand years.\"",
                Description = "Adds \"Regrets and Vows\" as an additional ability, a dangerous and unwieldy oil based attack.",
                IsShopItem = true,
                ShopPrice = 2,
                DoesPopUpInfo = false,
                StartsLocked = true,
                TriggerOn = TriggerCalls.Count,
                EquippedModifiers =
                [
                    oilLinker,
                ],
                Icon = ResourceLoader.LoadSprite("UnlockHeavenGomma")
            };
            Connection_PerformEffectPassiveAbility connection_PerformEffectPassiveAbility = LoadedAssetsHandler.GetCharacter("Doll_CH").passiveAbilities[0] as Connection_PerformEffectPassiveAbility;
            CasterAddRandomExtraAbilityEffect casterAddRandomExtraAbilityEffect = connection_PerformEffectPassiveAbility.connectionEffects[1].effect as CasterAddRandomExtraAbilityEffect;
            casterAddRandomExtraAbilityEffect._extraData = new List<ExtraAbility_Wearable_SMS>(casterAddRandomExtraAbilityEffect._extraData)
            {
                oilLinker
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(ancientWine.Item, new ItemModdedUnlockInfo("AncientWine_SW", ResourceLoader.LoadSprite("UnlockHeavenGommaLocked", null, 32, null), "HIF_Gomma_Divine_ACH"));
        }
    }
}
