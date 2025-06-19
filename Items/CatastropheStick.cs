using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class CatastropheStick
    {
        public static void Add()
        {
            PerformRandomEffectsAnythingEffect Chaose = ScriptableObject.CreateInstance<PerformRandomEffectsAnythingEffect>();
            Chaose.randomBetweenPrevious = true;

            PerformEffect_Item catastropheStick = new PerformEffect_Item("CatastropheStick_ID", null, false)
            {
                Item_ID = "CatastropheStick_TW",
                Name = "Catastrophe Stick",
                Flavour = "\"Let 'er rip bro, it'll be sick! *Nuclear blast*\"",
                Description = "Performs 20-50 random effects on turn end.",
                IsShopItem = false,
                ShopPrice = 1,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("TreasureCatastropheStick"),
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 20),
                    Effects.GenerateEffect(Chaose, 51),
                ],
                TriggerOn = TriggerCalls.OnTurnFinished,
            };

            catastropheStick.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(catastropheStick.Item, new ItemModdedUnlockInfo(catastropheStick.Item_ID, ResourceLoader.LoadSprite("TreasureCatastropheStick")));
        }
    }
}
