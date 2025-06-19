using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class PerformRandomAbilityFromTargetsEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<CombatAbility> abilities = [];
            foreach (TargetSlotInfo target in targets)
            {
                if (target.HasUnit && target.Unit is EnemyCombat enemyCombat)
                {
                    foreach (CombatAbility ability in enemyCombat.Abilities)
                    {
                        abilities.Add(ability);
                    }
                }
                if (target.HasUnit && target.Unit is CharacterCombat characterCombat)
                {
                    foreach (CombatAbility ability in characterCombat.CombatAbilities)
                    {
                        abilities.Add(ability);
                    }
                }
            }
            if (abilities.Count > 0)
            {
                int index = UnityEngine.Random.Range(0, abilities.Count);
                AbilitySO abilityPerform = abilities[index].ability;
                CombatManager.Instance.AddSubAction(new ShowAttackInformationUIAction(caster.ID, caster.IsUnitCharacter, abilityPerform.GetAbilityLocData().text));
                CombatManager.Instance.AddSubAction(new PlayAbilityAnimationAction(abilityPerform.visuals, abilityPerform.animationTarget, caster));
                CombatManager.Instance.AddSubAction(new EffectAction(abilityPerform.effects, caster));
                exitAmount++;
            }

            return exitAmount > 0;
        }
    }
}
