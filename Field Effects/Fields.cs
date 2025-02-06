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
            if (!LoadedDBsHandler.StatusFieldDB.FieldEffects.ContainsKey("ShadowHands_ID"))
            {
                SlotStatusEffectInfoSO ShadowHandsInfo = ScriptableObject.CreateInstance<SlotStatusEffectInfoSO>();
                ShadowHandsInfo.icon = ResourceLoader.LoadSprite("ShadowHands");
                ShadowHandsInfo._fieldName = "Shadow Hands";
                ShadowHandsInfo._description = "Upon taking any damage or performing an ability in Shadow Hands, move to the left or right.\n1 Shadow Hands is lost upon taking damage.";

                LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("Constricted_ID", out FieldEffect_SO constricted);
                SlotStatusEffectInfoSO baseinfo = constricted.EffectInfo;

                ShadowHandsInfo._applied_SE_Event = baseinfo._applied_SE_Event;
                ShadowHandsInfo._removed_SE_Event = baseinfo._removed_SE_Event;
                ShadowHandsInfo._updated_SE_Event = baseinfo._updated_SE_Event;

                GameObject ShadowHandsEnemy = Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ShadowHandsAssetBundle/ShadowHandsEnemy.prefab");
                ShadowHandsInfo.m_EnemyLayoutTemplate = ShadowHandsEnemy.GetComponent<EnemyFieldEffectLayout>();

                GameObject ShadowHandsCharacters = Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ShadowHandsAssetBundle/ShadowHandsCharacter.prefab");
                ShadowHandsInfo.m_CharacterLayoutTemplate = ShadowHandsCharacters.GetComponent<CharacterFieldEffectLayout>();

                ShadowHands shadowHands = ScriptableObject.CreateInstance<ShadowHands>();
                shadowHands._FieldID = "ShadowHands_ID";
                shadowHands._EffectInfo = ShadowHandsInfo;

                LoadedDBsHandler.StatusFieldDB.AddNewFieldEffect(shadowHands, true);

                IntentInfoBasic ShadowHandsIntent = new()
                {
                    _color = Color.white,
                    _sprite = ResourceLoader.LoadSprite("ShadowHands")
                };
                LoadedDBsHandler.IntentDB.AddNewBasicIntent("Field_ShadowHands", ShadowHandsIntent);

                IntentInfoBasic ShadowHandsRemIntent = new()
                {
                    _color = Color.grey,
                    _sprite = ResourceLoader.LoadSprite("ShadowHands")
                };
                LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Field_ShadowHands", ShadowHandsRemIntent);
            }
        }
    }
}
