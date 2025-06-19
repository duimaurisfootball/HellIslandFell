using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class AppleCiderVinegar
    {
        public static void Add()
        {
            GenerateColorManaEffect YellowGenerate = ScriptableObject.CreateInstance<GenerateColorManaEffect>();
            YellowGenerate.mana = Pigments.Yellow;

            MultiCustomTriggerEffectItem appleCiderVinegar = new MultiCustomTriggerEffectItem("AppleCiderVinegar_ID")
            {
                Item_ID = "AppleCiderVinegar_SW",
                Name = "Apple Cider Vinegar",
                Flavour = "\"Extra yellow pigment. With the mother!\"",
                Description = "Upon lucky pigment triggering, produce an additional yellow pigment.",
                IsShopItem = true,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ShopAppleCiderVinegar"),
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentSuccess,
                        effects =
                        [
                            Effects.GenerateEffect(YellowGenerate, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                ]
            };

            appleCiderVinegar.item._ItemTypeIDs =
                [
                    "FoodID",
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(appleCiderVinegar.Item, new ItemModdedUnlockInfo(appleCiderVinegar.Item_ID, ResourceLoader.LoadSprite("ShopAppleCiderVinegar")));
        }
    }
}
