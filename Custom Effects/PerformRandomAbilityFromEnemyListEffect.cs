using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class PerformRandomAbilityFromEnemyListEffect : EffectSO
    {
        public List<string> enemies = [];
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<EnemyAbilityInfo> abilities = [];
            foreach (string enemy in enemies)
            {
                foreach (EnemyAbilityInfo ability in LoadedAssetsHandler.GetEnemy(enemy).abilities)
                {
                    abilities.Add(ability);
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
