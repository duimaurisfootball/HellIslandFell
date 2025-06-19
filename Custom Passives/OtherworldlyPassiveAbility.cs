using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Passives
{
    public class OtherworldlyPassiveAbility : BasePassiveAbilitySO
    {
        public override bool IsPassiveImmediate => true;
        public override bool DoesPassiveTrigger => true;

        public override void OnPassiveConnected(IUnit unit)
        {

        }

        public override void OnPassiveDisconnected(IUnit unit)
        {

        }

        public override void TriggerPassive(object sender, object args)
        {
            if (args is not DamageReceivedValueChangeException ex)
            {
                return;
            }

            if (sender is not EnemyCombat unit)
            {
                return;
            }

            bool fieldFilled = false;
            CombatSlot[] EnemySlots = CombatManager.Instance._stats.combatSlots.EnemySlots;
            foreach (CombatSlot slot in EnemySlots)
            {
                if (!slot.HasUnit)
                {
                    fieldFilled = true;
                }
            }

            IUnit caster = sender as IUnit;
            if (ex.amount > 0)
            {
                CombatManager.Instance.AddSubAction(new ShowPassiveInformationUIAction(caster.ID, caster.IsUnitCharacter, "Otherworldly", Passives.Overexert1.passiveIcon));
                if (fieldFilled)
                {
                    CombatManager.Instance.AddSubAction(new SpawnEnemyAction(unit.Enemy, -1, true, false, CombatType_GameIDs.Spawn_Basic.ToString(), ex.amount));
                }
                else
                {
                    EffectInfo[] effects =
                    [
                        Effects.GenerateEffect(CreateInstance<ChangeWeakestMaxHealth>(), ex.amount, Targeting.Unit_OtherAllies),
                        Effects.GenerateEffect(CreateInstance<HealWeakestEffect>(), ex.amount, Targeting.Unit_OtherAllies),
                    ];
                    CombatManager.Instance.AddSubAction(new EffectAction(effects, caster));
                }
                ex.ShouldIgnoreUI = true;
            }
        }

        public class OtherworldlyCondition : EffectorConditionSO
        {
            public override bool MeetCondition(IEffectorChecks effector, object args)
            {
                return args is DamageReceivedValueChangeException ex && ex.directDamage && ex.amount < effector.CurrentHealth;
            }
        }
    }
}
