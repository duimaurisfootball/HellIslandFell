using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Heehoo
    {
        public static void Add()
        {
            Enemy heehoo = new Enemy("Heehoo", "Heehoo_EN")
            {
                Health = 40,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineHeehoo", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadHeehoo", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("OverworldHeehoo", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Revola_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Revola_EN").deathSound,
                UnitTypes =
                [
                    "HellishID"
                ],
            };
            heehoo.PrepareEnemyPrefab("Assets/HeehooAssetBundle/Heehoo.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/HeehooAssetBundle/HeehooGibs.prefab").GetComponent<ParticleSystem>());
            heehoo.AddPassives([Passives.Unstable, Passives.Leaky1, CustomPassives.RetortionGenerator(7)]);

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            ConsumeAllFromOneRandomColorManaEffect ConsumeRandom = ScriptableObject.CreateInstance<ConsumeAllFromOneRandomColorManaEffect>();
            ConsumeRandom._consumeMana = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple];

            DamageEffect PrevDamage = ScriptableObject.CreateInstance<DamageEffect>();
            PrevDamage._usePreviousExitValue = true;

            LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("ShadowHands_ID", out FieldEffect_SO ShadowHands);
            FieldEffect_Apply_Effect ShadowHandsApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShadowHandsApply._Field = ShadowHands;

            Ability playtime = new Ability("Playtime", "Playtime_A")
            {
                Description = "Apply 10 Disappearing to this enemy.\nHeal this enemy.",
                Cost = [Pigments.Red, Pigments.BluePurple],
                Visuals = Visuals.FingerGuns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 10, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 5, Targeting.Slot_SelfSlot)
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.Normal,
            };
            playtime.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Status_Disappearing"]);
            playtime.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability semanticDrip = new Ability("Semantic Drip", "SemanticDrip_A")
            {
                Description = "Consume all of a random pigment.\nDeal an equivalent amount of damage to the Opposing party member.",
                Cost = [Pigments.Yellow, Pigments.RedPurple],
                Visuals = Visuals.Gnaw,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ConsumeRandom, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PrevDamage, 1, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.Normal,
            };
            semanticDrip.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            semanticDrip.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability curtainCall = new Ability("Curtain Call", "CurtainCall_A")
            {
                Description = "Apply 2 Shadow Hands to the Left, Right, and Opposing party members.",
                Cost = [Pigments.Purple, Pigments.YellowBlue],
                Visuals = Visuals.Scream,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ShadowHandsApply, 2, Targeting.Slot_FrontAndSides),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.Normal,
            };
            curtainCall.AddIntentsToTarget(Targeting.Slot_FrontAndSides, ["Field_ShadowHands"]);

            heehoo.AddEnemyAbilities(
                [
                    playtime,
                    semanticDrip,
                    curtainCall,
                ]);
            heehoo.AddEnemy(true, true, false);
        }
    }
}
