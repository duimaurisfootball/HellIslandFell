using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Sundial
    {
        public static void Add()
        {
            UnitStoreData_ModIntSO sundialValue = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            sundialValue.m_Text = "Sundial Damage Bonus: {0}%";
            sundialValue._UnitStoreDataID = "SundialStoredValue";
            sundialValue.m_TextColor = Color.yellow;
            sundialValue.m_CompareDataToThis = 0;
            sundialValue.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("SundialStoredValue", sundialValue);

            Sundial_Item sundial = new Sundial_Item("Sundial_ID")
            {
                Item_ID = "Sundial_SW",
                Name = "Sundial",
                Flavour = "\"Backwards, tilted, and upside-down.\"",
                Description = "Healing received is prevented and turned into a percentage damage bonus.",
                IsShopItem = true,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ShopSundial"),
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(sundial.Item, new ItemModdedUnlockInfo(sundial.Item_ID, ResourceLoader.LoadSprite("ShopSundial")));
        }
    }
}
