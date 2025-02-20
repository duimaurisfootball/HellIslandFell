using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Draugr
    {
        public static void Add()
        {
            Enemy boler = new Enemy("Draugr", "Draugr_EN")
            {
                Health = 17,
                HealthColor = Pigments.Grey,
                Size = 2,
                CombatSprite = ResourceLoader.LoadSprite("TimelineDraugr", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadDraugr", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineDraugr", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("LongLiver_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("LongLiver_CH").deathSound,
            };
            boler.PrepareEnemyPrefab("Assets/DraugrAssetBundle/Draugr.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/DraugrAssetBundle/DraugrGibs.prefab").GetComponent<ParticleSystem>());
            boler.AddPassives([]);

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Salted_ID", out StatusEffect_SO Salted);
            StatusEffect_Apply_Effect SaltedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            SaltedApply._Status = Salted;

            StatusEffect_Apply_Effect ScarsApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            ScarsApply._Status = StatusField.Scars;

            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            StatusEffect_Apply_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FrailApply._Status = StatusField.Frail;

            Targetting_ByUnit_Index CenterTarget = ScriptableObject.CreateInstance<Targetting_ByUnit_Index>();
            CenterTarget.getAllies = true;
            CenterTarget.slotPointerDirections = [0];
            CenterTarget.allSelfSlots = false;

            Ability ashes = new Ability("Ashes", "HIFAshes_A")
            {
                Description = "Apply 3 Salted to all party members.",
                Cost = [Pigments.Purple],
                Visuals = Visuals.Melt,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(SaltedApply, 3, Targeting.Unit_AllOpponents),
                ],
                Rarity = CustomAbilityRarity.Weight(8, true),
                Priority = Priority.Normal,
            };
            ashes.AddIntentsToTarget(Targeting.Unit_AllOpponents, ["Status_Salted"]);

            Ability hexes = new Ability("Hexes", "HIFHexes_A")
            {
                Description = "Apply 1 Scar to the Opposing party members.",
                Cost = [Pigments.Yellow],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([0, 1]),
                Effects =
                [
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.GenerateBigUnitSlotTarget([0, 1])),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Normal,
            };
            hexes.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1]), [nameof(IntentType_GameIDs.Status_Scars)]);

            Ability blades = new Ability("Blades", "HIFBlades_A")
            {
                Description = "Apply 2 Oil Slicked to the Opposing party members.",
                Cost = [Pigments.Yellow],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([0, 1]),
                Effects =
                [
                    Effects.GenerateEffect(OilApply, 2, Targeting.GenerateBigUnitSlotTarget([0, 1])),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Normal,
            };
            blades.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1]), [nameof(IntentType_GameIDs.Status_OilSlicked)]);

            Ability stones = new Ability("Stones", "HIFStones_A")
            {
                Description = "Apply 1 Frail to the Opposing party members.",
                Cost = [Pigments.Yellow],
                Visuals = Visuals.RendRight,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([0, 1]),
                Effects =
                [
                    Effects.GenerateEffect(FrailApply, 1, Targeting.GenerateBigUnitSlotTarget([0, 1])),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Normal,
            };
            stones.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1]), [nameof(IntentType_GameIDs.Status_Frail)]);

            boler.AddEnemyAbilities(
                [
                    ashes,
                    hexes,
                    blades,
                    stones,
                ]);
            boler.AddEnemy(true, true, false);
        }
    }
}
