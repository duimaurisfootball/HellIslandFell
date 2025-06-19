using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ResurrectNotMainCharacterEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<CharacterCombat> possibleResurrectionCharacters = stats.GetPossibleResurrectionCharacters();

            foreach (CharacterCombat character in possibleResurrectionCharacters)
            {
                if (character.IsMainCharacter)
                {
                    possibleResurrectionCharacters.Remove(character);
                }
            }

            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (possibleResurrectionCharacters.Count <= 0)
                {
                    break;
                }

                if (!targetSlotInfo.HasUnit && targetSlotInfo.IsTargetCharacterSlot)
                {
                    int index = UnityEngine.Random.Range(0, possibleResurrectionCharacters.Count);
                    CharacterCombat character = possibleResurrectionCharacters[index];
                    possibleResurrectionCharacters.RemoveAt(index);
                    if (stats.ResurrectDeadCharacter(character, targetSlotInfo.SlotID, entryVariable))
                    {
                        exitAmount++;
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
