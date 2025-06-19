using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class AlumSalt
    {
        public static void Add()
        {
            GenerateColorManaEffect PurpleGenerate = ScriptableObject.CreateInstance<GenerateColorManaEffect>();
            PurpleGenerate.mana = Pigments.Purple;

            MultiCustomTriggerEffectItem alumSalt = new MultiCustomTriggerEffectItem("AlumSalt_ID")
            {
                Item_ID = "AlumSalt_SW",
                Name = "Alum Salt",
                Flavour = "\"Extra purple pigment. Astringent, dries your mouth out.\"",
                Description = "Upon lucky pigment triggering, produce an additional purple pigment.",
                IsShopItem = true,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ShopAlumSalt"),
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentSuccess,
                        effects =
                        [
                            Effects.GenerateEffect(PurpleGenerate, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                ]
            };

            alumSalt.item._ItemTypeIDs =
                [
                    "FoodID",
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(alumSalt.Item, new ItemModdedUnlockInfo(alumSalt.Item_ID, ResourceLoader.LoadSprite("ShopAlumSalt")));
        }
    }
}
