using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RerollNumberPigmentEffect : EffectSO
    {
        public ManaColorSO _mana;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            var slots = new List<int>();
            var manaBar = stats.MainManaBar.ManaBarSlots;
            for (var i = 0; i < manaBar.Length; i++)
            {
                var slot = manaBar[i];
                if (slot != null && !slot.IsEmpty && slot.ManaColor != _mana)
                {
                    slots.Add(i);
                }
            }
            var slotsToTransform = new List<int>();
            var pigments = new List<ManaColorSO>();
            while (slots.Count > 0 && slotsToTransform.Count < entryVariable)
            {
                var idx = UnityEngine.Random.Range(0, slots.Count);
                slotsToTransform.Add(slots[idx]);
                stats.MainManaBar.ManaBarSlots[slots[idx]].SetMana(_mana);
                slots.RemoveAt(idx);
                pigments.Add(_mana);
                exitAmount++;
            }
            if (slotsToTransform.Count > 0)
            {
                CombatManager.Instance.AddUIAction(new ModifyManaSlotsUIAction(stats.MainManaBar.ID, [.. slotsToTransform], [.. pigments]));
            }
            return exitAmount > 0;
        }
    }
}
