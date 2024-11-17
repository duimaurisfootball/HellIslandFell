using BrutalAPI;
using Hell_Island_Fell.Status_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEngine.TouchScreenKeyboard;
using static UnityEngine.UI.CanvasScaler;

namespace Hell_Island_Fell.Custom_Passives
{
    public class InterpolatedPassiveAbility : BasePassiveAbilitySO
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
            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);

            if (args is not DamageReceivedValueChangeException ex || ex.damageTypeID == "Disappearing_Damage")
            {
                return;
            }

            if (sender is not IUnit unit)
            {
                return;
            }

            ex.AddModifier(new DisappearingIntValueModifier(unit, Disappearing));
        }

        public class DisappearingIntValueModifier(IUnit attackedUnit, StatusEffect_SO disappearingStatus) : IntValueModifier(105)
        {
            public override int Modify(int value)
            {
                return value > 0 && attackedUnit != null && disappearingStatus != null && attackedUnit.ApplyStatusEffect(disappearingStatus, value, 0) ? 0 : value;
            }
        }

        public class InterpolationCondition : EffectorConditionSO
        {
            public override bool MeetCondition(IEffectorChecks effector, object args)
            {
                return args is DamageReceivedValueChangeException ex && ex.damageTypeID != "Disappearing_Damage";
            }
        }
    }
}
