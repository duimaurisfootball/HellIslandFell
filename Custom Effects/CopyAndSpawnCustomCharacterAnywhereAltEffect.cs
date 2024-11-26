using HarmonyLib;
using Hell_Island_Fell.Wearable_Modifiers;
using System;
using System.Collections.Generic;
using System.Text;
using Tools;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CopyAndSpawnCustomCharacterAnywhereAltEffect : EffectSO
    {
        [Header("Rank Data")]
        [CharacterRef]
        public string _characterCopy = "";

        public int _rank;

        public NameAdditionLocID _nameAddition;

        public bool _permanentSpawn;

        public WearableStaticModifierSetterSO[] _extraModifiers;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            CharacterSO character = LoadedAssetsHandler.GetCharacter(_characterCopy);
            if (character == null || character.Equals(null))
            {
                return false;
            }

            MaxHealthSet_Wearable_SMS HealthSet = CreateInstance<MaxHealthSet_Wearable_SMS>();
            HealthSet.maxHealth = PreviousExitValue;

            for (int j = 0; j < entryVariable; j++)
            {

                int[] usedAbilities = character.GenerateAbilities();
                WearableStaticModifiers modifiers = new WearableStaticModifiers();
                WearableStaticModifierSetterSO[] extraModifiers = _extraModifiers;
                for (int i = 0; i < extraModifiers.Length; i++)
                {
                    extraModifiers[i].OnAttachedToCharacter(modifiers, character, _rank);
                }
                HealthSet.OnAttachedToCharacter(modifiers, character, _rank);

                string nameAdditionData = LocUtils.GameLoc.GetNameAdditionData(_nameAddition);
                CombatManager.Instance.AddSubAction(new SpawnCharacterAction(character, -1, trySpawnAnyways: false, nameAdditionData, _permanentSpawn, _rank, usedAbilities, PreviousExitValue, modifiers));
            }

            exitAmount = entryVariable;
            return true;
        }
    }
}
