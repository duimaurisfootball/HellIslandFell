using BrutalAPI;
using Hell_Island_Fell.Abilities;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Passives;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class ProlificNosestone
    {
        public static void Add()
        {
            Enemy prolificNosestone = new Enemy("Prolific Nosestone", "ProlificNosestone_EN")
            {
                Health = 25,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineProlificNosestone", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadProlificNosestone", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineProlificNosestone", new Vector2(0.5f, 0f), 32),
                DamageSound = "event:/ProlificDamage",
                DeathSound = "event:/ProlificDeath",
            };
            prolificNosestone.PrepareEnemyPrefab("Assets/ProlificNosestoneAssetBundle/ProlificNosestone.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ProlificNosestoneAssetBundle/ProlificGibs.prefab").GetComponent<ParticleSystem>());
            prolificNosestone.AddPassives([Passives.Pure, Passives.GetCustomPassive("Grinding_PA")]);

            DamageOnDoubleCascadeEffect conceptDamage = ScriptableObject.CreateInstance<DamageOnDoubleCascadeEffect>();
            conceptDamage._ignoreShield = true;
            conceptDamage._cascadeDecrease = 0;
            conceptDamage._cascadeIsIndirect = false;
            conceptDamage._consistentCascade = true;

            Ability highConcepts = new Ability("High Concepts", "HighConcepts_A")
            {
                Description = "Deal almost no damage to this enemy.\nDamage spreads directly to the Left and Right without falloff, ignoring shield, hitting all targets twice.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(conceptDamage, 1, Targeting.GenerateSlotTarget([0, 1, 1, 2, 2, 3, 3, 4, 4, -1, -1, -2, -2, -3, -3, -4, -4], true, false)),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.ExtremelyFast,
            };
            highConcepts.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_1_2)]);
            highConcepts.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Damage_1_2)]);

            prolificNosestone.AddEnemyAbilities(
                [
                    NosestoneAbilities.Nosing,
                    NosestoneAbilities.Stoning,
                    highConcepts,
                ]);
            prolificNosestone.AddEnemy(true, false, false);
        }
    }
}
