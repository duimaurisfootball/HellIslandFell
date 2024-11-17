using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class DamageReceivedPercentageModifierEffect_Item : BaseItem
    {
        public PercDmgModifierSetterByReceivedDamageTypePerformEffectWearable item;

        public override BaseWearableSO Item => item;

        public EffectInfo[] Effects
        {
            get => item._effects;
            set => item._effects = value;
        }

        public TriggerCalls EffectsTrigger
        {
            get => item._effectsTrigger;
            set => item._effectsTrigger = value;
        }

        public bool DoesIncreaseDirectDamage
        {
            set => item._doesIncreaseDirect = value;
        }

        public int DirectDmgPercentageToModify
        {
            set => item._percentageToModifyDirect = value;
        }

        public bool DoesIncreaseIndirectDamage
        {
            set => item._doesIncreaseIndirect = value;
        }

        public int IndirectDmgPercentageToModify
        {
            set => item._percentageToModifyIndirect = value;
        }

        public DamageReceivedPercentageModifierEffect_Item(string itemID = "DefaultID_Item", EffectInfo[] effects = null, int directPerc = 25, bool doesIncreaseDirectDmg = false, int indirectPerc = 25, bool doesIncreaseIndirectDmg = false)
        {
            item = ScriptableObject.CreateInstance<PercDmgModifierSetterByReceivedDamageTypePerformEffectWearable>();
            item._effects = effects;
            item._percentageToModifyDirect = directPerc;
            item._doesIncreaseDirect = doesIncreaseDirectDmg;
            item._percentageToModifyIndirect = indirectPerc;
            item._doesIncreaseIndirect = doesIncreaseIndirectDmg;
            InitializeItemData(itemID);
        }
    }
}
