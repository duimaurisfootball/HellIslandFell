using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class OrbOfFreedom
    {
        public static void Add()
        {
            RemoveOverflowManaEffect removeOverflow = ScriptableObject.CreateInstance<RemoveOverflowManaEffect>();

            ConsumeAllManaEffect consumeMana = ScriptableObject.CreateInstance<ConsumeAllManaEffect>();

            RemoveAllStatusEffectsEffect removeStatuses = ScriptableObject.CreateInstance<RemoveAllStatusEffectsEffect>();

            FieldEffect_Apply_Effect fireApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            fireApply._Field = StatusField.OnFire;

            StatusEffect_Apply_Effect divineProtectionApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            divineProtectionApply._Status = StatusField.DivineProtection;

            DamageEffect damage = ScriptableObject.CreateInstance<DamageEffect>();
            damage._ignoreShield = true;

            ConsumeItemEffect consumeItem = ScriptableObject.CreateInstance<ConsumeItemEffect>();

            PercentageEffectorCondition onePercent = ScriptableObject.CreateInstance<PercentageEffectorCondition>();
            onePercent.triggerPercentage = 1;

            PercentageEffectorCondition fivePercent = ScriptableObject.CreateInstance<PercentageEffectorCondition>();
            fivePercent.triggerPercentage = 5;

            PercentageEffectorCondition tenPercent = ScriptableObject.CreateInstance<PercentageEffectorCondition>();
            tenPercent.triggerPercentage = 10;

            PercentageEffectorCondition twentyPercent = ScriptableObject.CreateInstance<PercentageEffectorCondition>();
            twentyPercent.triggerPercentage = 20;

            PercentageEffectorCondition fiftyPercent = ScriptableObject.CreateInstance<PercentageEffectorCondition>();
            fiftyPercent.triggerPercentage = 50;

            ContainsFieldEffectEffectorCondition fireCondition = ScriptableObject.CreateInstance<ContainsFieldEffectEffectorCondition>();
            fireCondition.fieldEffectCheck = StatusField.OnFire;

            ContainsFieldEffectEffectorCondition constrictedCondition = ScriptableObject.CreateInstance<ContainsFieldEffectEffectorCondition>();
            constrictedCondition.fieldEffectCheck = StatusField.Constricted;

            ContainsStatusEffectEffectorCondition rupturedCondition = ScriptableObject.CreateInstance<ContainsStatusEffectEffectorCondition>();
            rupturedCondition.m_Status = StatusField.Ruptured;

            ContainsStatusEffectEffectorCondition cursedCondition = ScriptableObject.CreateInstance<ContainsStatusEffectEffectorCondition>();
            cursedCondition.m_Status = StatusField.Cursed;

            IsAliveEffectorCondition aliveCondition = ScriptableObject.CreateInstance<IsAliveEffectorCondition>();

            BaseCombatTargettingSO OtherAllySlots = Targeting.GenerateSlotTarget([-4, -3, -2, -1, 1, 2, 3, 4], true);

            MultiCustomTriggerEffectItem orbOfFreedom = new MultiCustomTriggerEffectItem("OrbOfFreedom_ID")
            {
                Item_ID = "OrbOfFreedom_TW",
                Name = "Orb of Freedom",
                Flavour = "\"Do not bring the orb into Cocytus. Activating it will drown you.\"",
                Description = "Upon activation, destroy everything else on the field and this item. Activates in \"dangerous\" situations, tends to be oversensitive.",
                IsShopItem = false,
                ShopPrice = 13,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("TreasureOrbOfFreedom"),
                EffectsAndTrigger =
                [
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnDamaged,
                        effects =
                        [
                            Effects.GenerateEffect(removeOverflow, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(consumeMana, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(removeStatuses, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(divineProtectionApply, 5, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(fireApply, 5, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(fireApply, 5, OtherAllySlots),
                            Effects.GenerateEffect(damage, 40, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(damage, 40, OtherAllySlots),
                            Effects.GenerateEffect(consumeItem, 1, Targeting.Slot_SelfSlot),
                        ],
                        conditions =
                        [
                            fivePercent,
                            aliveCondition
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnStatusEffectApplied,
                        effects =
                        [
                            Effects.GenerateEffect(removeOverflow, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(consumeMana, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(removeStatuses, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(divineProtectionApply, 5, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(fireApply, 5, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(fireApply, 5, OtherAllySlots),
                            Effects.GenerateEffect(damage, 40, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(damage, 40, OtherAllySlots),
                            Effects.GenerateEffect(consumeItem, 1, Targeting.Slot_SelfSlot),
                        ],
                        conditions =
                        [
                            rupturedCondition
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnStatusEffectApplied,
                        effects =
                        [
                            Effects.GenerateEffect(removeOverflow, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(consumeMana, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(removeStatuses, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(divineProtectionApply, 5, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(fireApply, 5, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(fireApply, 5, OtherAllySlots),
                            Effects.GenerateEffect(damage, 40, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(damage, 40, OtherAllySlots),
                            Effects.GenerateEffect(consumeItem, 1, Targeting.Slot_SelfSlot),
                        ],
                        conditions =
                        [
                            twentyPercent,
                            cursedCondition
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnFieldEffectApplied,
                        effects =
                        [
                            Effects.GenerateEffect(removeOverflow, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(consumeMana, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(removeStatuses, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(divineProtectionApply, 5, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(fireApply, 5, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(fireApply, 5, OtherAllySlots),
                            Effects.GenerateEffect(damage, 40, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(damage, 40, OtherAllySlots),
                            Effects.GenerateEffect(consumeItem, 1, Targeting.Slot_SelfSlot),
                        ],
                        conditions =
                        [
                            constrictedCondition
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnFieldEffectApplied,
                        effects =
                        [
                            Effects.GenerateEffect(removeOverflow, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(consumeMana, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(removeStatuses, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(divineProtectionApply, 5, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(fireApply, 5, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(fireApply, 5, OtherAllySlots),
                            Effects.GenerateEffect(damage, 40, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(damage, 40, OtherAllySlots),
                            Effects.GenerateEffect(consumeItem, 1, Targeting.Slot_SelfSlot),
                        ],
                        conditions =
                        [
                            fiftyPercent,
                            fireCondition,
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnCombatStart,
                        effects =
                        [
                            Effects.GenerateEffect(removeOverflow, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(consumeMana, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(removeStatuses, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(divineProtectionApply, 5, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(fireApply, 5, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(fireApply, 5, OtherAllySlots),
                            Effects.GenerateEffect(damage, 40, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(damage, 40, OtherAllySlots),
                            Effects.GenerateEffect(consumeItem, 1, Targeting.Slot_SelfSlot),
                        ],
                        conditions =
                        [
                            onePercent
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnMoved,
                        effects =
                        [
                            Effects.GenerateEffect(removeOverflow, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(consumeMana, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(removeStatuses, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(divineProtectionApply, 5, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(fireApply, 5, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(fireApply, 5, OtherAllySlots),
                            Effects.GenerateEffect(damage, 40, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(damage, 40, OtherAllySlots),
                            Effects.GenerateEffect(consumeItem, 1, Targeting.Slot_SelfSlot),
                        ],
                        conditions =
                        [
                            onePercent
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnDeath,
                        effects =
                        [
                            Effects.GenerateEffect(removeOverflow, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(consumeMana, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(removeStatuses, 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(divineProtectionApply, 5, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(fireApply, 5, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(fireApply, 5, OtherAllySlots),
                            Effects.GenerateEffect(damage, 40, Targeting.Slot_OpponentAllSlots),
                            Effects.GenerateEffect(damage, 40, OtherAllySlots),
                            Effects.GenerateEffect(consumeItem, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                ]
            };
            orbOfFreedom.item._ItemTypeIDs =
                [
                    "Magic",
                    "Heart",
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(orbOfFreedom.Item, new ItemModdedUnlockInfo(orbOfFreedom.Item_ID, ResourceLoader.LoadSprite("TreasureOrbOfFreedom")));
        }
    }
}
