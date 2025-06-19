using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class PickledBeets
    {
        public static void Add()
        {
            GenerateColorManaEffect RedGenerate = ScriptableObject.CreateInstance<GenerateColorManaEffect>();
            RedGenerate.mana = Pigments.Red;

            MultiCustomTriggerEffectItem pickledBeets = new MultiCustomTriggerEffectItem("PickledBeets_ID")
            {
                Item_ID = "PickledBeets_SW",
                Name = "Pickled Beets",
                Flavour = "\"Extra red pigment. Stains redder than red.\"",
                Description = "Upon lucky pigment triggering, produce an additional red pigment.",
                IsShopItem = true,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ShopPickledBeets"),
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentSuccess,
                        effects =
                        [
                            Effects.GenerateEffect(RedGenerate, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                ]
            };

            pickledBeets.item._ItemTypeIDs =
                [
                    "FoodID",
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(pickledBeets.Item, new ItemModdedUnlockInfo(pickledBeets.Item_ID, ResourceLoader.LoadSprite("ShopPickledBeets")));
        }
    }
}
