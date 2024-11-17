using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace Hell_Island_Fell.Damage_Types
{
    public class DisappearingDamage
    {
        public static void Add()
        {
            var damageId = "Disappearing_Damage";

            LoadedDBsHandler.CombatDB.AddNewSound(damageId, "event:/Combat/StatusEffects/SE_Divine_Trg");
            TMP_ColorGradient disappearingGradient = ScriptableObject.CreateInstance<TMP_ColorGradient>();
            disappearingGradient.topLeft = Color.yellow;
            disappearingGradient.topRight = Color.gray;
            disappearingGradient.bottomLeft = Color.gray;
            disappearingGradient.bottomRight = Color.yellow;

            LoadedDBsHandler.CombatDB.AddNewTextColor(damageId, disappearingGradient);
        }
    }
}
