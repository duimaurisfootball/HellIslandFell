using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class GunGun
    {
        public static void Add()
        {
            DamageEffect Damage = ScriptableObject.CreateInstance<DamageEffect>();

            RemoveAllStatusEffectsEffect RemoveStatus = ScriptableObject.CreateInstance<RemoveAllStatusEffectsEffect>();

            RemoveAllFieldEffectsEffect RemoveField = ScriptableObject.CreateInstance<RemoveAllFieldEffectsEffect>();

            RefreshAbilityUseEffect Refresh = ScriptableObject.CreateInstance<RefreshAbilityUseEffect>();

            RemovePassiveEffect AnchoredRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            AnchoredRemove.m_PassiveID = Passives.Anchored.m_PassiveID;

            RemoveFieldEffectEffect ConstrictedRemove = ScriptableObject.CreateInstance<RemoveFieldEffectEffect>();
            ConstrictedRemove._field = StatusField.Constricted;

            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            FieldEffect_Apply_Effect ConstrictedApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ConstrictedApply._Field = StatusField.Constricted;

            SwapToSidesEffect SwapSides = ScriptableObject.CreateInstance<SwapToSidesEffect>();

            SwapToOneSideEffect SwapRight = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            SwapRight._swapRight = true;

            SwapToOneSideEffect SwapLeft = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            SwapLeft._swapRight = false;

            SpawnEnemyInSlotFromEntryEffect Fish = ScriptableObject.CreateInstance<SpawnEnemyInSlotFromEntryEffect>();
            Fish.enemy = LoadedAssetsHandler.GetEnemy("Mung_EN");
            Fish.trySpawnAnywhereIfFail = true;
            Fish._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            SpawnEnemyInSlotFromEntryEffect Glass = ScriptableObject.CreateInstance<SpawnEnemyInSlotFromEntryEffect>();
            Glass.enemy = LoadedAssetsHandler.GetEnemy("DivineGlass_EN");
            Glass.trySpawnAnywhereIfFail = true;
            Glass._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            Ability mosaDelete = new Ability("Delete", "HIF_MosaDelete_A")
            {
                Description = "Remove all status and field effects from the Opposing enemy.\nDeal 7 damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaDelete"),
                Cost = [Pigments.Purple],
                Effects =
                    [
                        Effects.GenerateEffect(RemoveStatus, 1, Targeting.Slot_Front),
                        Effects.GenerateEffect(RemoveField, 1, Targeting.Slot_Front),
                        Effects.GenerateEffect(Damage, 7, Targeting.Slot_Front),
                    ]
            };
            mosaDelete.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Misc), nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability mosaMobilise = new Ability("Mobilise", "HIF_MosaMobilise_A")
            {
                Description = "Remove Anchored and all Constricted from the Left, Right, and Opposing enemies.\nApply 15 Oil Slicked to the Left, Right, and Opposing enemies.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaMobilise"),
                Cost = [Pigments.Red],
                Effects =
                    [
                        Effects.GenerateEffect(AnchoredRemove, 1, Targeting.Slot_FrontAndSides),
                        Effects.GenerateEffect(ConstrictedRemove, 1, Targeting.Slot_FrontAndSides),
                        Effects.GenerateEffect(OilApply, 15, Targeting.Slot_FrontAndSides),
                    ]
            };
            mosaMobilise.AddIntentsToTarget(Targeting.Slot_FrontAndSides, ["Rem_Passive_Anchored", nameof(IntentType_GameIDs.Rem_Field_Constricted), nameof(IntentType_GameIDs.Status_OilSlicked)]);

            Ability mosaCamera = new Ability("Camera", "HIF_MosaCamera_A")
            {
                Description = "Apply 4 Constricted to the Opposing enemy.\nMove this party member to the Left or Right.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaCamera"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Effects =
                    [
                        Effects.GenerateEffect(ConstrictedApply, 4, Targeting.Slot_Front),
                        Effects.GenerateEffect(SwapSides, 1, Targeting.Slot_SelfSlot),
                    ]
            };
            mosaCamera.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Field_Constricted)]);
            mosaCamera.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Sides)]);

            Ability mosaVaporise = new Ability("Vaporise", "HIF_MosaVaporise_A")
            {
                Description = "Move the Left and Right enemies closer to this party member.\nApply 4 Constricted to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaVaporise"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Effects =
                    [
                        Effects.GenerateEffect(SwapRight, 1, Targeting.Slot_OpponentLeft),
                        Effects.GenerateEffect(SwapLeft, 1, Targeting.Slot_OpponentRight),
                        Effects.GenerateEffect(ConstrictedApply, 4, Targeting.Slot_Front),
                    ]
            };
            mosaVaporise.AddIntentsToTarget(Targeting.Slot_OpponentLeft, [nameof(IntentType_GameIDs.Swap_Right)]);
            mosaVaporise.AddIntentsToTarget(Targeting.Slot_OpponentRight, [nameof(IntentType_GameIDs.Swap_Left)]);
            mosaVaporise.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Field_Constricted)]);

            Ability mosaLadder = new Ability("Ladder", "HIF_MosaLadder_A")
            {
                Description = "Deal 5 damage to All enemies to the Left of this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaLadder"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Effects =
                    [
                        Effects.GenerateEffect(Damage, 5, Targeting.Slot_OpponentAllLefts),
                    ]
            };
            mosaLadder.AddIntentsToTarget(Targeting.Slot_OpponentAllLefts, [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability mosaPomegranate = new Ability("Pomegranate", "HIF_MosaPomegranate_A")
            {
                Description = "Deal 5 damage to the Left, Right, and Opposing enemies.\nMove the Left, Right, and Opposing enemies away from this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaPomegranate"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Blue],
                Effects =
                    [
                        Effects.GenerateEffect(SwapLeft, 1, Targeting.Slot_OpponentLeft),
                        Effects.GenerateEffect(SwapRight, 1, Targeting.Slot_OpponentRight),
                        Effects.GenerateEffect(SwapSides, 1, Targeting.Slot_Front),
                        Effects.GenerateEffect(Damage, 5, Targeting.Slot_FrontAndSides),
                    ]
            };
            mosaPomegranate.AddIntentsToTarget(Targeting.Slot_OpponentLeft, [nameof(IntentType_GameIDs.Swap_Left)]);
            mosaPomegranate.AddIntentsToTarget(Targeting.Slot_OpponentRight, [nameof(IntentType_GameIDs.Swap_Right)]);
            mosaPomegranate.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Swap_Sides)]);
            mosaPomegranate.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability mosaFish = new Ability("Fish", "HIF_MosaFish_A")
            {
                Description = "Spawn a Mung in the Opposing position, or anywhere if the Opposing position is occupied.\n80% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaFish"),
                Cost = [Pigments.Yellow, Pigments.Red, Pigments.Blue],
                Effects =
                    [
                        Effects.GenerateEffect(Fish, 0, Targeting.Slot_Front),
                        Effects.GenerateEffect(Refresh, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(80)),
                    ]
            };
            mosaFish.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability mosaSpear = new Ability("Spear", "HIF_MosaSpear_A")
            {
                Description = "Deal 4 damage to the Opposing enemy.\n50% chance to refresh this party member's abilities.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaSpear"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Effects =
                    [
                        Effects.GenerateEffect(Damage, 4, Targeting.Slot_Front),
                        Effects.GenerateEffect(Refresh, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    ]
            };
            mosaSpear.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            mosaSpear.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability mosaInstabox = new Ability("Instabox", "HIF_MosaInstabox_A")
            {
                Description = "Spawn Divine Glass in the Opposing position, or anywhere if the Opposing position is occupied.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaInstabox"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Effects =
                    [
                        Effects.GenerateEffect(Glass, 0, Targeting.Slot_Front),
                    ]
            };
            mosaInstabox.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability mosaBamboo = new Ability("Bamboo", "HIF_MosaBamboo_A")
            {
                Description = "Apply 5 Shield to All ally positions to the Right of this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaBamboo"),
                Cost = [Pigments.Yellow, Pigments.Yellow],
                Effects =
                    [
                        Effects.GenerateEffect(ShieldApply, 5, Targeting.Slot_AlliesAllRights),
                    ]
            };
            mosaBamboo.AddIntentsToTarget(Targeting.Slot_AlliesAllRights, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability mosaBox = new Ability("Box", "HIF_MosaBox_A")
            {
                Description = "Apply 5 Shield to this party member.\n50% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("MosaBox"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Effects =
                    [
                        Effects.GenerateEffect(ShieldApply, 5, Targeting.Slot_SelfSlot),
                        Effects.GenerateEffect(Refresh, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    ]
            };
            mosaBox.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield), nameof(IntentType_GameIDs.Other_Refresh)]);

            ExtraAbility_Wearable_SMS MosaDeleteE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaDeleteE._extraAbility = mosaDelete.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaMobiliseE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaMobiliseE._extraAbility = mosaMobilise.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaCameraE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaCameraE._extraAbility = mosaCamera.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaVaporiseE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaVaporiseE._extraAbility = mosaVaporise.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaLadderE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaLadderE._extraAbility = mosaLadder.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaPomegranateE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaPomegranateE._extraAbility = mosaPomegranate.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaFishE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaFishE._extraAbility = mosaFish.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaSpearE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaSpearE._extraAbility = mosaSpear.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaInstaboxE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaInstaboxE._extraAbility = mosaInstabox.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaBambooE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaBambooE._extraAbility = mosaBamboo.GenerateCharacterAbility();

            ExtraAbility_Wearable_SMS MosaBoxE = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            MosaBoxE._extraAbility = mosaBox.GenerateCharacterAbility();

            CasterAddRandomExtraAbilityEffect MosaAbilities = ScriptableObject.CreateInstance<CasterAddRandomExtraAbilityEffect>();
            MosaAbilities._slapData =
                [

                ];
            MosaAbilities._extraData =
                [
                    MosaDeleteE,
                    MosaMobiliseE,
                    MosaCameraE,
                    MosaVaporiseE,
                    MosaLadderE,
                    MosaPomegranateE,
                    MosaFishE,
                    MosaSpearE,
                    MosaInstaboxE,
                    MosaBambooE,
                    MosaBoxE,
                ];

            PerformEffect_Item mosaLina = new PerformEffect_Item("HIF_GunGun_ID", null, false)
            {
                Item_ID = "GunGun_TW",
                Name = "Gun Gun",
                Flavour = "\"Slick tricks.\"",
                Description = "Gives this party member a random weird ability at the start of combat.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("TreasureGunGun"),
                Effects =
                [
                    Effects.GenerateEffect(MosaAbilities, 1, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(mosaLina.Item, new ItemModdedUnlockInfo(mosaLina.Item_ID, ResourceLoader.LoadSprite("TreasureGunGun")));
        }
    }
}
