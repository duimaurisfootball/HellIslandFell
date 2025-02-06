using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class Maecenas
    {
        public static void Add()
        {
            Character maecenas = new Character("Maecenas", "Maecenas_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("MaecenasFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("MaecenasBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("MaecenasOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Agon_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Agon_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Agon_CH").dxSound,
            };
            maecenas.GenerateMenuCharacter(ResourceLoader.LoadSprite("MaecenasMenu"), ResourceLoader.LoadSprite("MaecenasLocked"));
            maecenas.SetMenuCharacterAsFullDPS();

            LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("Thunderstorm_ID", out FieldEffect_SO Thunderstorm);
            FieldEffect_Apply_Effect ThunderstormApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ThunderstormApply._Field = Thunderstorm;

            RemoveFieldEffectEffect ThunderstormRemove = ScriptableObject.CreateInstance<RemoveFieldEffectEffect>();
            ThunderstormRemove._Field = Thunderstorm;

            HealEffect PrevHeal = ScriptableObject.CreateInstance<HealEffect>();
            PrevHeal.usePreviousExitValue = true;

            DamageEffect KillDamage = ScriptableObject.CreateInstance<DamageEffect>();
            KillDamage._returnKillAsSuccess = true;

            //rain
            Ability rain0 = new Ability("Distant Rain", "Rain_1_A")
            {
                Description = "If this party member is in the Thunderstorm, remove all of it and heal for an equivalent amount.\nOtherwise, apply 1 Thunderstorm to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasRain"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormRemove, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ThunderstormApply, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                ]
            };
            rain0.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Rem_Field_Thunderstorm"]);
            rain0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            rain0.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);

            Ability rain1 = new Ability("Light Rain", "Rain_2_A")
            {
                Description = "If this party member is in the Thunderstorm, remove all of it and heal for an equivalent amount.\nOtherwise, apply 3 Thunderstorm to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasRain"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormRemove, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ThunderstormApply, 3, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                ]
            };
            rain1.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Rem_Field_Thunderstorm"]);
            rain1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            rain1.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);

            Ability rain2 = new Ability("Cold Rain", "Rain_3_A")
            {
                Description = "If this party member is in the Thunderstorm, remove all of it and heal for an equivalent amount.\nOtherwise, apply 4 Thunderstorm to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasRain"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormRemove, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ThunderstormApply, 4, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                ]
            };
            rain2.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Rem_Field_Thunderstorm"]);
            rain2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);
            rain2.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);

            Ability rain3 = new Ability("Torrential Rain", "Rain_4_A")
            {
                Description = "If this party member is in the Thunderstorm, remove all of it and heal for an equivalent amount.\nOtherwise, apply 5 Thunderstorm to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasRain"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormRemove, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ThunderstormApply, 5, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                ]
            };
            rain3.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Rem_Field_Thunderstorm"]);
            rain3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);
            rain3.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);


            //lightningStrike
            Ability lightningStrike0 = new Ability("Hot Lightning Strike", "LightningStrike_1_A")
            {
                Description = "40% chance to apply 1 Thunderstorm to this position.\nDeal 5 damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasLightningStrike"),
                Cost = [Pigments.Blue, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormApply, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(40)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 5, Targeting.Slot_Front),
                ]
            };
            lightningStrike0.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);
            lightningStrike0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability lightningStrike1 = new Ability("Snow Lightning Strike", "LightningStrike_2_A")
            {
                Description = "50% chance to apply 1 Thunderstorm to this position.\nDeal 7 damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasLightningStrike"),
                Cost = [Pigments.Blue, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormApply, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 7, Targeting.Slot_Front),
                ]
            };
            lightningStrike1.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);
            lightningStrike1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability lightningStrike2 = new Ability("Ball Lightning Strike", "LightningStrike_3_A")
            {
                Description = "60% chance to apply 1 Thunderstorm to this position.\nDeal 9 damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasLightningStrike"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormApply, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(60)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 9, Targeting.Slot_Front),
                ]
            };
            lightningStrike2.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);
            lightningStrike2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability lightningStrike3 = new Ability("Double Lightning Strike", "LightningStrike_4_A")
            {
                Description = "70% chance to apply 1 Thunderstorm to this position.\nDeal 11 damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasLightningStrike"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormApply, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(70)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 11, Targeting.Slot_Front),
                ]
            };
            lightningStrike3.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);
            lightningStrike3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);


            //sand
            Ability hail0 = new Ability("Soft Hail", "Hail_1_A")
            {
                Description = "Deal 5 damage to the Left and Right enemies.\nIf this move kills, apply 3 Thunderstorm to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasHail"),
                Cost = [Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(KillDamage, 5, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(ThunderstormApply, 3, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ]
            };
            hail0.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_3_6)]);
            hail0.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);

            Ability hail1 = new Ability("Falling Hail", "Hail_2_A")
            {
                Description = "Deal 7 damage to the Left and Right enemies.\nIf this move kills, apply 3 Thunderstorm to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasHail"),
                Cost = [Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(KillDamage, 7, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(ThunderstormApply, 3, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ]
            };
            hail1.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_7_10)]);
            hail1.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);

            Ability hail2 = new Ability("Cannon Hail", "Hail_3_A")
            {
                Description = "Deal 9 damage to the Left and Right enemies.\nIf this move kills, apply 3 Thunderstorm to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasHail"),
                Cost = [Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(KillDamage, 9, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(ThunderstormApply, 3, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ]
            };
            hail2.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_7_10)]);
            hail2.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);

            Ability hail3 = new Ability("Giant Hail", "Hail_4_A")
            {
                Description = "Deal 11 damage to the Left and Right enemies.\nIf this move kills, apply 3 Thunderstorm to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("MaecenasHail"),
                Cost = [Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(KillDamage, 11, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(ThunderstormApply, 3, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ]
            };
            hail3.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_11_15)]);
            hail3.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);

            maecenas.AddLevelData(15, new Ability[] { rain0, lightningStrike0, hail0 });
            maecenas.AddLevelData(17, new Ability[] { rain1, lightningStrike1, hail1 });
            maecenas.AddLevelData(20, new Ability[] { rain2, lightningStrike2, hail2 });
            maecenas.AddLevelData(24, new Ability[] { rain3, lightningStrike3, hail3 });

            maecenas.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Maecenas_Witness_ACH");
            maecenas.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Maecenas_Divine_ACH");
            maecenas.AddCharacter(true, false);
        }
    }
}
