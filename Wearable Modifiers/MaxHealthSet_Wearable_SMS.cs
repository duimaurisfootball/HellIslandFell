using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Wearable_Modifiers
{
    public class MaxHealthSet_Wearable_SMS : WearableStaticModifierSetterSO
    {
        public int maxHealth;
        public override void OnAttachedToCharacter(WearableStaticModifiers modifiers, CharacterSO character, int rank)
        {
            modifiers.MaximumHealthModifier = maxHealth - character.GetMaxHealth(rank);
        }

        public override void OnDettachedFromCharacter(WearableStaticModifiers modifiers)
        {
            modifiers.MaximumHealthModifier = 0;
        }
    }
}
