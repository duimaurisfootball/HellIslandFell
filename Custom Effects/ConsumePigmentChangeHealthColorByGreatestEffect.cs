using System;
using System.Collections.Generic;
using System.Linq;
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
            List<ManaColorSO> bloods = [];
            foreach (ManaBarSlot mana in stats.MainManaBar.ManaBarSlots)
            {
                if (!mana.IsEmpty)
                {
                    bloods.Add(mana.ManaColor);
                }
            }
            if (bloods.Count > 0)
            {
                blood = bloods.GroupBy(color => color).OrderByDescending(count => count.Count()).FirstOrDefault().Key;
            }

            exitAmount = stats.MainManaBar.ConsumeAllMana(jumpInfo, manaConsumedSound);

            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (!targetSlotInfo.HasUnit)
                {
                    continue;
                }

                bool flag = false;
                bool flag2 = false;
                while (!flag2)
                {
                    if (blood != targetSlotInfo.Unit.HealthColor)
                    {
                        flag = targetSlotInfo.Unit.ChangeHealthColor(blood);
                        flag2 = true;
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
