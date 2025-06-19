using System.Collections.Generic;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AbilitySelector_Vus : BaseAbilitySelectorSO
    {

        public int _useAfterTurns;

        public string _InitalBlockedAbility;

        public string _TurnsIncreaseAbility;
        public override bool UsesRarity => true;

        public override int GetNextAbilitySlotUsage(List<CombatAbility> abilities, IUnit unit)
        {
            IntegerReference CurrentTurn_IntRef = new IntegerReference(-1);
            CombatManager.Instance.ProcessImmediateAction(new CheckPlayerTurnCountIAction(CurrentTurn_IntRef));

            int MaxRoll = 0;
            List<int> ApprovedAbilIDs = [];
            for (int i = 0; i < abilities.Count; i++)
            {
                if (abilities[i].ability.name == _InitalBlockedAbility)
                {
                    if (CurrentTurn_IntRef.value > _useAfterTurns)
                    {
                        MaxRoll += abilities[i].rarity.rarityValue;
                        ApprovedAbilIDs.Add(i);
                    }
                }
                else if (abilities[i].ability.name == _TurnsIncreaseAbility)
                {
                    if (CurrentTurn_IntRef.value > 0)
                    {
                        MaxRoll += CurrentTurn_IntRef.value;
                        ApprovedAbilIDs.Add(i);
                    }
                }
                else
                {
                    MaxRoll += abilities[i].rarity.rarityValue;
                    ApprovedAbilIDs.Add(i);
                }
            }

            int Roll = UnityEngine.Random.Range(0, MaxRoll);
            int CurrentCheck = 0;
            foreach (int i in ApprovedAbilIDs)
            {
                if (abilities[i].ability.name == _TurnsIncreaseAbility)
                {
                    CurrentCheck += CurrentTurn_IntRef.value;
                }
                else
                {
                    CurrentCheck += abilities[i].rarity.rarityValue;
                }

                if (CurrentCheck > Roll)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
