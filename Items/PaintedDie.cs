using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class PaintedDie
    {
        public static void Add()
        {
            RandomizeAllManaEffect RandomizePigment = ScriptableObject.CreateInstance<RandomizeAllManaEffect>();
            RandomizePigment.manaRandomOptions = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple];

            MultiCustomTriggerEffectItem paintedDie = new MultiCustomTriggerEffectItem("PaintedDie_ID")
            {
                Item_ID = "PaintedDie_SW",
                Name = "Painted Die",
                Flavour = "\"Loaded if you're colorblind.\"",
                Description = "Upon lucky pigment triggering, randomize all stored pigment.",
                IsShopItem = true,
                ShopPrice = 4,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ShopPaintedDie"),
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentSuccess,
                        effects =
                        [
                            Effects.GenerateEffect(RandomizePigment, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                ]
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(paintedDie.Item, new ItemModdedUnlockInfo(paintedDie.Item_ID, ResourceLoader.LoadSprite("ShopPaintedDie")));
        }
    }
}
