using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Passives
{
    public class InvinciblePassiveAbility : BasePassiveAbilitySO
    {
        public int _limit = 1;

        public override bool IsPassiveImmediate => true;

        public override bool DoesPassiveTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            if (args is not DamageReceivedValueChangeException ex)
            {
                return;
            }

            if (sender is not IUnit unit)
            {
                return;
            }

            ex.AddModifier(new InvincibleIntValueModifier(unit, _limit));
        }

        public override void OnPassiveConnected(IUnit unit)
        {
        }

        public override void OnPassiveDisconnected(IUnit unit)
        {
        }

        public class InvincibleIntValueModifier(IUnit attackedUnit, int limit) : IntValueModifier(100)
        {
            public override int Modify(int value)
            {
                return value > 0 && attackedUnit != null && value > limit ? value : 0;
            }
        }
    }
}
