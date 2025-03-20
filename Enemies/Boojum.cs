using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Boojum
    {
        public static void Add()
        {
            Enemy boojum = new Enemy("Boojum", "Boojum_EN")
            {
                Health = 157,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineBoojum", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadBoojum", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("OverworldBoojum", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").deathSound,
                CombatExitEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<GainLootRandomCharacterEffect>(), 2),
                ],
            };
            boojum.PrepareEnemyPrefab("Assets/BoojumAssetBundle/Boojum.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/BoojumAssetBundle/BoojumGibs.prefab").GetComponent<ParticleSystem>());
            boojum.AddPassives([Passives.Confusion, Passives.GetCustomPassive("Billiard_PA")]);

            BoojumStatusEffectEffect BellmanEffect = ScriptableObject.CreateInstance<BoojumStatusEffectEffect>();
            BellmanEffect._Status = StatusField.DivineProtection;

            BoojumStatusEffectEffect BarristerEffect = ScriptableObject.CreateInstance<BoojumStatusEffectEffect>();
            BarristerEffect._Status = StatusField.Ruptured;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            BoojumStatusEffectMultiplyEffect BakerEffect = ScriptableObject.CreateInstance<BoojumStatusEffectMultiplyEffect>();
            BakerEffect._Status = Disappearing;

            SwapToOneSideEffect MoveLeft = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            MoveLeft._swapRight = false;

            PreviousEffectCondition Fail = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Fail.wasSuccessful = false;

            Ability bellman = new Ability("Bellman", "Bellman_A")
            {
                Description = "Apply 1 Divine Protection to all party members to the Right of and Opposing this enemy.\nRemove all Constricted from this position and move to the Right.\nIf the previous effect was successful, repeat this attack.",
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.RingABell,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(BellmanEffect, 1),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.Fast,
            };
            bellman.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], false), [nameof(IntentType_GameIDs.Status_DivineProtection)]);
            bellman.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Right)]);
            bellman.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Field_Constricted)]);
            bellman.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability barrister = new Ability("Barrister", "Barrister_A")
            {
                Description = "Apply 1 Ruptured to all party members to the Right of and Opposing this enemy.\nRemove all Constricted from this position and move to the Right.\nIf the previous effect was successful, repeat this attack.",
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Absolve,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(BarristerEffect, 1),
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.Fast,
            };
            barrister.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], false), [nameof(IntentType_GameIDs.Status_Ruptured)]);
            barrister.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Right)]);
            barrister.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Field_Constricted)]);
            barrister.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability butcher = new Ability("Butcher", "Butcher_A")
            {
                Description = "Deal a Painful amount of damage to all party members to the Right of and Opposing this enemy.\nRemove all Constricted from this position and move to the Right.\nIf the previous effect was successful, repeat this attack.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Flay,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<BoojumDamageEffect>(), 3)
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Fast,
            };
            butcher.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], false), [nameof(IntentType_GameIDs.Damage_3_6)]);
            butcher.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Right)]);
            butcher.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Field_Constricted)]);
            butcher.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability broker = new Ability("Broker", "Broker_A")
            {
                Description = "Destroy the Opposing party member's item and deal almost no damage to all party members to the Right of this enemy.\nIf an item was destroyed, stop this attack.\nRemove all Constricted from this position and move to the Right.\nIf the previous effect was successful, repeat this attack.\nWhen this attack ends, fully heal the Opposing party member.",
                Cost = [Pigments.Purple, Pigments.Green, Pigments.Grey],
                Visuals = Visuals.Conductor,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<BoojumItemStealEffect>(), 2),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<FullHealEffect>(), 1, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Fast,
            };
            broker.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Misc)]);
            broker.AddIntentsToTarget(Targeting.Slot_OpponentAllRights, [nameof(IntentType_GameIDs.Damage_1_2)]);
            broker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Right)]);
            broker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Field_Constricted)]);
            broker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            broker.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Heal_11_20)]);

            Ability banker = new Ability("Banker", "Banker_A")
            {
                Description = "Steal 1 coin from all party members to the Right of and Opposing this enemy.\nRemove all Constricted from this position and move to the Right.\nIf the previous effect was successful, repeat this attack.",
                Cost = [Pigments.Purple, Pigments.Yellow],
                Visuals = Visuals.Extrusion,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<BoojumCurrencyEffect>(), 1),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Fast,
            };
            banker.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], false), [nameof(IntentType_GameIDs.Misc_Currency)]);
            banker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Right)]);
            banker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Field_Constricted)]);
            banker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability baker = new Ability("Baker", "Baker_A")
            {
                Description = "Apply 1 Disappearing to the Rightmost position, then triple the amount of Disappearing on them.\nMove to the Right and remove all Constricted from this position.\nIf the previous effect was successful, repeat this attack.",
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Takedown,
                AnimationTarget = Targeting.GenerateGenericTarget([4], false),
                Effects =
                [
                    Effects.GenerateEffect(BakerEffect, 1, Targeting.GenerateGenericTarget([4], false)),
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.Fast,
            };
            baker.AddIntentsToTarget(Targeting.GenerateGenericTarget([4], false), ["Status_Disappearing"]);
            baker.AddIntentsToTarget(Targeting.GenerateGenericTarget([4], false), ["Status_Disappearing"]);
            baker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Right)]);
            baker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Field_Constricted)]);
            baker.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability beaver = new Ability("Beaver", "Beaver_A")
            {
                Description = "Move this enemy to the Furthest Left position.",
                Cost = [Pigments.Purple],
                Visuals = Visuals.Insult,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<BoojumFurthestLeftEffect>(), 1),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.Fast,
            };
            beaver.AddIntentsToTarget(Targeting.GenerateSlotTarget([-4, -3, -2, -1, 0], true), [nameof(IntentType_GameIDs.Swap_Left)]);

            boojum.AddEnemyAbilities(
                [
                    bellman,
                    barrister,
                    butcher,
                    broker,
                    banker,
                    baker,
                    beaver,
                ]);
            boojum.AddEnemy(true, false, false);
        }
    }
}
