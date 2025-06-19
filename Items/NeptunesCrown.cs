using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class NeptunesCrown
    {
        public static void Add()
        {
            SpawnRandomWomanEffect WomenWantMe = ScriptableObject.CreateInstance<SpawnRandomWomanEffect>();
            WomenWantMe._permanentSpawn = false;
            WomenWantMe._rank = 1;
            WomenWantMe._nameAddition = NameAdditionLocID.NameAdditionNone;

            ScareRandomFishEffect FishFearMe = ScriptableObject.CreateInstance<ScareRandomFishEffect>();
            FishFearMe._chance = 20;

            DoublePerformEffect_Item neptunesCrown = new DoublePerformEffect_Item("NeptunesCrown_ID", null, false)
            {
                Item_ID = "NeptunesCrown_TW",
                Name = "Neptune's Crown",
                Flavour = "\"Women fear me, fish fear me, men turn their eyes away from me as I walk. No beasts dare make a sound in my presence; I am alone on this barren earth. I revel in this power, it gives me purpose. Not a day passes where the piscine feels unaware of my wrath, I have made this certain. Let any fish who meets my gaze learn the true meaning of fear; for I am the harbinger of death, the bane of creatures subaueous. My rod is true and unwavering as I cast into the aquatic abyss. A man, scorned by this uncaring earth finds solace in the sea. My only friend, the worm upon my hook, wriggling, writhing, struggling to surmount the mortal pointlessness that permeates this barren world. I am alone, I am empty. And yet, I fish.\"",
                Description = "Attract a random friendly woman at the start of combat. Scares fish at the start of each turn, occasionally making them flee combat.",
                IsShopItem = false,
                ShopPrice = 20,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("TreasureNeptunesCrown"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(WomenWantMe, 1),
                ],
                SecondaryTriggerOn = [TriggerCalls.OnTurnStart],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(FishFearMe, 1, Targeting.AllUnits),
                ],
            };

            neptunesCrown.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Fabric.ToString(),
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(neptunesCrown.Item, new ItemModdedUnlockInfo(neptunesCrown.Item_ID, ResourceLoader.LoadSprite("TreasureNeptunesCrown")));
            ItemUtils.AddItemCanOfWormsPool(neptunesCrown.item, 1);
        }
    }
}
