using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class Mudball
    {
        public static void Add()
        {
            Character mudball = new Character("Mudball", "Mudball_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = false,
                MovesOnOverworld = false,
                UsesAllAbilities = true,
                FrontSprite = ResourceLoader.LoadSprite("MudballFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("MudballBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("MudballOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").damageSound,
                UnitTypes =
                [
                    "Sandwich_Silly",
                ],
            };
            mudball.AddPassives([Passives.Withering, Passives.Inanimate]);

            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;

            Ability dry = new Ability("Dry Out", "HIF_DryOut_A")
            {
                Description = "Deal 1 indirect damage to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("MudballDry"),
                Cost = [Pigments.Purple],
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 1, Targeting.Slot_SelfSlot),
                ]
            };
            dry.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_1_2)]);

            mudball.AddLevelData(1000, [dry]);
            mudball.AddCharacter();
        }
    }
}
