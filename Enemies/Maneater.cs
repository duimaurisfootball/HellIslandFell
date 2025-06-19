using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Passives;
using Hell_Island_Fell.Custom_Stuff;
using Hell_Island_Fell.Status_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class Maneater
    {
        public static void Add()
        {
            Enemy maneater = new Enemy("Maneater", "Maneater_EN")
            {
                Health = 75,
                HealthColor = Pigments.Red,
                Size = 2,
                CombatSprite = ResourceLoader.LoadSprite("TimelineManeater", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadManeater", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineManeater", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Flarb_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Flarb_EN").deathSound,
                UnitTypes =
                [
                    UnitType_GameIDs.Fish.ToString(),
                ],
            };
            maneater.AddPassives([Passives.DecayGenerator(LoadedAssetsHandler.GetEnemy("NextOfKin_EN"), 55), Passives.Formless]);
            maneater.PrepareEnemyPrefab("Assets/ManeaterAssetBundle/Maneater.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ManeaterAssetBundle/ManeaterGibs.prefab").GetComponent<ParticleSystem>());

            //checks
            CheckPassiveAbilityEffect AltAttacksCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();

            CheckPassiveAbilityEffect ForgetfulCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            ForgetfulCheck.m_PassiveID = Passives.Forgetful.m_PassiveID;

            CheckPassiveAbilityEffect FormlessCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            FormlessCheck.m_PassiveID = Passives.Formless.m_PassiveID;

            CheckPassiveAbilityEffect ObscureCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            ObscureCheck.m_PassiveID = Passives.Obscure.m_PassiveID;

            CheckPassiveAbilityEffect SlipperyCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            SlipperyCheck.m_PassiveID = Passives.Slippery.m_PassiveID;

            CheckPassiveAbilityEffect WartsCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            WartsCheck.m_PassiveID = "Warts";

            //removes
            RemovePassiveEffect AltAttacksRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();

            RemovePassiveEffect ForgetfulRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            ForgetfulRemove.m_PassiveID = Passives.Forgetful.m_PassiveID;

            RemovePassiveEffect FormlessRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            FormlessRemove.m_PassiveID = Passives.Formless.m_PassiveID;

            RemovePassiveEffect ObscureRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            ObscureRemove.m_PassiveID = Passives.Obscure.m_PassiveID;

            RemovePassiveEffect SlipperyRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            SlipperyRemove.m_PassiveID = Passives.Slippery.m_PassiveID;

            RemovePassiveEffect WartsRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            WartsRemove.m_PassiveID = "Warts";

            //adds
            AddPassiveEffect AltAttacksAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();

            AddPassiveEffect ForgetfulAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            ForgetfulAdd._passiveToAdd = Passives.Forgetful;

            AddPassiveEffect FormlessAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            FormlessAdd._passiveToAdd = Passives.Formless;

            AddPassiveEffect ObscureAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            ObscureAdd._passiveToAdd = Passives.Obscure;

            AddPassiveEffect SlipperyAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            SlipperyAdd._passiveToAdd = Passives.Slippery;

            AddPassiveEffect WartsAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            WartsAdd._passiveToAdd = CustomPassives.WartsGenerator(8);

            DamageEffect Damage = ScriptableObject.CreateInstance<DamageEffect>();
            Damage._returnKillAsSuccess = true;

            HealEffect Heal = ScriptableObject.CreateInstance<HealEffect>();

            UnforgetAbilitiesEffect Unforget = ScriptableObject.CreateInstance<UnforgetAbilitiesEffect>();

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            StatusEffect_Apply_Effect LinkedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            LinkedApply._Status = StatusField.Linked;

            StatusEffect_Apply_Effect DivineProtectionApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DivineProtectionApply._Status = StatusField.DivineProtection;

            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            Targetting_ByUnit_Index CenterTarget = ScriptableObject.CreateInstance<Targetting_ByUnit_Index>();
            CenterTarget.getAllies = true;
            CenterTarget.slotPointerDirections = [0];
            CenterTarget.allSelfSlots = false;

            Ability squinchedStrengths = new Ability("Squinched Strengths", "SquinchedStrengths_A")
            {
                Description = "If this enemy has Alt Attacks, relegate them and deal a Painful amount of damage to the Left and Right enemies.\nOtherwise, give this enemy Alt Attacks.\nIf this attack kills, Miraculously heal this enemy.",
                Cost = [Pigments.Yellow, Pigments.BlueYellow],
                Visuals = Visuals.Mitosis,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(AltAttacksCheck, 0, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(AltAttacksRemove, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(Damage, 6, Targeting.Slot_AllySides, Effects.CheckPreviousEffectCondition(true, 2)),
                    Effects.GenerateEffect(Heal, 50, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(AltAttacksAdd, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(false, 4)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Fast,
            };
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_AltAttacks"]);
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Damage_3_6)]);
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Heal_21), "Passive_AltAttacks"]);

            Ability diamondDancer = new Ability("Diamond Dancer", "DiamondDancer_A")
            {
                Description = "If this enemy is Forgetful, remind it and deal an Agonizing amount of damage to the Opposing party members.\nOtherwise, make this enemy Forgetful.\nIf this attack kills, Miraculously heal this enemy.",
                Cost = [Pigments.BlueRed, Pigments.Red],
                Visuals = Visuals.StompRight,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ForgetfulCheck, 0, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(ForgetfulRemove, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(Unforget, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(true, 2)),
                    Effects.GenerateEffect(Damage, 10, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 3)),
                    Effects.GenerateEffect(Heal, 50, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(ForgetfulAdd, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(false, 4)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Fast,
            };
            diamondDancer.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Forgetful"]);
            diamondDancer.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            diamondDancer.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Heal_21), nameof(IntentType_GameIDs.PA_Forgetful)]);

            Ability flummoxingFilaments = new Ability("Flummoxing Filaments", "FlummoxingFilaments_A")
            {
                Description = "If this enemy is Formless, reshape it and apply 10 Disappearing to the Opposing party members.\nOtherwise, make this enemy Formless.",
                Cost = [Pigments.Yellow, Pigments.BlueYellow],
                Visuals = Visuals.Connection,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(FormlessCheck, 0, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(FormlessRemove, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(DisappearingApply, 10, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 2)),
                    Effects.GenerateEffect(FormlessAdd, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(false, 3)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Fast,
            };
            flummoxingFilaments.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Formless"]);
            flummoxingFilaments.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            flummoxingFilaments.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.PA_Formless)]);

            Ability behavioralBiology = new Ability("Behavioral Biology", "BehavioralBiology_A")
            {
                Description = "If this enemy is Obscured, reveal it and apply 7 Linked to the Opposing party members.\nOtherwise, Obscure this enemy.",
                Cost = [Pigments.Blue],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ObscureCheck, 0, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(ObscureRemove, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(LinkedApply, 7, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 2)),
                    Effects.GenerateEffect(ObscureAdd, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(false, 3)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Fast,
            };
            behavioralBiology.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Obscure"]);
            behavioralBiology.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Linked)]);
            behavioralBiology.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Passive_Obscure"]);

            Ability ontologicalOxygenation = new Ability("Ontological Oxygenation", "OntologicalOxygenation_A")
            {
                Description = "If this enemy is Slippery, restick it.\nOtherwise, apply 2 Divine Protection and Slippery to this enemy.",
                Cost = [Pigments.Yellow, Pigments.BlueYellow],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(SlipperyCheck, 0, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(SlipperyRemove, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(DivineProtectionApply, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 2)),
                    Effects.GenerateEffect(SlipperyAdd, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(false, 3)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Fast,
            };
            ontologicalOxygenation.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Slippery", nameof(IntentType_GameIDs.Status_DivineProtection), nameof(IntentType_GameIDs.PA_Slippery)]);

            Ability multidimensionalMateriality = new Ability("Multidimensional Materiality", "MultidimensionalMateriality_A")
            {
                Description = "If this enemy has Warts, remove them.\nOtherwise, give this enemy Warts (8) and apply 3 Oil Slicked to this enemy.",
                Cost = [Pigments.Red, Pigments.Purple],
                Visuals = Visuals.Crush,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(WartsCheck, 0, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(WartsRemove, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(OilApply, 3, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 2)),
                    Effects.GenerateEffect(WartsAdd, 0, Targeting.Slot_SelfAll, Effects.CheckPreviousEffectCondition(false, 3)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Fast,
            };
            multidimensionalMateriality.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Warts", nameof(IntentType_GameIDs.Status_OilSlicked), "Passive_Warts"]);

            ExtraAbilityInfo multi = new()
            {
                ability = multidimensionalMateriality.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(10, true),
            };

            ExtraAbilityInfo oxygen = new()
            {
                ability = ontologicalOxygenation.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(10, true),
            };

            BasePassiveAbilitySO ManeaterAltAttacks = CustomPassives.AltAttacksGenerator([multi, oxygen]);

            AltAttacksCheck.m_PassiveID = ManeaterAltAttacks.m_PassiveID;
            AltAttacksRemove.m_PassiveID = ManeaterAltAttacks.m_PassiveID;
            AltAttacksAdd._passiveToAdd = ManeaterAltAttacks;

            maneater.AddEnemyAbilities(
                [
                    squinchedStrengths,
                    diamondDancer,
                    flummoxingFilaments,
                    behavioralBiology,
                ]);
            maneater.AddEnemy(true, false, false);
        }
    }
}