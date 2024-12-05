using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Salad
    {
        public static void Add()
        {
            Character salad = new Character("Salad", "Salad_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("SaladFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("SaladBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("SaladOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("SmokeStacks_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("SmokeStacks_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("SmokeStacks_CH").dxSound,
            };
            salad.GenerateMenuCharacter(ResourceLoader.LoadSprite("SaladMenu"), ResourceLoader.LoadSprite("SaladLocked"));
            salad.AddPassives([Passives.GetCustomPassive("Metallurgy_PA")]);
            salad.SetMenuCharacterAsFullDPS();

            UnitStoreData_ModIntSO metallurgy = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            metallurgy.m_Text = "{0} Metallurgy";
            metallurgy._UnitStoreDataID = "MetallurgyStoredValue";
            metallurgy.m_TextColor = Color.yellow;
            metallurgy.m_CompareDataToThis = 0;
            metallurgy.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("MetallurgyStoredValue", metallurgy);

            CasterStoreValueCheckOverThresholdEffect MetalCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverThresholdEffect>();
            MetalCheck.m_unitStoredDataID = "MetallurgyStoredValue";

            DamageEffect ExitDamage = ScriptableObject.CreateInstance<DamageEffect>();
            ExitDamage._usePreviousExitValue = true;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;
            ShieldApply._UsePreviousExitValueAsMultiplier = true;

            FieldEffect_Apply_Effect ConstrictedApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ConstrictedApply._Field = StatusField.Constricted;
            ConstrictedApply._UsePreviousExitValueAsMultiplier = true;

            HealEffect PreviousHeal = ScriptableObject.CreateInstance<HealEffect>();
            PreviousHeal.usePreviousExitValue = true;

            EntryToExitPercentageEffect OneThird = ScriptableObject.CreateInstance<EntryToExitPercentageEffect>();
            OneThird._Denominator = 3;

            EntryToExitPercentageEffect OneQuarter = ScriptableObject.CreateInstance<EntryToExitPercentageEffect>();
            OneQuarter._Denominator = 4;

            EntryToExitPercentageEffect OneFifth = ScriptableObject.CreateInstance<EntryToExitPercentageEffect>();
            OneFifth._Denominator = 5;

            EntryToExitPercentageEffect OneTenth = ScriptableObject.CreateInstance<EntryToExitPercentageEffect>();
            OneTenth._Denominator = 10;


            //copper
            Ability copper = new Ability("Copper and Rhodium", "Copper_1_A")
            {
                Description = "Deal damage equal to 1/3 of Metallurgy to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("SaladCopper"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Skewer,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(MetalCheck, 1),
                    Effects.GenerateEffect(OneThird, 1),
                    Effects.GenerateEffect(ExitDamage, 1, Targeting.Slot_Front),
                ],
                UnitStoreData = metallurgy,
            };
            copper.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);


            //titanium
            Ability titanium = new Ability("Titanium and Iridium", "Titanium_1_A")
            {
                Description = "Deal damage equal to 1/4 of Metallurgy to the Left and Right enemies.\nApply an amount of Shield equal to 1/3 of Metallurgy to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("SaladTitanium"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(MetalCheck, 1),
                    Effects.GenerateEffect(OneQuarter, 1),
                    Effects.GenerateEffect(ExitDamage, 1, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(MetalCheck, 1),
                    Effects.GenerateEffect(OneThird, 1),
                    Effects.GenerateEffect(ShieldApply, 1, Targeting.Slot_SelfSlot),
                ],
                UnitStoreData = metallurgy,
            };
            titanium.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_3_6)]);
            titanium.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);


            //mercury
            Ability mercury = new Ability("Mercury and Technetium", "Mercury_1_A")
            {
                Description = "Heal this party member an amount equal to 1/5 of Metallurgy.\nApply an amount of Constricted equal to 1/10 of Metallurgy to this position.",
                AbilitySprite = ResourceLoader.LoadSprite("SaladMercury"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Purple],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(MetalCheck, 1),
                    Effects.GenerateEffect(OneFifth, 1),
                    Effects.GenerateEffect(PreviousHeal, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MetalCheck, 1),
                    Effects.GenerateEffect(OneTenth, 1),
                    Effects.GenerateEffect(ConstrictedApply, 1, Targeting.Slot_SelfSlot),
                ],
                UnitStoreData = metallurgy,
            };
            mercury.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            mercury.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Constricted)]);

            salad.AddLevelData(50, new Ability[] { copper, titanium, mercury});

            salad.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Salad_Witness_ACH");
            salad.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Salad_Divine_ACH");
            salad.AddCharacter(true, false);
        }
    }
}
