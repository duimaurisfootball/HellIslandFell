using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Passives
{
    internal class BootPassiveAbility : BasePassiveAbilitySO
    {
        public override bool IsPassiveImmediate => false;

        public override bool DoesPassiveTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            IUnit unit = sender as IUnit;
            if (args is StringReference stringReference)
            {
                unit.UnforgetAbilities();
                unit.ForgetAbility(stringReference.value);
            }
        }

        public override void OnPassiveConnected(IUnit unit)
        {
        }

        public override void OnPassiveDisconnected(IUnit unit)
        {
            unit.UnforgetAbilities();
        }
    }
}
