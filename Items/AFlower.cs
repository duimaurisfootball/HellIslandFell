using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class AFlower
    {
        public static void Add()
        {
            UnitStoreData_ModIntSO flowerValue = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            flowerValue.m_Text = "flower error {0}";
            flowerValue._UnitStoreDataID = "FlowerStoredValue";
            flowerValue.m_TextColor = Color.red;
            flowerValue.m_CompareDataToThis = 0;
            flowerValue.m_ShowIfDataIsOver = false;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("FlowerStoredValue", flowerValue);

            PercentageEffectorCondition thirtyPercent = ScriptableObject.CreateInstance<PercentageEffectorCondition>();
            thirtyPercent.triggerPercentage = 30;

            StoredValueSetOnceEffectorCondition workOnce = ScriptableObject.CreateInstance<StoredValueSetOnceEffectorCondition>();
            workOnce.m_unitStoredDataID = "FlowerStoredValue";

            AnyoneMoved_Item aFlower = new AnyoneMoved_Item("AFlower_ID", null, null, false)
            {
                Item_ID = "AFlower_TW",
                Name = "A Flower",
                Flavour = "\"Quiet I said\"",
                Description = "Upon any party member or enemy moving, there is a 30% chance to deal 30 damage to them.\nOnly activates once per battle.",
                IsShopItem = false,
                ShopPrice = 0,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.Count,
                Icon = ResourceLoader.LoadSprite("TreasureAFlower"),
                Effects =
                [
                    
                ],
                MoveTargetEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 30, null),
                ],
                MoveConditions =
                [
                    thirtyPercent,
                    workOnce,
                ],
            };
            
            aFlower.item._ItemTypeIDs =
                [
                    
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(aFlower.Item, new ItemModdedUnlockInfo(aFlower.Item_ID, ResourceLoader.LoadSprite("TreasureAFlower")));
        }
    }
}
