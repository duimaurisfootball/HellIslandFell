using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class ShadowHandsSwap(IUnit unit, string swapTypeID) : IImmediateAction
    {
        public IUnit _unit = unit;

        public string _swapTypeID = swapTypeID;

        public void Execute(CombatStats stats)
        {
            if (_unit.IsUnitCharacter)
            {
                int num = (UnityEngine.Random.Range(0, 2) * 2) - 1;
                if (_unit.SlotID + num >= 0 && _unit.SlotID + num < stats.combatSlots.CharacterSlots.Length)
                {
                    stats.combatSlots.SwapCharacters(_unit.SlotID, _unit.SlotID + num, isMandatory: true, _swapTypeID);
                    return;
                }
                num *= -1;
                if (_unit.SlotID + num >= 0 && _unit.SlotID + num < stats.combatSlots.CharacterSlots.Length)
                {
                    stats.combatSlots.SwapCharacters(_unit.SlotID, _unit.SlotID + num, isMandatory: true, _swapTypeID);
                }
                return;
            }
            int num2 = (UnityEngine.Random.Range(0, 2) * (_unit.Size + 1)) - 1;
            if (stats.combatSlots.CanEnemiesSwap(_unit.SlotID, _unit.SlotID + num2, out var firstSlotSwap, out var secondSlotSwap))
            {
                stats.combatSlots.SwapEnemies(_unit.SlotID, firstSlotSwap, _unit.SlotID + num2, secondSlotSwap, isMandatory: true, _swapTypeID);
                return;
            }
            num2 = (num2 < 0) ? _unit.Size : (-1);
            if (stats.combatSlots.CanEnemiesSwap(_unit.SlotID, _unit.SlotID + num2, out firstSlotSwap, out secondSlotSwap))
            {
                stats.combatSlots.SwapEnemies(_unit.SlotID, firstSlotSwap, _unit.SlotID + num2, secondSlotSwap, isMandatory: true, _swapTypeID);
            }
        }
    }
}
