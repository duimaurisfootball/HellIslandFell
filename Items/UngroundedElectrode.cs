using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class UngroundedElectrode
    {
        public static void Add()
        {

            IntentInfoDamage Damage_Unbounded = new()
            {
                _color = Color.red,
                _enemyColor = Color.magenta,
                _sprite = ResourceLoader.LoadSprite("IntentUnboundDamage"),
                _enemySprite = ResourceLoader.LoadSprite("IntentUnboundDamage"),
            };
            LoadedDBsHandler.IntentDB.AddNewDamageIntent("Damage_Unbounded", Damage_Unbounded);

            SetCasterExtraSpritesEffect ClockTicker = ScriptableObject.CreateInstance<SetCasterExtraSpritesEffect>();
            UnboundedDamageEffect UnboundedDamage = ScriptableObject.CreateInstance<UnboundedDamageEffect>();
            UnboundedDamage._repeatChance = 95;
            UnboundedDamage._cycles = 1;

            Ability runForth = new Ability("Run Forth", "RunForth_A")
            {
                Description = "Deal at least 1 damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("ItemRunForth"),
                Cost = [Pigments.Grey, Pigments.Grey, Pigments.Grey, Pigments.Grey, Pigments.Grey],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(UnboundedDamage, 0, Targeting.Slot_Front),
                ]
            };
            runForth.AddIntentsToTarget(Targeting.Slot_Front, ["Damage_Unbounded"]);

            ExtraAbility_Wearable_SMS theRunner = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            theRunner._extraAbility = runForth.GenerateCharacterAbility();

            PerformEffect_Item ungroundedElectrode = new PerformEffect_Item("UngroundedElectrode_ID", null, false)
            {
                Item_ID = "UngroundedElectrode_TW",
                Name = "Ungrounded Electrode",
                Flavour = "\"Adamant and esoteric.\"",
                Description = "Adds \"Run Forth\" as an additional ability, an attack that deals a random amount of damage.",
                IsShopItem = false,
                ShopPrice = 6,
                DoesPopUpInfo = false,
                StartsLocked = false,
                TriggerOn = TriggerCalls.Count,
                EquippedModifiers =
                [
                    theRunner,
                ],
                Icon = ResourceLoader.LoadSprite("TreasureUngroundedElectrode")
            };
            Connection_PerformEffectPassiveAbility connection_PerformEffectPassiveAbility = LoadedAssetsHandler.GetCharacter("Doll_CH").passiveAbilities[0] as Connection_PerformEffectPassiveAbility;
            CasterAddRandomExtraAbilityEffect casterAddRandomExtraAbilityEffect = connection_PerformEffectPassiveAbility.connectionEffects[1].effect as CasterAddRandomExtraAbilityEffect;
            casterAddRandomExtraAbilityEffect._extraData = new List<ExtraAbility_Wearable_SMS>(casterAddRandomExtraAbilityEffect._extraData)
            {
                theRunner
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(ungroundedElectrode.Item);
        }
    }
}
