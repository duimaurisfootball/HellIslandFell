using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class Inequity
    {
        public static void Add()
        {
            Enemy inequity = new Enemy("Inequity", "Inequity_EN")
            {
                Health = 100,
                HealthColor = Pigments.Grey,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineInequity", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadInequity", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineInequity", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Gospel_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Gospel_CH").deathSound,
            };
            inequity.PrepareEnemyPrefab("Assets/InequityAssetBundle/Inequity.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/InequityAssetBundle/InequityGibs.prefab").GetComponent<ParticleSystem>());
            inequity.AddPassives([Passives.Withering, Passives.Inanimate, Passives.Formless]);

            IntentInfoBasic RemoveInanimateIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Inanimate.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Inanimate", RemoveInanimateIntent);

            AddPassiveToWeakestEffect InanimateAdd = ScriptableObject.CreateInstance<AddPassiveToWeakestEffect>();
            InanimateAdd._passiveToAdd = Passives.Inanimate;

            CheckAllHavePassiveAbilityEffect InanimateCheck = ScriptableObject.CreateInstance<CheckAllHavePassiveAbilityEffect>();
            InanimateCheck.m_PassiveID = Passives.Inanimate.m_PassiveID;

            RemovePassiveEffect InanimateRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            InanimateRemove.m_PassiveID = Passives.Inanimate.m_PassiveID;

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            StatusEffect_Apply_Effect DivineProtectionApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DivineProtectionApply._Status = StatusField.DivineProtection;

            StatusEffect_Apply_Effect OilSlickedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilSlickedApply._Status = StatusField.OilSlicked;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            Ability statusQuo = new Ability("Status Quo", "StatusQuo_A")
            {
                Description = "If all party members are Inanimate, remove Inanimate from all party members.\nOtherwise, add Inanimate as a passive to the party member(s) with the lowest health.\nIgnores already Inanimate party members.",
                Cost = [Pigments.Purple, Pigments.Yellow],
                Effects =
                [
                    Effects.GenerateEffect(InanimateCheck, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(InanimateRemove, 1, Targeting.Unit_AllOpponents, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(InanimateAdd, 1, Targeting.Unit_AllOpponents, Effects.CheckPreviousEffectCondition(false, 1)),
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.ExtremelySlow,
            };
            statusQuo.AddIntentsToTarget(Targeting.Unit_AllOpponents, ["Rem_Passive_Inanimate"]);
            statusQuo.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.PA_Inanimate)]);

            Ability leadThem = new Ability("Lead Them", "LeadThem_A")
            {
                Description = "Apply 2 Ruptured to every party member.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.StompLeft,
                AnimationTarget = Targeting.Unit_AllOpponents,
                Effects =
                [
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Unit_AllOpponents),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            leadThem.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability toTheGallows = new Ability("To The Gallows", "ToTheGallows_A")
            {
                Description = "Apply 2 Divine Protection to the Left and Right allies.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 2, Targeting.Slot_AllySides),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            toTheGallows.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_DivineProtection)]);

            Ability revolutions = new Ability("Revolutions", "Revolutions_A")
            {
                Description = "Apply 4 Oil Slicked to all allies and party members.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Wriggle,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(OilSlickedApply, 4, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(OilSlickedApply, 4, Targeting.Unit_AllOpponents),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            revolutions.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Status_OilSlicked)]);
            revolutions.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_OilSlicked)]);

            Ability intoOblivion = new Ability("Into Oblivion", "Into Oblivion_A")
            {
                Description = "Apply 50 Disappearing to the Opposing party member.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Conductor,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 50, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.ExtremelyFast,
            };
            intoOblivion.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);

            Ability makeAnExample = new Ability("Make an Example", "StatueMakeAnExample_A")
            {
                Description = "Deals an amount of damage equal to the party member with the current lowest health to the party member with the highest current health.",
                Cost = [Pigments.Red, Pigments.Red],
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageStrongestByWeakestAllyEffect>(), 1, Targeting.Unit_AllOpponents),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = LoadedAssetsHandler.GetEnemyAbility("MakeAnExample_A").priority,
            };
            makeAnExample.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_21)]);

            inequity.AddEnemyAbilities(
                [
                    statusQuo,
                    leadThem,
                    toTheGallows,
                    revolutions,
                    intoOblivion,
                    makeAnExample,
                ]);
            inequity.AddEnemy(true, false, false);
        }
    }
}
