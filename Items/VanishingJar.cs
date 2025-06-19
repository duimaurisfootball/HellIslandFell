using BrutalAPI;
using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering;

namespace Hell_Island_Fell.Items
{
    public class VanishingJar
    {
        public static void Add()
        {
            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_PreviousExit_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_PreviousExit_Effect>();
            DisappearingApply._Status = Disappearing;

            Ability soulParticulates = new Ability("Soul Particulates", "Particulates_A")
            {
                Description = "Apply 1 Disappearing to the Opposing enemy for every point of health this party member is missing.",
                AbilitySprite = ResourceLoader.LoadSprite("ItemSoulParticulates"),
                Cost = [Pigments.Purple, Pigments.Yellow],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<CheckTargetMissingHealthEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DisappearingApply, 1, Targeting.Slot_Front),
                ]
            };
            soulParticulates.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);

            ExtraAbility_Wearable_SMS soulParticles = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            soulParticles._extraAbility = soulParticulates.GenerateCharacterAbility();

            PerformEffect_Item vanishingJar = new PerformEffect_Item("VanishingJar_ID", null, false)
            {
                Item_ID = "VanishingJar_TW",
                Name = "Vanishing Jar",
                Flavour = "\"Dragged away to... the other place.\"",
                Description = "Adds \"Soul Particulates\" as an additional ability, an attack that grows stronger as the holder becomes weaker.",
                IsShopItem = false,
                ShopPrice = 3,
                DoesPopUpInfo = false,
                StartsLocked = false,
                TriggerOn = TriggerCalls.Count,
                EquippedModifiers =
                [
                    soulParticles,
                ],
                Icon = ResourceLoader.LoadSprite("TreasureVanishingJar")
            };
            Connection_PerformEffectPassiveAbility connection_PerformEffectPassiveAbility = LoadedAssetsHandler.GetCharacter("Doll_CH").passiveAbilities[0] as Connection_PerformEffectPassiveAbility;
            CasterAddRandomExtraAbilityEffect casterAddRandomExtraAbilityEffect = connection_PerformEffectPassiveAbility.connectionEffects[1].effect as CasterAddRandomExtraAbilityEffect;
            casterAddRandomExtraAbilityEffect._extraData = new List<ExtraAbility_Wearable_SMS>(casterAddRandomExtraAbilityEffect._extraData)
            {
                soulParticles
            };

            vanishingJar.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(vanishingJar.Item, new ItemModdedUnlockInfo(vanishingJar.Item_ID, ResourceLoader.LoadSprite("TreasureVanishingJar")));
        }
    }
}
