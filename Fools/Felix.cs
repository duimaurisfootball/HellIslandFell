using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Felix
    {
        public static void Add()
        {
            Ability slap2 = new Ability("Slap", "AltSlap_A")
            {
                Description = "Deal 1-2 damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixSlap"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomDamageBetweenPreviousAndEntryEffect>(), 2, Targeting.Slot_Front),
                ]
            };
            slap2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);

            ExtraCCSprites_ArraySO ClockSprites = ScriptableObject.CreateInstance<ExtraCCSprites_ArraySO>();
            ClockSprites._doesLoop = true;
            ClockSprites._DefaultID = "FelixSpritesDefault";
            ClockSprites._SpecialID = "FelixSpritesSpecial";
            ClockSprites._frontSprite =
                [
                    ResourceLoader.LoadSprite("FelixFront2", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixFront3", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixFront4", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixFront5", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixFront6", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixFront7", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixFront1", new Vector2(0.5f, 0f), 32),
                ];
            ClockSprites._backSprite =
                [
                    ResourceLoader.LoadSprite("FelixBack", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixBack", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixBack", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixBack", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixBack", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixBack", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("FelixBack", new Vector2(0.5f, 0f), 32),
                ];

            Character felix = new Character("Felix", "Felix_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("FelixFront1", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("FelixBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("FelixOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = "event:/FelixDamage",
                DeathSound = "event:/FelixDeath",
                DialogueSound = "event:/FelixTalk",
                ExtraSprites = ClockSprites,
                BasicAbility = slap2,
                IgnoredAbilitiesForDPSBuilds = [2],
                IgnoredAbilitiesForSupportBuilds = [1],
            };
            felix.GenerateMenuCharacter(ResourceLoader.LoadSprite("FelixMenu"), ResourceLoader.LoadSprite("FelixLocked"));
            felix.AddPassives([Passives.GetCustomPassive("Chaos_PA"), Passives.Delicate]);

            IntentInfoBasic CostRerollIntent = new()
            {
                _color = Color.white,
                _sprite = ResourceLoader.LoadSprite("IntentCostReroll")
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Reroll_Cost", CostRerollIntent);

            SetCasterExtraSpritesEffect ClockTicker = ScriptableObject.CreateInstance<SetCasterExtraSpritesEffect>();
            ClockTicker._ExtraSpriteID = "FelixSpritesSpecial";

            //stored values
            UnitStoreData_ModIntSO DamageUp = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            DamageUp.m_Text = "Pendulum Max: +{0}";
            DamageUp._UnitStoreDataID = "PendulumUpStoredValue";
            DamageUp.m_TextColor = Color.red;
            DamageUp.m_CompareDataToThis = 0;
            DamageUp.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("PendulumUpStoredValue", DamageUp);

            CasterStoredValueChangeEffect DmgUpChange = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            DmgUpChange._randomBetweenPrevious = true;
            DmgUpChange.m_unitStoredDataID = "PendulumUpStoredValue";

            UnitStoreData_ModIntSO DamageDown = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            DamageDown.m_Text = "Pendulum Min: -{0}";
            DamageDown._UnitStoreDataID = "PendulumDownStoredValue";
            DamageDown.m_TextColor = Color.red;
            DamageDown.m_CompareDataToThis = 0;
            DamageDown.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("PendulumDownStoredValue", DamageDown);

            CasterStoredValueChangeEffect DmgDownChange = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            DmgDownChange._randomBetweenPrevious = true;
            DmgDownChange.m_unitStoredDataID = "PendulumDownStoredValue";

            UnitStoreData_ModIntSO HealUp = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            HealUp.m_Text = "Butterfly Max: +{0}";
            HealUp._UnitStoreDataID = "ButterflyUpStoredValue";
            HealUp.m_TextColor = Color.cyan;
            HealUp.m_CompareDataToThis = 0;
            HealUp.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("ButterflyUpStoredValue", HealUp);

            CasterStoredValueChangeEffect HealUpChange = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            HealUpChange._randomBetweenPrevious = true;
            HealUpChange.m_unitStoredDataID = "ButterflyUpStoredValue";

            UnitStoreData_ModIntSO HealDown = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            HealDown.m_Text = "Butterfly Min: -{0}";
            HealDown._UnitStoreDataID = "ButterflyDownStoredValue";
            HealDown.m_TextColor = Color.cyan;
            HealDown.m_CompareDataToThis = 0;
            HealDown.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("ButterflyDownStoredValue", HealDown);

            CasterStoredValueChangeEffect HealDownChange = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            HealDownChange._randomBetweenPrevious = true;
            HealDownChange.m_unitStoredDataID = "ButterflyDownStoredValue";

            PendulumDamage pendulumDamage = ScriptableObject.CreateInstance<PendulumDamage>();
            pendulumDamage._valueNameTop = "PendulumUpStoredValue";
            pendulumDamage._valueNameBottom = "PendulumDownStoredValue";

            ButterflyHeal butterflyHeal = ScriptableObject.CreateInstance<ButterflyHeal>();
            butterflyHeal._valueNameTop = "ButterflyUpStoredValue";
            butterflyHeal._valueNameBottom = "ButterflyDownStoredValue";

            //determinism
            Ability determinism0 = new Ability("Fast Determinism", "Determinism_1_A")
            {
                Description = "Reroll this party member's costs. Increase butterfly max healing by 0-2. Increase pendulum max damage by 0-2.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixDeterminism"),
                Cost = [Pigments.Purple],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeCostsEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HealUpChange, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgUpChange, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            determinism0.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Reroll_Cost"]);
            determinism0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability determinism1 = new Ability("Broken Determinism", "Determinism_2_A")
            {
                Description = "Reroll this party member's costs. Increase butterfly max healing by 0-3. Increase pendulum max damage by 0-3.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixDeterminism"),
                Cost = [Pigments.Purple],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeCostsEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HealUpChange, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgUpChange, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            determinism1.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Reroll_Cost"]);
            determinism1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability determinism2 = new Ability("Slow Determinism", "Determinism_3_A")
            {
                Description = "Reroll this party member's costs. Increase butterfly max healing by 0-4. Increase pendulum max damage by 0-4.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixDeterminism"),
                Cost = [Pigments.Purple],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeCostsEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HealUpChange, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgUpChange, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            determinism2.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Reroll_Cost"]);
            determinism2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability determinism3 = new Ability("Stopped Determinism", "Determinism_4_A")
            {
                Description = "Reroll this party member's costs. Increase butterfly max healing by 1-4. Increase pendulum max damage by 1-4.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixDeterminism"),
                Cost = [Pigments.Purple],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeCostsEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HealUpChange, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgUpChange, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            determinism3.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Reroll_Cost"]);
            determinism3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            //pendulum
            Ability pendulum0 = new Ability("Grandfather Pendulum", "Pendulum_1_A")
            {
                Description = "Deal 6-7 damage to the Opposing enemy.\nDecrease this ability's minimum damage by 2-3.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixPendulum"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Intrusion,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 6, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(pendulumDamage, 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgDownChange, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            pendulum0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            pendulum0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability pendulum1 = new Ability("Foucalt Pendulum", "Pendulum_2_A")
            {
                Description = "Deal 9-10 damage to the Opposing enemy.\nDecrease this ability's minimum damage by 2-3.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixPendulum"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Intrusion,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 9, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(pendulumDamage, 10, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgDownChange, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            pendulum1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            pendulum1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability pendulum2 = new Ability("Damped Pendulum", "Pendulum_3_A")
            {
                Description = "Deal 12-13 damage to the Opposing enemy.\nDecrease this ability's minimum damage by 2-3.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixPendulum"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Intrusion,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 12, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(pendulumDamage, 13, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgDownChange, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            pendulum2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            pendulum2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability pendulum3 = new Ability("Double Pendulum", "Pendulum_4_A")
            {
                Description = "Deal 15-16 damage to the Opposing enemy.\nDecrease this ability's minimum damage by 2-3.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixPendulum"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Intrusion,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 15, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(pendulumDamage, 16, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgDownChange, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            pendulum3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);
            pendulum3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            //butterfly
            Ability butterfly0 = new Ability("Tummy Butterfly", "Butterfly_1_A")
            {
                Description = "Heal this party member and the Right ally 3-4 health.\nDecrease this ability's minimum healing by 1-2.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixButterflies"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Innocence,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(butterflyHeal, 4, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HealDownChange, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            butterfly0.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            butterfly0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability butterfly1 = new Ability("Incense Butterfly", "Butterfly_2_A")
            {
                Description = "Heal this party member and the Right ally 5-6 health.\nDecrease this ability's minimum healing by 1-2.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixButterflies"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Innocence,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(butterflyHeal, 6, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HealDownChange, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            butterfly1.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            butterfly1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability butterfly2 = new Ability("Monarch Butterfly", "Butterfly_3_A")
            {
                Description = "Heal this party member and the Right ally 7-8 health.\nDecrease this ability's minimum healing by 1-2.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixButterflies"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Innocence,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 7, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(butterflyHeal, 8, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HealDownChange, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            butterfly2.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            butterfly2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability butterfly3 = new Ability("The Butterfly Effect", "Butterfly_4_A")
            {
                Description = "Heal this party member and the Right ally 9-10 health.\nDecrease this ability's minimum healing by 1-2.",
                AbilitySprite = ResourceLoader.LoadSprite("FelixButterflies"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Innocence,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 9, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(butterflyHeal, 10, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HealDownChange, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ClockTicker, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ]
            };
            butterfly3.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            butterfly3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);


            felix.AddLevelData(12, new Ability[] { determinism0, pendulum0, butterfly0 });
            felix.AddLevelData(15, new Ability[] { determinism1, pendulum1, butterfly1 });
            felix.AddLevelData(17, new Ability[] { determinism2, pendulum2, butterfly2 });
            felix.AddLevelData(19, new Ability[] { determinism3, pendulum3, butterfly3 });

            felix.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Felix_Witness_ACH");
            felix.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Felix_Divine_ACH");
            felix.AddCharacter(true, false);


        }
    }
}