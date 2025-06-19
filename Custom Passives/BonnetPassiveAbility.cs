using System;
using System.Collections.Generic;
using System.Text;
using static UnityEngine.UI.CanvasScaler;

namespace Hell_Island_Fell.Custom_Passives
{
    public class BonnetPassiveAbility : BasePassiveAbilitySO
    {
        public override bool IsPassiveImmediate => false;
        public override bool DoesPassiveTrigger => true;

        public override void OnPassiveConnected(IUnit unit)
        {
            CombatManager.Instance.AddSubAction(new ConfusionConnectedAction(unit.ID, false, GetPassiveLocData().text, passiveIcon));
        }

        public override void OnPassiveDisconnected(IUnit unit)
        {
            CombatManager.Instance.AddSubAction(new ConfusionDisconnectedAction(unit.ID, false, GetPassiveLocData().text, passiveIcon));
        }

        public override void TriggerPassive(object sender, object args)
        {
            if (sender is not IUnit unit)
            {
                return;
            }

            if (unit.SlotID == 0 && CombatManager.Instance._stats.timeline.IsConfused)
            {
                CombatManager.Instance.AddSubAction(new ConfusionDisconnectedAction(unit.ID, false, GetPassiveLocData().text, passiveIcon));
            }
            else if (unit.SlotID != 0 && !CombatManager.Instance._stats.timeline.IsConfused)
            {
                CombatManager.Instance.AddSubAction(new ConfusionConnectedAction(unit.ID, false, GetPassiveLocData().text, passiveIcon));
            }
        }
    }
}
