using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ConsumePigmentChangeHealthColorByGreatestEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            JumpAnimationInformation jumpInfo = stats.GenerateUnitJumpInformation(caster.ID, caster.IsUnitCharacter);
            string manaConsumedSound = stats.audioController.manaConsumedSound;
            ManaColorSO blood = Pigments.Grey;
            Dictionary<ManaColorSO, int> bloods = [];
            foreach (ManaBarSlot mana in stats.MainManaBar.ManaBarSlots)
            {
                if (!mana.IsEmpty)
                {
                    if (!bloods.ContainsKey(mana.ManaColor))
                    {
                        bloods[mana.ManaColor] = 0;
                    }
                    else
                    {
                        bloods[mana.ManaColor]++;
                    }
                }
            }

            int num = 0;
            List<ManaColorSO> bloodList = [];
            foreach (KeyValuePair<ManaColorSO, int> kvp in bloods)
            {
                if (kvp.Value == num)
                {
                    bloodList.Add(kvp.Key);
                    num = kvp.Value;
                }
                if (kvp.Value > num)
                {
                    bloodList.Clear();
                    bloodList.Add(kvp.Key);
                    num = kvp.Value;
                }
            }

            if (bloodList.Count > 0)
            {
                blood = bloodList[UnityEngine.Random.Range(0, bloodList.Count)];
            }

            exitAmount = stats.MainManaBar.ConsumeAllMana(jumpInfo, manaConsumedSound);

            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (!targetSlotInfo.HasUnit)
                {
                    continue;
                }

                if (blood != targetSlotInfo.Unit.HealthColor)
                {
                    targetSlotInfo.Unit.ChangeHealthColor(blood);
                }
            }

            return exitAmount > 0;
        }
    }
}