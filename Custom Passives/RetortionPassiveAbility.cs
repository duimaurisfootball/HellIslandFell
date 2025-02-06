using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Passives
{
    public class RetortionPassiveAbility : BasePassiveAbilitySO
    {
        public override bool IsPassiveImmediate => false;

        public override bool DoesPassiveTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            IUnit unit = sender as IUnit;
            CombatManager.Instance.ProcessImmediateAction(new RetortionTriggeredAction(unit.ID, unit.IsUnitCharacter));
        }

        public override void OnPassiveConnected(IUnit unit)
        {
        }

        public override void OnPassiveDisconnected(IUnit unit)
        {
        }
    }
}
