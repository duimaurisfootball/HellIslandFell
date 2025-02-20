using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using static Hell_Island_Fell.Custom_Passives.InterpolatedPassiveAbility;

namespace Hell_Island_Fell.Custom_Passives
{
    public class CustomPassives
    {
        public static void Add()
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ChangePigmentGeneratorPool_Effect GrayGenerator = ScriptableObject.CreateInstance<ChangePigmentGeneratorPool_Effect>();
            GrayGenerator._newPool = [Pigments.Grey];

            Connection_PerformEffectPassiveAbility impunity = ScriptableObject.CreateInstance<Connection_PerformEffectPassiveAbility>();
            impunity.m_PassiveID = "Impunity";
            impunity.passiveIcon = ResourceLoader.LoadSprite("FarahImpunity");
            impunity._characterDescription = "The yellow pigment generator now generates gray pigment instead.";
            impunity._enemyDescription = "The yellow pigment generator now generates gray pigment instead.";
            impunity.connectionEffects =
                [
                    Effects.GenerateEffect(GrayGenerator, 1, Targeting.Slot_SelfSlot),
                ];
            impunity.disconnectionEffects =
                [

                ];
            impunity._triggerOn =
                [

                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Check_CountCurrencyEffect CurrencyCount = ScriptableObject.CreateInstance<Check_CountCurrencyEffect>();
            CurrencyCount._returnPercentage = true;

            CasterStoreValueSetterPreviousExitEffect MetalSet = ScriptableObject.CreateInstance<CasterStoreValueSetterPreviousExitEffect>();
            MetalSet.m_unitStoredDataID = "MetallurgyStoredValue";

            CasterStoreValueCheckOverThresholdEffect MetalCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverThresholdEffect>();
            MetalCheck.m_unitStoredDataID = "MetallurgyStoredValue";

            EntryToExitPercentageEffect OneHalf = ScriptableObject.CreateInstance<EntryToExitPercentageEffect>();
            OneHalf._Denominator = 2;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_PreviousExit_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_PreviousExit_Effect>();
            DisappearingApply._Status = Disappearing;

            Connection_PerformEffectPassiveAbility metallurgy = ScriptableObject.CreateInstance<Connection_PerformEffectPassiveAbility>();
            metallurgy.m_PassiveID = "Metallurgy";
            metallurgy.passiveIcon = ResourceLoader.LoadSprite("SaladMetallurgy");
            metallurgy._characterDescription = "This party member scales based on how much money you have at the start of combat.";
            metallurgy._enemyDescription = "This enemy scales based on how much money you have at the start of combat.";
            metallurgy.connectionEffects =
                [
                    Effects.GenerateEffect(CurrencyCount, 100, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MetalSet, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MetalCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(OneHalf, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DisappearingApply, 1, Targeting.Slot_SelfSlot),
                ];
            metallurgy.disconnectionEffects =
                [

                ];
            metallurgy._triggerOn =
                [

                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            StatusEffect_Apply_Effect CursedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            CursedApply._Status = StatusField.Cursed;

            PerformEffectPassiveAbility sacrilege = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            sacrilege.m_PassiveID = "Sacrilege";
            sacrilege.passiveIcon = ResourceLoader.LoadSprite("RodneySacrilege");
            sacrilege._characterDescription = "This party member is Cursed.";
            sacrilege._enemyDescription = "This enemy is Cursed.";
            sacrilege.effects =
                [
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_SelfSlot),
                ];
            sacrilege._triggerOn =
                [
                    TriggerCalls.OnCombatStart,
                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ChangeToRandomHealthColorEffect RedHealth = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            RedHealth._healthColors = [Pigments.Red];

            SetCasterExtraSpritesEffect ResetSprite = ScriptableObject.CreateInstance<SetCasterExtraSpritesEffect>();
            ResetSprite._ExtraSpriteID = "VatSpritesDefault";

            SetCasterExtraSpritesEffect CycleSprite = ScriptableObject.CreateInstance<SetCasterExtraSpritesEffect>();
            CycleSprite._ExtraSpriteID = "VatSpritesSpecial";

            CheckCasterHealthColorEffect CheckYellow = ScriptableObject.CreateInstance<CheckCasterHealthColorEffect>();
            CheckYellow._color = Pigments.Yellow;

            CheckCasterHealthColorEffect CheckPurple = ScriptableObject.CreateInstance<CheckCasterHealthColorEffect>();
            CheckPurple._color = Pigments.Purple;

            CheckCasterHealthColorEffect CheckBlue = ScriptableObject.CreateInstance<CheckCasterHealthColorEffect>();
            CheckBlue._color = Pigments.Blue;

            CheckCasterNotHealthColorsEffect CheckGrey = ScriptableObject.CreateInstance<CheckCasterNotHealthColorsEffect>();
            CheckGrey._colors = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple];

            PerformDoubleEffectPassiveAbility humorous = ScriptableObject.CreateInstance<PerformDoubleEffectPassiveAbility>();
            humorous.m_PassiveID = "Humorous";
            humorous.passiveIcon = ResourceLoader.LoadSprite("VatHumorous");
            humorous._characterDescription = "Upon taking damage, this party member's health will change to red.";
            humorous._enemyDescription = "Upon taking damage, this enemy's health will change to red.";
            humorous._secondDoesPerformPopUp = false;
            humorous.effects =
                [
                    Effects.GenerateEffect(RedHealth, 1, Targeting.Slot_SelfSlot)
                ];
            humorous._triggerOn =
                [
                    TriggerCalls.OnDirectDamaged,
                ];
            humorous._secondEffects =
                [
                    Effects.GenerateEffect(ResetSprite, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CheckYellow, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CheckPurple, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CheckBlue, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CheckGrey, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CycleSprite, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),

                ];
            humorous._secondTriggerOn =
                [
                    TriggerCalls.OnHealthColorChanged,
                    TriggerCalls.OnBeforeCombatStart
                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ChangeToRandomHealthColorEffect colors = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            colors._healthColors = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple, Pigments.Grey];

            Connection_PerformEffectPassiveAbility chaos = ScriptableObject.CreateInstance<Connection_PerformEffectPassiveAbility>();
            chaos.m_PassiveID = "Chaos";
            chaos.passiveIcon = ResourceLoader.LoadSprite("PassiveChaos");
            chaos._characterDescription = "This party member's health color and costs are randomized at the start of combat.";
            chaos._enemyDescription = "This passive is not meant for enemies.";
            chaos.connectionEffects =
                [
                    Effects.GenerateEffect(colors, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeCostsEffect>(), 1, Targeting.Slot_SelfSlot),
                ];
            chaos.disconnectionEffects =
                [

                ];
            chaos._triggerOn =
                [

                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ConnoisseurPassiveAbility connoisseur = ScriptableObject.CreateInstance<ConnoisseurPassiveAbility>();
            connoisseur.m_PassiveID = "Connoisseur";
            connoisseur.passiveIcon = ResourceLoader.LoadSprite("AlvinarConnoisseur");
            connoisseur._characterDescription = "This party member deals 1/3 extra damage for each status effect on targets.";
            connoisseur._enemyDescription = "This party member deals 1/3 extra damage for each status effect on targets.";
            connoisseur._triggerOn =
                [
                    TriggerCalls.OnWillApplyDamage,
                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            PerformEffectPassiveAbility sweeping = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            sweeping.m_PassiveID = "Sweeping";
            sweeping.passiveIcon = ResourceLoader.LoadSprite("AelieSwept");
            sweeping._characterDescription = "Upon performing an ability, this party member and the Left and Right allies will be randomly moved.";
            sweeping._enemyDescription = "Upon performing an ability, this enemy and the Left and Right enemies will be randomly moved.";
            sweeping.effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<MassSwapZoneEffect>(), 1, Targeting.Slot_SelfAndSides),
                ];
            sweeping._triggerOn =
                [
                    TriggerCalls.OnAbilityUsed,
                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            InterpolatedPassiveAbility interpolated = ScriptableObject.CreateInstance<InterpolatedPassiveAbility>();
            interpolated.m_PassiveID = "Interpolated";
            interpolated.passiveIcon = ResourceLoader.LoadSprite("ExambryInterpolated");
            interpolated._characterDescription = "All damage this party member recieves is turned into an equivalent amount of Disappearing.";
            interpolated._enemyDescription = "All damage this enemy recieves is turned into an equivalent amount of Disappearing.";
            interpolated._triggerOn =
                [
                    TriggerCalls.OnBeingDamaged,
                ];
            interpolated.conditions =
                [
                    ScriptableObject.CreateInstance<InterpolationCondition>(),
                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            PerformEffectPassiveAbility grinding = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            grinding.m_PassiveID = "Grinding";
            grinding.passiveIcon = ResourceLoader.LoadSprite("NosestoneGrinding");
            grinding._characterDescription = "Upon dying, add 1 cost of this enemy's health color to every party member ability.\nWill not add to \"Slap\".";
            grinding._enemyDescription = "Upon dying, add 1 cost of this party member's health color to every party member ability.\nWill not add to \"Slap\".";
            grinding.effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<AddCostByHealthColorEffect>(), 1, Targeting.AllUnits),
                ];
            grinding._triggerOn =
                [
                    TriggerCalls.OnDeath,
                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            StatusEffect_Apply_Effect ScarsApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            ScarsApply._Status = StatusField.Scars;

            PerformImmediateEffectPassiveAbility thorny = ScriptableObject.CreateInstance<PerformImmediateEffectPassiveAbility>();
            thorny.m_PassiveID = "Thorny";
            thorny.passiveIcon = ResourceLoader.LoadSprite("PinecThorny");
            thorny._characterDescription = "If the wrong pigment is used while performing an ability apply 1 Scar to this party member.";
            thorny._enemyDescription = "Not intended for enemies.";
            thorny.effects =
                [
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                ];
            thorny._triggerOn =
                [
                    TriggerCalls.OnWillReceiveCostDamage,
                ];


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Connection_PerformEffectPassiveAbility disruption = ScriptableObject.CreateInstance<Connection_PerformEffectPassiveAbility>();
            disruption.m_PassiveID = "Disruption";
            disruption.passiveIcon = ResourceLoader.LoadSprite("BolerDisruption");
            disruption._characterDescription = "Not intended for party members.";
            disruption._enemyDescription = "Randomize and reduce all party member ability costs.";
            disruption._triggerOn =
                [
                    TriggerCalls.Count,
                ];
            disruption.connectionEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<BolerRandomizeEffect>(), 1, Targeting.AllUnits),
                ];
            disruption.disconnectionEffects =
                [

                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            RandomizeCasterExtraSpritesEffect FaceOff = ScriptableObject.CreateInstance<RandomizeCasterExtraSpritesEffect>();
            FaceOff._ExtraSpriteID = "HoftstoldtSpritesSpecial";

            int FaceOn = 216;

            Connection_PerformEffectPassiveAbility HConstruct = ScriptableObject.CreateInstance<Connection_PerformEffectPassiveAbility>();
            HConstruct.m_PassiveID = Passives.Construct.m_PassiveID;
            HConstruct.passiveIcon = Passives.Construct.passiveIcon;
            HConstruct._characterDescription = Passives.Construct._characterDescription;
            HConstruct._enemyDescription = Passives.Construct._enemyDescription;
            HConstruct._triggerOn = [];
            HConstruct.connectionEffects =
                [
                    Effects.GenerateEffect((LoadedAssetsHandler.GetPassive("Construct_PA") as Connection_PerformEffectPassiveAbility).connectionEffects[1].effect, 1),
                    Effects.GenerateEffect(FaceOff, FaceOn, Targeting.Slot_SelfSlot),
                ];
            HConstruct.disconnectionEffects = [];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ChangeCasterHealthColorBetweenColorsEffect RedYellow = ScriptableObject.CreateInstance<ChangeCasterHealthColorBetweenColorsEffect>();
            RedYellow._color1 = Pigments.Red;
            RedYellow._color2 = Pigments.Yellow;

            PerformEffectPassiveAbility TwoFacedRedYellow = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            TwoFacedRedYellow.m_PassiveID = Passives.TwoFaced.m_PassiveID;
            TwoFacedRedYellow.passiveIcon = ResourceLoader.LoadSprite("PassiveTwoFacedRY");
            TwoFacedRedYellow._characterDescription = "Upon receiving direct damage this party member will change its health colour from red to yellow or vice versa.";
            TwoFacedRedYellow._enemyDescription = "Upon receiving direct damage this enemy will change its health colour from red to yellow or vice versa.";
            TwoFacedRedYellow.effects =
                [
                    Effects.GenerateEffect(RedYellow, 1, Targeting.Slot_SelfSlot),
                ];
            TwoFacedRedYellow._triggerOn =
                [
                    TriggerCalls.OnDirectDamaged,
                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            SpawnEnemyAnywhereRandomBetweenPreviousEffect SpawnKekos = ScriptableObject.CreateInstance<SpawnEnemyAnywhereRandomBetweenPreviousEffect>();
            SpawnKekos.enemy = LoadedAssetsHandler.GetEnemy("Keko_EN");
            SpawnKekos._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            PerformEffectPassiveAbility DecayKekingdom = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            DecayKekingdom.m_PassiveID = Passives.Example_Decay_MudLung.m_PassiveID;
            DecayKekingdom.passiveIcon = Passives.Example_Decay_MudLung.passiveIcon;
            DecayKekingdom._characterDescription = "Not meant for party members.";
            DecayKekingdom._enemyDescription = "Upon death this enemy will decay into 1-3 Kekos.";
            DecayKekingdom.effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1),
                    Effects.GenerateEffect(SpawnKekos, 3),
                ];
            DecayKekingdom._triggerOn =
                [
                    TriggerCalls.OnDeath,
                ];

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            SwapToOneSideEffect MoveLeft = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            MoveLeft._swapRight = false;

            RemoveFieldEffectEffect RemoveConstricted = ScriptableObject.CreateInstance<RemoveFieldEffectEffect>();
            RemoveConstricted._Field = StatusField.Constricted;

            PerformEffectPassiveAbility billiard = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            billiard.m_PassiveID = "Billiard";
            billiard.passiveIcon = ResourceLoader.LoadSprite("BoojumBilliard");
            billiard._characterDescription = "Upon recieving direct damage, remove Constricted from this party member's position and move to the left.";
            billiard._enemyDescription = "Upon recieving direct damage, remove Constricted from this enemy's position and move to the left.";
            billiard._triggerOn =
                [
                    TriggerCalls.OnDirectDamaged,
                ];
            billiard.effects =
                [
                    Effects.GenerateEffect(RemoveConstricted, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MoveLeft, 1, Targeting.Slot_SelfSlot),
                ];


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("ShadowHands_ID", out FieldEffect_SO ShadowHands);
            FieldEffect_Apply_Effect ShadowHandsApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShadowHandsApply._Field = ShadowHands;

            PerformEffectPassiveAbility mirage = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            mirage.m_PassiveID = "Mirage";
            mirage.passiveIcon = ResourceLoader.LoadSprite("StareyedMirage");
            mirage._characterDescription = "This party member will apply 1 Shadow Hands to their current position at the beginning of each turn.";
            mirage._enemyDescription = "This enemy will apply 1 Shadow Hands to their current position at the beginning of each turn.";
            mirage._triggerOn =
                [
                    TriggerCalls.OnTurnStart,
                ];
            mirage.effects =
                [
                    Effects.GenerateEffect(ShadowHandsApply, 1, Targeting.Slot_SelfSlot),
                ];


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            TargetedStatusEffectPassive conviction = ScriptableObject.CreateInstance<TargetedStatusEffectPassive>();
            conviction.m_PassiveID = "Conviction";
            conviction.passiveIcon = ResourceLoader.LoadSprite("NabaConviction");
            conviction._characterDescription = "The Left and Right allies are Divinely Protected.";
            conviction._enemyDescription = "The Left and Right allies are Divinely Protected.";
            conviction._triggerOn = [];
            conviction.conditions = [];
            conviction.doesPassiveTriggerInformationPanel = false;
            conviction.targeting = Targeting.Slot_AllySides;
            conviction.status = StatusField.DivineProtection;
            conviction.affectedUnitsStoredValue = UnitStoreData.CreateAndAddCustom_Basic_UnitStoreDataToPool("DivineProtectingProtectedUnits_USD");

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Passives.AddCustomPassiveToPool("Impunity_PA", "Impunity", impunity);
            Passives.AddCustomPassiveToPool("Metallurgy_PA", "Metallurgy", metallurgy);
            Passives.AddCustomPassiveToPool("Sacrilege_PA", "Sacrilege", sacrilege);
            Passives.AddCustomPassiveToPool("Humorous_PA", "Humorous", humorous);
            Passives.AddCustomPassiveToPool("Chaos_PA", "Chaos", chaos);
            Passives.AddCustomPassiveToPool("Connoisseur_PA", "Connoisseur", connoisseur);
            Passives.AddCustomPassiveToPool("Sweeping_PA", "Sweeping", sweeping);
            Passives.AddCustomPassiveToPool("Interpolated_PA", "Interpolated", interpolated);
            Passives.AddCustomPassiveToPool("Grinding_PA", "Grinding", grinding);
            Passives.AddCustomPassiveToPool("Thorny_PA", "Thorny", thorny);
            Passives.AddCustomPassiveToPool("Disruption_PA", "Disruption", disruption);
            Passives.AddCustomPassiveToPool("HConstruct_PA", "Construct", HConstruct);
            Passives.AddCustomPassiveToPool("TwoFacedRY_PA", "Two Faced", TwoFacedRedYellow);
            Passives.AddCustomPassiveToPool("DecayKekingdom_PA", "Decay", DecayKekingdom);
            Passives.AddCustomPassiveToPool("Billiard_PA", "Billiard", billiard);
            Passives.AddCustomPassiveToPool("Mirage_PA", "Mirage", mirage);
            Passives.AddCustomPassiveToPool("Conviction_PA", "Conviction", conviction);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            GlossaryPassives ImpunityInfo = new GlossaryPassives("Impunity", "The yellow pigment generator now generates gray pigment instead.", ResourceLoader.LoadSprite("FarahImpunity"));
            GlossaryPassives MetallurgyInfo = new GlossaryPassives("Metallurgy", "This party member/enemy scales based on how much money you have at the start of combat.", ResourceLoader.LoadSprite("SaladMetallurgy"));
            GlossaryPassives SacrilegeInfo = new GlossaryPassives("Sacrilege", "This party member/enemy is Cursed.", ResourceLoader.LoadSprite("RodneySacrilege"));
            GlossaryPassives HumorousInfo = new GlossaryPassives("Humorous", "Upon taking damage, this party member/enemy's health will change to red.", ResourceLoader.LoadSprite("VatHumorous"));
            GlossaryPassives ChaosInfo = new GlossaryPassives("Chaos", "This party member's health color and costs are randomized at the start of combat.", ResourceLoader.LoadSprite("PassiveChaos"));
            GlossaryPassives ConnoisseurInfo = new GlossaryPassives("Connoisseur", "This party member/enemy deals 1/3 extra damage for each status effect on targets.", ResourceLoader.LoadSprite("AlvinarConnoisseur"));
            GlossaryPassives SweepingInfo = new GlossaryPassives("Sweeping", "Upon performing an ability, this party member/enemy and the Left and Right allies/enemies will be randomly moved.", ResourceLoader.LoadSprite("AelieSwept"));
            GlossaryPassives InterpolatedInfo = new GlossaryPassives("Interpolated", "All damage this party member/enemy recieves is turned into an equivalent amount of Disappearing.", ResourceLoader.LoadSprite("ExambryInterpolated"));
            GlossaryPassives GrindingInfo = new GlossaryPassives("Grinding", "Upon dying, add 1 cost of this party member/enemy's health color to every party member ability.", ResourceLoader.LoadSprite("NosestoneGrinding"));
            GlossaryPassives WartsInfo = new GlossaryPassives("Warts", "Apply Shield to this position upon receiving direct damage.", ResourceLoader.LoadSprite("PassiveWarts"));
            GlossaryPassives AltAttacksInfo = new GlossaryPassives("Alt Attacks", "This enemy will perform an additional ability each turn, this ability is randomly selected from a given set", ResourceLoader.LoadSprite("PassiveAltAttacks"));
            GlossaryPassives InvincibleInfo = new GlossaryPassives("Invincible", "Prevent all incoming damage that is less than or equal to this party member/enemy's level of Invincible.", ResourceLoader.LoadSprite("PassiveInvincible"));
            GlossaryPassives ThornyInfo = new GlossaryPassives("Thorny", "If the wrong pigment is used while performing an ability apply 1 Scar to this party member.", ResourceLoader.LoadSprite("PinecThorny"));
            GlossaryPassives DisruptionInfo = new GlossaryPassives("Disruption", "Randomize and reduce all party member ability costs.", ResourceLoader.LoadSprite("BolerDisruption"));
            GlossaryPassives BilliardInfo = new GlossaryPassives("Billiard", "Upon recieving direct damage, remove Constricted from this party member/enemy's position and move to the left.", ResourceLoader.LoadSprite("BoojumBilliard"));
            GlossaryPassives MirageInfo = new GlossaryPassives("Mirage", "This party member will apply 1 Shadow Hands to their current position at the beginning of each turn.", ResourceLoader.LoadSprite("StareyedMirage"));
            GlossaryPassives ConvictionInfo = new GlossaryPassives("Conviction", "The Left and Right allies are Divinely Protected.", ResourceLoader.LoadSprite("NabaConviction"));
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            LoadedDBsHandler.GlossaryDB.AddNewPassive(ImpunityInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(MetallurgyInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(SacrilegeInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(HumorousInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(ChaosInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(ConnoisseurInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(SweepingInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(InterpolatedInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(GrindingInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(WartsInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(AltAttacksInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(InvincibleInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(ThornyInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(DisruptionInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(BilliardInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(MirageInfo);
            LoadedDBsHandler.GlossaryDB.AddNewPassive(ConvictionInfo);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            UnitStoreData_ModIntSO wartiness = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            wartiness.m_Text = "Warts: +{0}";
            wartiness._UnitStoreDataID = "WartsStoredValue";
            wartiness.m_TextColor = Color.yellow;
            wartiness.m_CompareDataToThis = 0;
            wartiness.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("WartsStoredValue", wartiness);

            UnitStoreData_ModIntSO consistentFleetiness = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            consistentFleetiness.m_Text = "";
            consistentFleetiness._UnitStoreDataID = "ConsistentFleetingStoredValue";
            consistentFleetiness.m_TextColor = Color.clear;
            consistentFleetiness.m_CompareDataToThis = 0;
            consistentFleetiness.m_ShowIfDataIsOver = false;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("ConsistentFleetingStoredValue", consistentFleetiness);
        }

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedWarts = [];

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedInvincibility = [];

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedConsistentFleeting = [];

        private static readonly Dictionary<int, BasePassiveAbilitySO> GeneratedRetortion = [];

        public static BasePassiveAbilitySO WartsGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedWarts, amount, delegate (int x)
            {
                CasterStoreValueCheckOverThresholdEffect WartsCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverThresholdEffect>();
                WartsCheck.m_unitStoredDataID = "WartsStoredValue";

                FieldEffect_Apply_AddPrevious_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_AddPrevious_Effect>();
                ShieldApply._Field = StatusField.Shield;

                PerformEffectPassiveAbility wartsGenerated = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
                wartsGenerated.name = $"Warts_{x}_PA";
                wartsGenerated.m_PassiveID = "Warts";
                wartsGenerated._passiveName = $"Warts ({x})";
                wartsGenerated._characterDescription = $"Apply {x} Shield to this position upon receiving direct damage.";
                wartsGenerated._enemyDescription = $"Apply {x} Shield to this position upon receiving direct damage.";
                wartsGenerated.passiveIcon = ResourceLoader.LoadSprite("PassiveWarts");
                wartsGenerated._triggerOn =
                [
                    TriggerCalls.OnDirectDamaged
                ];
                wartsGenerated.effects =
                [
                    Effects.GenerateEffect(WartsCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ShieldApply, amount, Targeting.Slot_SelfAll),
                ];
                wartsGenerated.conditions =
                [

                ];
                wartsGenerated.doesPassiveTriggerInformationPanel = true;
                wartsGenerated.specialStoredData = LoadedDBsHandler.MiscDB.GetUnitStoreData("WartsStoredValue");
                return wartsGenerated;
            });
        }

        public static BasePassiveAbilitySO AltAttacksGenerator(List<ExtraAbilityInfo> bonusAbilities)
        {
            List<string> names = [];
            foreach (ExtraAbilityInfo ability in bonusAbilities)
            {
                if (ability == null || ability.ability == null)
                {
                    Debug.Log("Null alt ability: " + ability.ability.name);
                    return null;
                }
                names.Add(ability.ability._abilityName);
            }
            AltAttacksPassiveAbility altAttacksPassiveAbility = ScriptableObject.CreateInstance<AltAttacksPassiveAbility>();

            altAttacksPassiveAbility.name = string.Join("_", names) + "_PA";
            altAttacksPassiveAbility.m_PassiveID = string.Join("_", names);
            altAttacksPassiveAbility._passiveName = "Alt Attacks";
            altAttacksPassiveAbility._characterDescription = "This passive is not meant for party members.";
            altAttacksPassiveAbility._enemyDescription = "This enemy will perform an additional ability each turn, this ability is randomly selected from the following:" + "\n" + string.Join("\n", names);
            altAttacksPassiveAbility.passiveIcon = ResourceLoader.LoadSprite("PassiveAltAttacks");
            altAttacksPassiveAbility._triggerOn = [TriggerCalls.ExtraAdditionalAttacks];
            altAttacksPassiveAbility.conditions = [];
            altAttacksPassiveAbility.doesPassiveTriggerInformationPanel = false;
            altAttacksPassiveAbility.specialStoredData = null;
            altAttacksPassiveAbility._altAbilities = bonusAbilities;
            return altAttacksPassiveAbility;
        }

        public static BasePassiveAbilitySO InvincibilityGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedInvincibility, amount, delegate (int x)
            {
                InvinciblePassiveAbility invincibleGenerated = ScriptableObject.CreateInstance<InvinciblePassiveAbility>();
                invincibleGenerated.name = $"Invincible_{x}_PA";
                invincibleGenerated.m_PassiveID = "Invincible";
                invincibleGenerated._passiveName = $"Invincible ({x})";
                invincibleGenerated._characterDescription = $"Prevent all incoming damage that is less than or equal to {x}.";
                invincibleGenerated._enemyDescription = $"Prevent all incoming damage that is less than or equal to {x}.";
                invincibleGenerated.passiveIcon = ResourceLoader.LoadSprite("PassiveInvincible");
                invincibleGenerated.doesPassiveTriggerInformationPanel = true;
                invincibleGenerated._triggerOn = [TriggerCalls.OnBeingDamaged];
                invincibleGenerated._limit = x;
                return invincibleGenerated;
            });
        }

        public static BasePassiveAbilitySO ConsistentFleetingGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedConsistentFleeting, amount, delegate (int x)
            {
                CasterStoreValueCheckOverEntryVariableEffect FleeCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverEntryVariableEffect>();
                FleeCheck.m_unitStoredDataID = "ConsistentFleetingStoredValue";

                CasterStoredValueChangeEffect FleeFirst = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
                FleeFirst._increase = true;
                FleeFirst.m_unitStoredDataID = "ConsistentFleetingStoredValue";

                PopupPassiveEffect FleetingPopup = ScriptableObject.CreateInstance<PopupPassiveEffect>();
                FleetingPopup._text = $"Fleeting ({x})";
                FleetingPopup._icon = Passives.Fleeting1.passiveIcon;

                PerformEffectPassiveAbility consistentFleetingGenerated = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
                consistentFleetingGenerated.name = $"ConsistentFleeting_{x}_PA";
                consistentFleetingGenerated.m_PassiveID = Passives.Fleeting3.m_PassiveID;
                consistentFleetingGenerated._passiveName = $"Fleeting ({x})";
                consistentFleetingGenerated._characterDescription = $"After {x} rounds this party member will flee... Coward.";
                consistentFleetingGenerated._enemyDescription = $"After {x} rounds this enemy will flee.";
                consistentFleetingGenerated.passiveIcon = Passives.Fleeting1.passiveIcon;
                consistentFleetingGenerated.doesPassiveTriggerInformationPanel = false;
                consistentFleetingGenerated._triggerOn = [TriggerCalls.OnRoundFinished, TriggerCalls.OnCombatStart];
                consistentFleetingGenerated.effects =
                [
                    Effects.GenerateEffect(FleeCheck, x - 1),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<FleeTargetEffect>(), 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(FleetingPopup, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(FleeFirst, 1),
                ];
                return consistentFleetingGenerated;
            });
        }
        public static BasePassiveAbilitySO RetortionGenerator(int amount)
        {
            return GetOrCreatePassive(GeneratedRetortion, amount, delegate (int x)
            {
                RetortionPassiveAbility retortionGenerated = ScriptableObject.CreateInstance<RetortionPassiveAbility>();
                retortionGenerated.name = $"Retortion_{x}_PA";
                retortionGenerated.m_PassiveID = "Retortion";
                retortionGenerated._passiveName = $"Retortion ({x})";
                retortionGenerated._characterDescription = "This passive is not meant for party members.";
                retortionGenerated._enemyDescription = $"Upon receiving {x} or more direct damage, add 1 of this enemy's actions to the timeline.";
                retortionGenerated.passiveIcon = ResourceLoader.LoadSprite("PassiveRetortion");
                retortionGenerated._triggerOn = [TriggerCalls.OnDirectDamaged];
                IntegerReferenceOverEqualValueEffectorCondition integerReferenceOverEqualValueEffectorCondition = ScriptableObject.CreateInstance<IntegerReferenceOverEqualValueEffectorCondition>();
                integerReferenceOverEqualValueEffectorCondition.compareValue = x;
                retortionGenerated.conditions = [integerReferenceOverEqualValueEffectorCondition, Passives.Overexert2.conditions[1]];
                retortionGenerated.doesPassiveTriggerInformationPanel = true;
                retortionGenerated.specialStoredData = null;
                return retortionGenerated;
            });
        }

        private static TValue GetOrCreatePassive<TKey, TValue>(IDictionary<TKey, TValue> readFrom, TKey key, Func<TKey, TValue> create)
        {
            if (readFrom.TryGetValue(key, out TValue value))
            {
                return value;
            }

            return readFrom[key] = create(key);
        }
    }
}
