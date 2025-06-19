using HarmonyLib;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.UI.CanvasScaler;

namespace Hell_Island_Fell.Custom_Passives
{
    public class TargetedStatusEffectPassive : BasePassiveAbilitySO
    {
        public override bool IsPassiveImmediate => true;
        public override bool DoesPassiveTrigger => true;

        public BaseCombatTargettingSO targeting;
        public StatusEffect_SO status;
        public UnitStoreData_BasicSO affectedUnitsStoredValue;

        public override void OnPassiveConnected(IUnit unit)
        {
            CombatManager.Instance.AddSubAction(new TargetedStatusEffectConnectedAction(unit, this, targeting, GetAffectedUnits(unit), status));
        }

        public override void OnPassiveDisconnected(IUnit unit)
        {
            CombatManager.Instance.AddSubAction(new TargetedStatusEffectDisconnectedAction(GetAffectedUnits(unit), status));
        }

        public List<IUnit> GetAffectedUnits(IUnit owner)
        {
            if (owner == null)
            {
                return [];
            }

            owner.TryGetStoredData(affectedUnitsStoredValue._UnitStoreDataID, out var hold);
            if (hold.m_ObjectData is not List<IUnit> l)
            {
                hold.m_ObjectData = l = [];
            }

            return l;
        }

        public override void CustomOnTriggerAttached(IPassiveEffector caller)
        {
            CombatManager.Instance.AddObserver(TryTriggerPassive, "Dui_Mauris_Football.HIF_AnyoneMoved", caller);
        }

        public override void TriggerPassive(object sender, object args)
        {
            if (sender is not IUnit caster || args is not AnyoneMovedNotificationInfo notifinfo || notifinfo.unit == null)
            {
                return;
            }

            CombatManager.Instance.ProcessImmediateAction(new TargetedStatusEffectMoveAction(caster, targeting, GetAffectedUnits(caster), status));
        }

        public override void CustomOnTriggerDettached(IPassiveEffector caller)
        {
            CombatManager.Instance.RemoveObserver(TryTriggerPassive, "Dui_Mauris_Football.HIF_AnyoneMoved", caller);
        }
    }

    public class TargetedStatusEffectConnectedAction(IUnit caster, BasePassiveAbilitySO passive, BaseCombatTargettingSO targeting, List<IUnit> affectedUnits, StatusEffect_SO status) : CombatAction
    {
        public override IEnumerator Execute(CombatStats stats)
        {
            var valid = caster.IsUnitCharacter
                ? stats.CharactersOnField.ContainsKey(caster.ID) && stats.CharactersOnField[caster.ID] == caster
                : stats.EnemiesOnField.ContainsKey(caster.ID) && stats.EnemiesOnField[caster.ID] == caster;

            if (!valid)
            {
                yield break;
            }

            var showPassiveInformation = new ShowPassiveInformationUIAction(caster.ID, caster.IsUnitCharacter, passive._passiveName, passive.passiveIcon);
            yield return showPassiveInformation.Execute(stats);

            var targets = targeting.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);
            foreach (var t in targets)
            {
                if (t == null || !t.HasUnit)
                {
                    continue;
                }

                if (affectedUnits.Contains(t.Unit))
                {
                    continue;
                }

                t.Unit.ApplyStatusEffect(status, 0, 1);
                affectedUnits.Add(t.Unit);
            }
        }
    }

    public class TargetedStatusEffectDisconnectedAction(List<IUnit> affectedUnits, StatusEffect_SO status) : CombatAction
    {
        public override IEnumerator Execute(CombatStats stats)
        {
            foreach (var u in affectedUnits)
            {
                if (u == null)
                {
                    continue;
                }

                u.DettachStatusRestrictor(status.StatusID);
            }

            affectedUnits.Clear();
            yield break;
        }
    }

    public class TargetedStatusEffectMoveAction(IUnit caster, BaseCombatTargettingSO targeting, List<IUnit> affectedUnits, StatusEffect_SO status) : IImmediateAction
    {
        public void Execute(CombatStats stats)
        {
            var targets = targeting.GetTargets(CombatManager.Instance._stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);

            for (var i = 0; i < affectedUnits.Count; i++)
            {
                var u = affectedUnits[i];

                if (targets.Any(x => x != null && x.Unit == u))
                {
                    continue;
                }

                u.DettachStatusRestrictor(status.StatusID);
                affectedUnits.RemoveAt(i);
                i--;
            }

            foreach (var t in targets)
            {
                if (t == null || !t.HasUnit)
                {
                    continue;
                }

                var u = t.Unit;

                if (affectedUnits.Contains(u))
                {
                    continue;
                }

                u.ApplyStatusEffect(status, 0, 1);
                affectedUnits.Add(u);
            }
        }
    }
}
