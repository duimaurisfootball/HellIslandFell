using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RandomizeCasterExtraSpritesEffect : EffectSO
    {
        [CharExtraSpriteIDsEnumRef]
        public string _ExtraSpriteID = "";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (caster.IsUnitCharacter)
            {
                int num = UnityEngine.Random.Range(0, entryVariable);
                for (int i = 0; i < num; i++)
                {
                    CombatManager.Instance.AddUIAction(new CharacterSetExtraSpriteUIAction(caster.ID, _ExtraSpriteID));
                }
                return true;
            }

            return false;
        }
    }
}
