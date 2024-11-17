using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class NoseReroll : EffectSO
    {
        public static ManaColorSO RandomPig()
        {
            ManaColorSO[] array =
            [
                Pigments.Red,
                Pigments.Red,
                Pigments.Red,
                Pigments.Red,
                Pigments.Red,
                Pigments.Red,
                Pigments.Blue,
                Pigments.Blue,
                Pigments.Blue,
                Pigments.Blue,
                Pigments.Blue,
                Pigments.Blue,
                Pigments.Yellow,
                Pigments.Yellow,
                Pigments.Yellow,
                Pigments.Yellow,
                Pigments.Yellow,
                Pigments.Yellow,
                Pigments.Purple,
                Pigments.Purple,
                Pigments.Purple,
                Pigments.Purple,
                Pigments.Purple,
                Pigments.Purple,
                Pigments.RedBlue,
                Pigments.BlueRed,
                Pigments.RedPurple,
                Pigments.PurpleRed,
                Pigments.RedYellow,
                Pigments.YellowRed,
                Pigments.BluePurple,
                Pigments.PurpleBlue,
                Pigments.BlueYellow,
                Pigments.YellowBlue,
                Pigments.YellowPurple,
                Pigments.PurpleYellow,
                Pigments.Grey,
            ];
            return array[UnityEngine.Random.Range(0, array.Length)];
        }
        public static ManaColorSO RandomColor()
        {
            ManaColorSO[] array =
            [
                Pigments.Red,
                Pigments.Blue,
                Pigments.Yellow,
                Pigments.Purple,
            ];
            return array[UnityEngine.Random.Range(0, array.Length)];
        }

        private static ManaColorSO TransformPigmentKVPs(string colorString)
        {
            for (int i = 0; i < LoadedDBsHandler.PigmentDB.PigmentPool.Keys.Count; i++)
            {
                if (LoadedDBsHandler.PigmentDB.PigmentPool.Keys.ElementAt(i) == colorString)
                {
                    return LoadedDBsHandler.PigmentDB.PigmentPool.Values.ElementAt(i);
                }
            }
            return null;
        }

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;

            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit is CharacterCombat cc)
                {
                    foreach (CombatAbility ab in cc.CombatAbilities) //iterate through every ability in the target
                    {
                        List<ManaColorSO> newCosts = [];
                        foreach (ManaColorSO cost in ab.cost) //iterate through every cost in the ability
                        {
                            bool isSplit = false;
                            if (cost.pigmentTypes.Count > 1) //check if the cost is split
                            {
                                isSplit = true;
                            }

                            if (cost != caster.HealthColor && !isSplit) //randomize the cost IF it does NOT match the health color AND the cost was NOT split
                            {
                                newCosts.Add(RandomPig()); 
                            }
                            else if (cost != caster.HealthColor && isSplit) //randomize the cost IF it does NOT match the health color AND the cost was split
                            {
                                ManaColorSO[] newColors = new ManaColorSO[cost.pigmentTypes.Count];
                                for (int i = 0; i < cost.pigmentTypes.Count; i++)
                                {
                                    ManaColorSO trueColor = TransformPigmentKVPs(cost.pigmentTypes[i]);

                                    newColors[i] = trueColor != caster.HealthColor ? RandomColor() : trueColor;
                                }
                                newCosts.Add(Pigments.SplitPigment(newColors));
                            }
                            else //otherwise directly add the pigment
                            {
                                newCosts.Add(cost); 
                            }
                        }

                        ab.cost = new ManaColorSO[newCosts.Count];
                        for (int i = 0; i < newCosts.Count; i++)
                        {
                            ab.cost[i] = newCosts[i];
                        }
                    }

                    foreach (CharacterCombatUIInfo characterCombatUIInfo in stats.combatUI._charactersInCombat.Values)
                    {
                        bool flag = characterCombatUIInfo.SlotID == targetSlotInfo.Unit.SlotID;
                        if (flag)
                        {
                            characterCombatUIInfo.UpdateAttacks([.. (targetSlotInfo.Unit as CharacterCombat).CombatAbilities]);
                            break;
                        }
                    }
                }
            }
            return exitAmount > 0;
        }
    }
}
