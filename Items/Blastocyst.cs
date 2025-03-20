using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Stuff;

namespace Hell_Island_Fell.Items
{
    public class Blastocyst
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS baby = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            baby._extraPassiveAbility = Passives.GetCustomPassive("UniInfantile_PA");

            Ability cuckoo = new Ability("Cuckoo", "HIFCuckoo_A")
            {
                Description = "Heal the Opposing party member(s).",
                Cost = [Pigments.Blue],
                AnimationTarget = Targeting.Slot_Front,
                Visuals = Visuals.Innocence,
                Effects =
                    [
                        Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1),
                        Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomHealBetweenPreviousAndEntryEffect>(), 7, Targeting.Slot_Front),
                    ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Slow,
            };
            cuckoo.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Heal_1_4)]);

            ExtraAbilityInfo babbyMove = new()
            {
                ability = cuckoo.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(0, true),
            };

            AddPassiveEffect ParentalApply = ScriptableObject.CreateInstance<AddPassiveEffect>();
            ParentalApply._passiveToAdd = Passives.ParentalGenerator(babbyMove);

            PerformEffect_Item blastocyst = new PerformEffect_Item("Blastocyst_ID", null, false)
            {
                Item_ID = "Blastocyst_TW",
                Name = "Blastocyst",
                Flavour = "\"Everyone started as a fish, you know.\"",
                Description = "Give this party member Infantile as a passive. Give all enemies Parental as a passive, with a helpful ability.",
                IsShopItem = false,
                ShopPrice = 10,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenEras"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(ParentalApply, 1, Targeting.Unit_AllOpponents),
                ],
                EquippedModifiers =
                [
                    baby,
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(blastocyst.Item, new ItemModdedUnlockInfo("Blastocyst_TW", ResourceLoader.LoadSprite("UnlockHeavenErasLocked", null, 32, null), "HIF_Eras_Divine_ACH"));
        }
    }
}
