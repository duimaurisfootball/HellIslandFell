using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    [HarmonyPatch]
    public static class LuckyPigmentTriggerPatch
    {
        public const string OnLuckyPigmentFailure = "Dui_Mauris_Football.HIF_LuckyPigmentFail";
        public const string OnLuckyPigmentSuccess = "Dui_Mauris_Football.HIF_LuckyPigmentSuccess";

        [HarmonyTargetMethod]
        private static MethodBase Method()
        {
            return AccessTools.Method(t, "MoveNext");
        }

        [HarmonyTranspiler]
        private static IEnumerable<CodeInstruction> LuckyPigmentStuff(IEnumerable<CodeInstruction> instructions)
        {
            foreach (CodeInstruction instruction in instructions)
            {
                yield return instruction;
                if (instruction.Calls(range))
                {
                    yield return new CodeInstruction(OpCodes.Ldloc_1);
                    yield return new CodeInstruction(OpCodes.Call, alpt1);
                }
                if (instruction.Calls(ama))
                {
                    yield return new CodeInstruction(OpCodes.Call, alpt2);
                }
            }
        }

        private static int AddLuckyPigmentTriggers1(int rng, int percentage)
        {
            if (rng >= percentage)
            {
                foreach (var u in CombatManager.Instance._stats.Characters)
                {
                    CombatManager.Instance.PostNotification(OnLuckyPigmentFailure, u.Value, null);
                }
                foreach (var u in CombatManager.Instance._stats.Enemies)
                {
                    CombatManager.Instance.PostNotification(OnLuckyPigmentFailure, u.Value, null);
                }
            }
            return rng;
        }

        private static int AddLuckyPigmentTriggers2(int _)
        {
            foreach (var u in CombatManager.Instance._stats.Characters)
            {
                CombatManager.Instance.PostNotification(OnLuckyPigmentSuccess, u.Value, null);
            }
            foreach (var u in CombatManager.Instance._stats.Enemies)
            {
                CombatManager.Instance.PostNotification(OnLuckyPigmentSuccess, u.Value, null);
            }
            return _;
        }

        private static Type t = AccessTools.TypeByName("AddLuckyManaAction+<Execute>d__0");
        private static MethodInfo range = AccessTools.Method(typeof(UnityEngine.Random), nameof(UnityEngine.Random.Range), [typeof(int), typeof(int)]);
        private static MethodInfo ama = AccessTools.Method(typeof(ManaBar), nameof(ManaBar.AddManaAmount));
        private static MethodInfo alpt1 = AccessTools.Method(typeof(LuckyPigmentTriggerPatch), nameof(AddLuckyPigmentTriggers1));
        private static MethodInfo alpt2 = AccessTools.Method(typeof(LuckyPigmentTriggerPatch), nameof(AddLuckyPigmentTriggers2));
    }
}
