using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Sauerkraut
    {
        public static void Add()
        {
            GenerateColorManaEffect BlueGenerate = ScriptableObject.CreateInstance<GenerateColorManaEffect>();
            BlueGenerate.mana = Pigments.Blue;

            MultiCustomTriggerEffectItem sauerkraut = new MultiCustomTriggerEffectItem("Sauerkraut_ID")
            {
                Item_ID = "Sauerkraut_SW",
                Name = "Sauerkraut",
                Flavour = "\"Extra blue pigment. Tastes just how it sounds.\"",
                Description = "Upon lucky pigment triggering, produce an additional blue pigment.",
                IsShopItem = true,
                ShopPrice = 2,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ShopSauerkraut"),
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentSuccess,
                        effects =
                        [
                            Effects.GenerateEffect(BlueGenerate, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                ]
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(sauerkraut.Item);
        }
    }
}
