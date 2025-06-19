using HarmonyLib;
using MonoMod.Cil;
using System;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using System.Reflection;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    [HarmonyPatch]
    public static class AnyoneMovedPatch
    {
        public const string ANYONE_MOVED = "Dui_Mauris_Football.HIF_AnyoneMoved";

        [HarmonyPatch(typeof(EnemyCombat), nameof(EnemyCombat.SwappedTo))]
        [HarmonyPatch(typeof(CharacterCombat), nameof(CharacterCombat.SwappedTo))]
        [HarmonyPatch(typeof(EnemyCombat), nameof(EnemyCombat.SwapTo))]
        [HarmonyPatch(typeof(CharacterCombat), nameof(CharacterCombat.SwapTo))]
        [HarmonyILManipulator]
        private static void AnyoneMoved_Transpiler(ILContext ctx)
        {
            var crs = new ILCursor(ctx);

            if (!crs.TryGotoNext(MoveType.After, x => x.MatchCallOrCallvirt<CombatManager>(nameof(CombatManager.PostNotification))))
            {
                return;
            }

            if (!crs.TryGotoNext(MoveType.After, x => x.MatchCallOrCallvirt<CombatManager>(nameof(CombatManager.PostNotification))))
            {
                return;
            }

            crs.Emit(OpCodes.Ldarg_0);
            crs.Emit(OpCodes.Ldloc_0);
            crs.Emit(OpCodes.Call, am_pn);
        }

        private static void AnyoneMoved_PostNotification(IUnit unit, int oldsid)
        {
            foreach (var kvp in CombatManager.Instance._stats.EnemiesOnField)
            {
                CombatManager.Instance.PostNotification(ANYONE_MOVED, kvp.Value, new AnyoneMovedNotificationInfo(unit, oldsid));
            }

            foreach (var kvp in CombatManager.Instance._stats.CharactersOnField)
            {
                CombatManager.Instance.PostNotification(ANYONE_MOVED, kvp.Value, new AnyoneMovedNotificationInfo(unit, oldsid));
            }
        }

        private static MethodInfo am_pn = AccessTools.Method(typeof(AnyoneMovedPatch), nameof(AnyoneMoved_PostNotification));
    }

    public class AnyoneMovedNotificationInfo(IUnit u, int oldsid)
    {
        public IUnit unit = u;
        public int oldSlotId = oldsid;
    }
}
