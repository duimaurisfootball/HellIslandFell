using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class CustomAbilityPriority
    {
        public static Dictionary<int, PrioritySO> Priority_DB = [];

        public static PrioritySO Weight(int Value)
        {
            //Check if we have already created a PrioritySO with the desired value.
            if (Priority_DB.ContainsKey(Value))
            {
                Priority_DB.TryGetValue(Value, out PrioritySO rarity);
                return rarity;
            }

            //Because we could not give a pre-existing PrioritySO we will make a new one.
            PrioritySO NewPriority = ScriptableObject.CreateInstance<PrioritySO>();
            NewPriority.priorityValue = Value;

            Priority_DB.Add(Value, NewPriority);

            return NewPriority;
        }

        public static Ability[] AutoSprite(Ability[] abils)
        {
            foreach (Ability a in abils)
            {
                a.AbilitySprite = LoadedAssetsHandler.GetEnemyAbility("Bash_A").abilitySprite;
            }

            return abils;
        }
    }
}

