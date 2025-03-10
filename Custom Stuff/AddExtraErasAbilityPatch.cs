using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    [HarmonyPatch]
    public class AddExtraErasAbilityPatch
    {
        [HarmonyPatch(typeof(RunDataSO), nameof(RunDataSO.SetInitialCharacters))]
        [HarmonyPostfix]
        public static void AddExtraErasAbility(RunDataSO __instance)
        {
            foreach (var ch in __instance.playerData._characterList)
            {
                if (ch == null)
                {
                    continue;
                }
                if (ch.Character is not ErasCharacterSO)
                {
                    continue;
                }

                ch.UsedAbilities.Insert(0, 3);
                ch.UpdateCurrentAbilities();
            }
        }
    }
}
