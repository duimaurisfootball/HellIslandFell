using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Field_Effects
{
    public class Fields
    {
        public static void Add()
        {
            if (!LoadedDBsHandler.StatusFieldDB.FieldEffects.ContainsKey("Thunderstorm_ID"))
            {
                SlotStatusEffectInfoSO ThunderstormInfo = ScriptableObject.CreateInstance<SlotStatusEffectInfoSO>();
                ThunderstormInfo.icon = ResourceLoader.LoadSprite("Thunderstorm");
                ThunderstormInfo._fieldName = "Thunderstorm";
                ThunderstormInfo._description = "Damage dealt and received will be increased by 1 for each Thunderstorm.\nDying in the Thunderstorm will transfer the Thunderstorm to whatever killed them.\nIf Thunderstorm is created in a new position, all of it will move to that position.";

                LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("OnFire_ID", out FieldEffect_SO fire);
                SlotStatusEffectInfoSO baseinfo = fire.EffectInfo;

                ThunderstormInfo._applied_SE_Event = baseinfo._applied_SE_Event;
                ThunderstormInfo._removed_SE_Event = baseinfo._removed_SE_Event;
                ThunderstormInfo._updated_SE_Event = baseinfo._updated_SE_Event;

                GameObject ThunderstormEnemy = Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ThunderstormAssetBundle/ThunderstormEnemy.prefab");
                ThunderstormInfo.m_EnemyLayoutTemplate = ThunderstormEnemy.GetComponent<EnemyFieldEffectLayout>();

                GameObject ThunderstormCharacters = Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ThunderstormAssetBundle/ThunderstormCharacter.prefab");
                ThunderstormInfo.m_CharacterLayoutTemplate = ThunderstormCharacters.GetComponent<CharacterFieldEffectLayout>();

                Thunderstorm thunderstorm = ScriptableObject.CreateInstance<Thunderstorm>();
                thunderstorm._FieldID = "Thunderstorm_ID";
                thunderstorm._EffectInfo = ThunderstormInfo;

                LoadedDBsHandler.StatusFieldDB.AddNewFieldEffect(thunderstorm, true);

                IntentInfoBasic ThunderstormIntent = new()
                {
                    _color = Color.white,
                    _sprite = ResourceLoader.LoadSprite("Thunderstorm")
                };
                LoadedDBsHandler.IntentDB.AddNewBasicIntent("Field_Thunderstorm", ThunderstormIntent);

                IntentInfoBasic ThunderstormRemIntent = new()
                {
                    _color = Color.gray,
                    _sprite = ResourceLoader.LoadSprite("Thunderstorm")
                };
                LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Field_Thunderstorm", ThunderstormRemIntent);
            }
        }
    }
}
