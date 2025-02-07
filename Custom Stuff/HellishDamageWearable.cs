using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class HellishDamageWearable : BaseWearableSO
    {
        [Header("Multiplier Data")]
        public bool _useDealt;

        public bool _useSimpleInt;

        public int _toAdd0 = 9;

        public int _toAdd1 = 2;

        public override bool IsItemImmediate => true;

        public override bool DoesItemTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            if (args is DamageDealtValueChangeException context)
            {
                if (context.damagedUnit.UnitTypes.Contains("HellishID"))
                {
                    if (_useSimpleInt)
                    {
                        if (args is IntValueChangeException ex && !ex.Equals(null))
                        {
                            ex.AddModifier(new BasicFlatValueModifier(true, _toAdd0, true));
                        }
                    }
                    else if (_useDealt)
                    {
                        if (args is DamageDealtValueChangeException ex2 && !ex2.Equals(null))
                        {
                            ex2.AddModifier(new BasicFlatValueModifier(true, _toAdd0, true));
                        }
                    }
                    else if (args is DamageReceivedValueChangeException ex3 && !ex3.Equals(null))
                    {
                        ex3.AddModifier(new BasicFlatValueModifier(true, _toAdd0, true));
                    }
                }
                if (!context.damagedUnit.UnitTypes.Contains("HellishID"))
                {
                    if (_useSimpleInt)
                    {
                        if (args is IntValueChangeException ex && !ex.Equals(null))
                        {
                            ex.AddModifier(new BasicFlatValueModifier(true, _toAdd1, false));
                        }
                    }
                    else if (_useDealt)
                    {
                        if (args is DamageDealtValueChangeException ex2 && !ex2.Equals(null))
                        {
                            ex2.AddModifier(new BasicFlatValueModifier(true, _toAdd1, false));
                        }
                    }
                    else if (args is DamageReceivedValueChangeException ex3 && !ex3.Equals(null))
                    {
                        ex3.AddModifier(new BasicFlatValueModifier(true, _toAdd1, false));
                    }
                }
            }
        }
        public class BasicFlatValueModifier(bool dmgDealt, int amount, bool increase) : IntValueModifier(dmgDealt ? 4 : 62)
        {
            public override int Modify(int value)
            {
                if (!increase)
                {
                    return Mathf.Max(0, value + amount);
                }
                return value + amount;
            }
        }
    }
}
