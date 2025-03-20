using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Status_Effects
{
    public class NemesisStatus : StatusEffect_SO
    {
        public override bool IsPositive => false;

        public override bool TryUseNumberOnPopUp => false;
        public override bool CanBeRemoved(StatusEffect_Holder holder)
        {
            return false;
        }
        public override string DisplayText(StatusEffect_Holder holder)
        {
            return "";
        }
        public override void OnTriggerAttached(StatusEffect_Holder holder, IStatusEffector caller)
        {
        }
        public override void OnTriggerDettached(StatusEffect_Holder holder, IStatusEffector caller)
        {
        }
        public override void OnEventCall_01(StatusEffect_Holder holder, object sender, object args)
        {
        }
        public override void ReduceDuration(StatusEffect_Holder holder, IStatusEffector effector)
        {
        }
    }
}
