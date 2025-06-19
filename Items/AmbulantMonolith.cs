using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class AmbulantMonolith
    {
        public static void Add()
        {
            HealEffect PercentHeal = ScriptableObject.CreateInstance<HealEffect>();
            PercentHeal.entryAsPercentage = true;

            PerformEffectNegativePositiveStatusEffectApplyBlock_Item ambulantMonolith = new PerformEffectNegativePositiveStatusEffectApplyBlock_Item("AmbulantMonolith_ID", null, false)
            {
                Item_ID = "AmbulantMonolith_TW",
                Name = "Ambulant Monolith",
                Flavour = "\"It's perfectly smooth on all sides.\"",
                Description = "Prevent all positive status effects. Upon preventing a status effect, heal this party member 40% of their max health.",
                IsShopItem = false,
                ShopPrice = 7,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("TreasureAmbulantMonolith"),
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<PopUpCasterItemInfoEffect>()),
                    Effects.GenerateEffect(PercentHeal, 40, Targeting.Slot_SelfSlot),
                ],
                IsStatusPositive = true,
            };

            ambulantMonolith.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(ambulantMonolith.Item, new ItemModdedUnlockInfo("AmbulantMonolith_TW", ResourceLoader.LoadSprite("TreasureAmbulantMonolithLocked", null, 32, null), "HIF_Nevermore_Comedy_ACH"));
        }
    }
}
