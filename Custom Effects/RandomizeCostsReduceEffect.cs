using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RandomizeCostsReduceEffect : EffectSO
    {
        public static ManaColorSO[] RandomArray(int length, ManaColorSO[] OrigCost)
        {
            List<ManaColorSO> list = [];
            for (int i = 0; i < length; i++)
            {
                list.Add(RandomPig());
            }
            return [.. list];
        }

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

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit is CharacterCombat cc)
                {
                    foreach (var ab in cc.CombatAbilities)
                    {
                        var nober = ab.cost.Length - 1;
                        if (ab.cost.Length > 1)
                        {
                            ab.cost = new ManaColorSO[nober];
                            for (int i = 0; i < nober; i++)
                            {
                                ab.cost = RandomArray(nober, ab.cost);
                                exitAmount = nober;
                            }
                        }
                        if (ab.cost.Length == 1)
                        {
                            ab.cost = new ManaColorSO[ab.cost.Length];
                            for (int i = 0; i < ab.cost.Length; i++)
                            {
                                ab.cost = RandomArray(1, ab.cost);
                                exitAmount = 1;
                            }
                        }
                    }
                    foreach (CharacterCombatUIInfo characterCombatUIInfo in stats.combatUI._charactersInCombat.Values)
                    {
                        bool flag3 = characterCombatUIInfo.SlotID == targetSlotInfo.Unit.SlotID;
                        if (flag3)
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
