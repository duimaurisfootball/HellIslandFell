﻿using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using HarmonyLib;

namespace Hell_Island_Fell.Custom_Stuff
{
    [HarmonyPatch]
    public static class ModifyEntryVariablePatch
    {
        public const string ModifyEntryVariable = "Dui_Mauris_Football.HIF_ModifyEntryVariable";

        [HarmonyPatch(typeof(EffectAction), nameof(EffectAction.Execute), MethodType.Enumerator)]
        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> AddAndRemoveInfosFromList(IEnumerable<CodeInstruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ret)
                {
                    yield return new CodeInstruction(OpCodes.Ldloc_1);
                    yield return new CodeInstruction(OpCodes.Call, rfl);
                }
                if (instruction.Calls(se))
                {
                    yield return new CodeInstruction(OpCodes.Ldloc_1);
                    yield return new CodeInstruction(OpCodes.Ldarg_0);
                    yield return new CodeInstruction(OpCodes.Ldfld, i);
                    yield return new CodeInstruction(OpCodes.Call, aeitl);
                }
                yield return instruction;
                if (instruction.Calls(se))
                {
                    yield return new CodeInstruction(OpCodes.Ldloc_1);
                    yield return new CodeInstruction(OpCodes.Ldarg_0);
                    yield return new CodeInstruction(OpCodes.Ldfld, i);
                    yield return new CodeInstruction(OpCodes.Call, reifl);
                }
            }
        }

        [HarmonyPatch(typeof(EffectInfo), nameof(EffectInfo.StartEffect))]
        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> CallEntryVariableNotification(IEnumerable<CodeInstruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                yield return instruction;
                if (instruction.LoadsField(ev))
                {
                    yield return new CodeInstruction(OpCodes.Ldarg_0);
                    yield return new CodeInstruction(OpCodes.Ldarg_2);
                    yield return new CodeInstruction(OpCodes.Call, cev);
                }
            }
        }

        public static bool RemoveFromList(bool prev, EffectAction act)
        {
            if (prev == false)
            {
                act._caster.UnitExt().EffectsBeingPerformed.Remove(act);
            }
            return prev;
        }

        public static int AddEffectInfoToList(int _, EffectAction act, int effectIndex)
        {
            if (act._caster.UnitExt().EffectsBeingPerformed.Contains(act))
            {
                act._caster.UnitExt().EffectInfosBeingPerformed.Add(act._effects[effectIndex]);
            }
            return _;
        }

        public static int RemoveEffectInfoFromList(int _, EffectAction act, int effectIndex)
        {
            if (act._caster.UnitExt().EffectsBeingPerformed.Contains(act))
            {
                act._caster.UnitExt().EffectInfosBeingPerformed.Remove(act._effects[effectIndex]);
            }
            return _;
        }

        public static int ChangeEntryVariable(int orig, EffectInfo effect, IUnit caster)
        {
            if (caster.UnitExt().EffectInfosBeingPerformed.Contains(effect))
            {
                var intref = new IntegerReference(orig);
                CombatManager.Instance.PostNotification(ModifyEntryVariable, caster, intref);
                return intref.value;
            }
            return orig;
        }

        public static MethodInfo rfl = AccessTools.Method(typeof(ModifyEntryVariablePatch), nameof(RemoveFromList));

        public static FieldInfo i = AccessTools.Field(AccessTools.TypeByName("EffectAction+<Execute>d__4"), "<i>5__4");
        public static MethodInfo se = AccessTools.Method(typeof(EffectInfo), nameof(EffectInfo.StartEffect));

        public static FieldInfo ev = AccessTools.Field(typeof(EffectInfo), nameof(EffectInfo.entryVariable));
        public static MethodInfo cev = AccessTools.Method(typeof(ModifyEntryVariablePatch), nameof(ChangeEntryVariable));

        public static MethodInfo aeitl = AccessTools.Method(typeof(ModifyEntryVariablePatch), nameof(AddEffectInfoToList));
        public static MethodInfo reifl = AccessTools.Method(typeof(ModifyEntryVariablePatch), nameof(RemoveEffectInfoFromList));
    }

    [HarmonyPatch]
    public static class AddEffectsPatch
    {
        [HarmonyTranspiler]
        public static IEnumerable<CodeInstruction> AddEffectsToList(IEnumerable<CodeInstruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                yield return instruction;
                if (instruction.opcode == OpCodes.Newobj && instruction.operand is MethodBase bas && bas.DeclaringType == typeof(EffectAction))
                {
                    yield return new CodeInstruction(OpCodes.Call, atl);
                }
            }
        }

        [HarmonyTargetMethods]
        public static IEnumerable<MethodBase> Methods()
        {
            return new MethodBase[]
            {
                AccessTools.Method(typeof(CharacterCombat), nameof(CharacterCombat.UseAbility)),
                AccessTools.Method(typeof(CharacterCombat), nameof(CharacterCombat.TryPerformRandomAbility), new Type[0]),
                AccessTools.Method(typeof(CharacterCombat), nameof(CharacterCombat.TryPerformRandomAbility), [typeof(AbilitySO)]),
                AccessTools.Method(typeof(EnemyCombat), nameof(EnemyCombat.UseAbility)),
            };
        }

        public static EffectAction AddToList(EffectAction act)
        {
            act._caster.UnitExt().EffectsBeingPerformed.Add(act);
            return act;
        }

        public static MethodInfo atl = AccessTools.Method(typeof(AddEffectsPatch), nameof(AddToList));
    }

    public class CombatManagerExt : MonoBehaviour
    {
        public Dictionary<int, EnemyCombatExt> Enemies = [];
        public Dictionary<int, CharacterCombatExt> Characters = [];
    }

    public interface IUnitExt
    {
        IUnit BaseUnit { get; }
        List<EffectAction> EffectsBeingPerformed { get; }
        List<EffectInfo> EffectInfosBeingPerformed { get; }
    }

    public class CharacterCombatExt(IUnit u) : IUnitExt
    {
        public IUnit BaseUnit { get; } = u;
        public List<EffectAction> EffectsBeingPerformed { get; } = [];
        public List<EffectInfo> EffectInfosBeingPerformed { get; } = [];
    }

    public class EnemyCombatExt(IUnit u) : IUnitExt
    {
        public IUnit BaseUnit { get; } = u;
        public List<EffectAction> EffectsBeingPerformed { get; } = [];
        public List<EffectInfo> EffectInfosBeingPerformed { get; } = [];
    }

    public static class ExtTools
    {
        public static CombatManagerExt Ext(this CombatManager cm)
        {
            if (cm.GetComponent<CombatManagerExt>() != null)
            {
                return cm.GetComponent<CombatManagerExt>();
            }
            return cm.gameObject.AddComponent<CombatManagerExt>();
        }

        public static IUnitExt UnitExt(this IUnit u)
        {
            if (u is CharacterCombat cc)
            {
                return cc.Ext();
            }
            else if (u is EnemyCombat ec)
            {
                return ec.Ext();
            }
            Debug.Log("Third type! Culprit: " + u.GetType());
            return null;
        }

        public static CharacterCombatExt Ext(this CharacterCombat cc)
        {
            var ext = CombatManager.Instance.Ext();
            if (!ext.Characters.ContainsKey(cc.ID))
            {
                ext.Characters.Add(cc.ID, new(cc));
            }
            return ext.Characters[cc.ID];
        }

        public static EnemyCombatExt Ext(this EnemyCombat cc)
        {
            var ext = CombatManager.Instance.Ext();
            if (!ext.Enemies.ContainsKey(cc.ID))
            {
                ext.Enemies.Add(cc.ID, new(cc));
            }
            return ext.Enemies[cc.ID];
        }
    }
}
