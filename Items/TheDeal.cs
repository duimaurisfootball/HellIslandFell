using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using static Hell_Island_Fell.Custom_Stuff.TimeTriggers;

namespace Hell_Island_Fell.Items
{
    public class TheDeal
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            RankChange_Wearable_SMS UpLevel = ScriptableObject.CreateInstance<RankChange_Wearable_SMS>();
            UpLevel._rankAdditive = 1;

            SpawnEnemyAnywhereEffect find = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            find.enemy = LoadedAssetsHandler.GetEnemy("hellislandfell_EN");

            GainPlayerCurrencyEffect money = ScriptableObject.CreateInstance<GainPlayerCurrencyEffect>();
            money._gainForPlayer = true;

            MultiCustomTriggerEffectItem theDeal = new MultiCustomTriggerEffectItem("TheDeal_ID")
            {
                Item_ID = "TheDeal_SW",
                Name = "The Deal",
                Flavour = "\"He tricks you, and gains nothing from it.\"",
                Description = "This party member is 1 level higher than they otherwise would be.\nProduce 5 coins on combat end.\n\n...Is that all?",
                IsShopItem = true,
                ShopPrice = 0,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenStareyed"),
                TriggerOn = TriggerCalls.Count,
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = Trigger1038PMAction.On1038PM,
                        effects =
                        [
                            Effects.GenerateEffect(find, 1),
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<DirectDeathEffect>(), 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = TriggerEverySecondDealAction.EverySecondDealChance,
                        effects =
                        [
                            Effects.GenerateEffect(find, 1),
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<DirectDeathEffect>(), 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnCombatEnd,
                        effects =
                        [
                            Effects.GenerateEffect(money, 5, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnBeforeCombatStart,
                        effects =
                        [
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<AddTimeTrackerEffect>()),
                        ],
                        doesPopup = true,
                    },
                ],
                EquippedModifiers =
                [
                    UpLevel,
                ],
            };

            theDeal.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Face.ToString(),
                    ItemType_GameIDs.Fabric.ToString(),
                    ItemType_GameIDs.Knife.ToString(),
                    ItemType_GameIDs.Magic.ToString(),
                    ItemType_GameIDs.Heart.ToString(),
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(theDeal.Item, new ItemModdedUnlockInfo("TheDeal_SW", ResourceLoader.LoadSprite("UnlockHeavenStareyedLocked", null, 32, null), "HIF_Stareyed_Divine_ACH"));
        }
    }
}
