using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Hoftstoldt
    {
        public static void Add()
        {
            HoftstoldtExtraCCSprites_ArraySO FaceSprites = ScriptableObject.CreateInstance<HoftstoldtExtraCCSprites_ArraySO>();
            FaceSprites._doesLoop = true;
            FaceSprites._DefaultID = "HoftstoldtSpritesDefault";
            FaceSprites._SpecialID = "HoftstoldtSpritesSpecial";
            FaceSprites._frontSprite =
                [
                    ResourceLoader.LoadSprite("HoftstoldtFront1", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront2", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront3", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront4", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront5", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront6", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront7", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront8", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront9", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront10", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront11", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront12", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront13", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront14", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront15", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront16", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront17", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront18", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront19", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront20", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront21", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront22", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront23", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront24", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront25", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront26", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront27", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront28", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront29", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront30", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront31", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront32", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront33", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront34", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront35", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront36", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront37", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront38", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront39", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront40", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront41", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront42", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront43", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront44", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront45", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront46", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront47", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront48", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront49", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront50", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront51", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront52", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront53", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront54", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront55", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront56", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront57", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront58", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront59", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront60", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront61", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront62", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront63", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront64", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront65", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront66", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront67", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront68", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront69", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront70", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront71", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront72", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront73", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront74", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront75", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront76", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront77", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront78", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront79", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront80", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront81", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront82", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront83", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront84", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront85", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront86", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront87", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront88", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront89", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront90", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront91", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront92", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront93", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront94", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront95", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront96", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront97", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront98", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront99", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront101", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront102", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront103", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront104", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront105", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront106", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront107", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront108", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront109", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront110", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront111", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront112", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront113", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront114", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront115", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront116", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront117", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront118", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront119", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront120", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront121", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront122", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront123", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront124", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront125", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront126", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront127", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront128", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront129", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront130", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront131", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront132", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront133", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront134", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront135", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront136", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront137", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront138", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront139", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront140", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront141", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront142", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront143", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront144", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront145", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront146", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront147", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront148", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront149", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront150", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront151", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront152", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront153", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront154", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront155", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront156", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront157", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront158", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront159", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront160", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront161", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront162", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront163", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront164", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront165", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront166", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront167", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront168", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront169", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront170", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront171", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront172", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront173", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront174", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront175", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront176", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront177", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront178", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront179", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront180", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront181", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront182", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront183", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront184", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront185", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront186", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront187", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront188", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront189", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront190", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront191", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront192", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront193", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront194", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront195", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront196", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront197", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront198", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront199", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront201", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront202", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront203", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront204", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront205", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront206", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront207", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront208", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront209", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront210", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront211", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront212", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront213", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront214", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront215", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront216", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront217", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront218", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront219", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront220", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront221", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront222", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront223", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront224", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront225", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("HoftstoldtFront226", new Vector2(0.5f, 0f), 32),
                ];
            FaceSprites._backSprite = ResourceLoader.LoadSprite("HoftstoldtBack", new Vector2(0.5f, 0f), 32);

            Character hoftstoldt = new Character("Hoftstoldt", "Hoftstoldt_CH")
            {
                HealthColor = Pigments.Red,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("HoftstoldtBack", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("HoftstoldtBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("HoftstoldtOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = "event:/HoftstoldtDamage",
                DeathSound = "event:/HoftstoldtDeath",
                DialogueSound = "event:/HoftstoldtDx",
                ExtraSprites = FaceSprites,
                UnitTypes =
                [
                    "Sandwich_Robot",
                ],
            };
            hoftstoldt.GenerateMenuCharacter(ResourceLoader.LoadSprite("HoftstoldtMenu"), ResourceLoader.LoadSprite("HoftstoldtLocked"));
            hoftstoldt.AddPassives([Passives.Unstable, Passives.GetCustomPassive("HConstruct_PA")]);
            hoftstoldt.SetMenuCharacterAsFullSupport();

            SetCasterExtraSpritesEffect FaceOff = ScriptableObject.CreateInstance<SetCasterExtraSpritesEffect>();
            FaceOff._ExtraSpriteID = "HoftstoldtSpritesSpecial";

            ExtraPassiveAbility_Wearable_SMS UnstableWearable = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            UnstableWearable._extraPassiveAbility = Passives.Unstable;

            CopyAndSpawnCustomCharacterAnywhereEffect SpawnDoll = ScriptableObject.CreateInstance<CopyAndSpawnCustomCharacterAnywhereEffect>();
            SpawnDoll._characterCopy = "Doll_CH";
            SpawnDoll._rank = 0;
            SpawnDoll._nameAddition = NameAdditionLocID.NameAdditionNone;
            SpawnDoll._usePreviousAsHealth = false;
            SpawnDoll._permanentSpawn = false;
            SpawnDoll._extraModifiers =
                [
                    UnstableWearable,
                ];

            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;
            IndirectDamage._returnKillAsSuccess = true;

            HealEffect PreviousHeal = ScriptableObject.CreateInstance<HealEffect>();
            PreviousHeal.usePreviousExitValue = true;
            PreviousHeal._onlyIfHasHealthOver0 = true;

            RemoveStatusEffectEffect OilRemove = ScriptableObject.CreateInstance<RemoveStatusEffectEffect>();
            OilRemove._status = StatusField.OilSlicked;

            RemoveStatusEffectEffect FrailRemove = ScriptableObject.CreateInstance<RemoveStatusEffectEffect>();
            FrailRemove._status = StatusField.Frail;

            RemoveStatusEffectEffect RupturedRemove = ScriptableObject.CreateInstance<RemoveStatusEffectEffect>();
            RupturedRemove._status = StatusField.Ruptured;

            //soul
            Ability soul0 = new Ability("Soul Bean", "HIF_Soul_1_A")
            {
                Description = "Heal all allies to the Left and Right of a party member with Construct 2 health.\nSpawn a friendly Unstable doll.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtSoul"),
                Cost = [Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HoftstoldtHealEffect>(), 2),
                    Effects.GenerateEffect(SpawnDoll, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            soul0.AddIntentsToTarget(ScriptableObject.CreateInstance<AlliesToSidesOfConstruct>(), [nameof(IntentType_GameIDs.Heal_1_4)]);
            soul0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability soul1 = new Ability("Soul Stone", "HIF_Soul_2_A")
            {
                Description = "Heal all allies to the Left and Right of a party member with Construct 3 health.\nSpawn a friendly Unstable doll.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtSoul"),
                Cost = [Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HoftstoldtHealEffect>(), 3),
                    Effects.GenerateEffect(SpawnDoll, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            soul1.AddIntentsToTarget(ScriptableObject.CreateInstance<AlliesToSidesOfConstruct>(), [nameof(IntentType_GameIDs.Heal_1_4)]);
            soul1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability soul2 = new Ability("Soul Prison", "HIF_Soul_3_A")
            {
                Description = "Heal all allies to the Left and Right of a party member with Construct 4 health.\nSpawn a friendly Unstable doll.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtSoul"),
                Cost = [Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HoftstoldtHealEffect>(), 4),
                    Effects.GenerateEffect(SpawnDoll, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            soul2.AddIntentsToTarget(ScriptableObject.CreateInstance<AlliesToSidesOfConstruct>(), [nameof(IntentType_GameIDs.Heal_1_4)]);
            soul2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability soul3 = new Ability("Soul Screen", "HIF_Soul_4_A")
            {
                Description = "Heal all allies to the Left and Right of a party member with Construct 5 health.\nSpawn a friendly Unstable doll.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtSoul"),
                Cost = [Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HoftstoldtHealEffect>(), 5),
                    Effects.GenerateEffect(SpawnDoll, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            soul3.AddIntentsToTarget(ScriptableObject.CreateInstance<AlliesToSidesOfConstruct>(), [nameof(IntentType_GameIDs.Heal_5_10)]);
            soul3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);


            //ofThePeople
            Ability ofThePeople0 = new Ability("Faces of the People", "HIF_OfThePeople_1_A")
            {
                Description = "Deal 4 damage to all enemies Opposing a party member with Construct.\nSpawn a friendly Unstable doll.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtOfThePeople"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HoftstoldtDamageEffect>(), 4),
                    Effects.GenerateEffect(SpawnDoll, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            ofThePeople0.AddIntentsToTarget(ScriptableObject.CreateInstance<EnemiesOpposingConstruct>(), [nameof(IntentType_GameIDs.Damage_3_6)]);
            ofThePeople0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability ofThePeople1 = new Ability("Bodies of the People", "HIF_OfThePeople_2_A")
            {
                Description = "Deal 5 damage to all enemies Opposing a party member with Construct.\nSpawn a friendly Unstable doll.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtOfThePeople"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HoftstoldtDamageEffect>(), 5),
                    Effects.GenerateEffect(SpawnDoll, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            ofThePeople1.AddIntentsToTarget(ScriptableObject.CreateInstance<EnemiesOpposingConstruct>(), [nameof(IntentType_GameIDs.Damage_3_6)]);
            ofThePeople1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability ofThePeople2 = new Ability("Minds of the People", "HIF_OfThePeople_3_A")
            {
                Description = "Deal 6 damage to all enemies Opposing a party member with Construct.\nSpawn a friendly Unstable doll.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtOfThePeople"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HoftstoldtDamageEffect>(), 6),
                    Effects.GenerateEffect(SpawnDoll, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            ofThePeople2.AddIntentsToTarget(ScriptableObject.CreateInstance<EnemiesOpposingConstruct>(), [nameof(IntentType_GameIDs.Damage_3_6)]);
            ofThePeople2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Randomize)]);
            ofThePeople2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability ofThePeople3 = new Ability("Lives of the People", "HIF_OfThePeople_4_A")
            {
                Description = "Deal 7 damage to all enemies Opposing a party member with Construct.\nSpawn a friendly Unstable doll.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtOfThePeople"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HoftstoldtDamageEffect>(), 7),
                    Effects.GenerateEffect(SpawnDoll, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            ofThePeople3.AddIntentsToTarget(ScriptableObject.CreateInstance<EnemiesOpposingConstruct>(), [nameof(IntentType_GameIDs.Damage_7_10)]);
            ofThePeople3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);


            //assimilation
            Ability assimilation0 = new Ability("Digital Assimilation", "HIF_Assimilation_1_A")
            {
                Description = "Kill all friendly dolls.\nHeal all party members for the damage dealt.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtAssimilation"),
                Cost = [Pigments.Red, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 999, ScriptableObject.CreateInstance<DollTargeting>()),
                    Effects.GenerateEffect(PreviousHeal, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            assimilation0.AddIntentsToTarget(ScriptableObject.CreateInstance<DollTargeting>(), [nameof(IntentType_GameIDs.Damage_Death)]);
            assimilation0.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);

            Ability assimilation1 = new Ability("Personal Assimilation", "HIF_Assimilation_2_A")
            {
                Description = "Kill all friendly dolls.\nHeal all party members for the damage dealt.\nRemove Oil Slicked from all party members.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtAssimilation"),
                Cost = [Pigments.Red, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 999, ScriptableObject.CreateInstance<DollTargeting>()),
                    Effects.GenerateEffect(PreviousHeal, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(OilRemove, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            assimilation1.AddIntentsToTarget(ScriptableObject.CreateInstance<DollTargeting>(), [nameof(IntentType_GameIDs.Damage_Death)]);
            assimilation1.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            assimilation1.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Rem_Status_OilSlicked)]);

            Ability assimilation2 = new Ability("Civilian Assimilation", "HIF_Assimilation_3_A")
            {
                Description = "Kill all friendly dolls.\nHeal all party members for the damage dealt.\nRemove Oil Slicked and Frail from all party members.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtAssimilation"),
                Cost = [Pigments.Red, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 999, ScriptableObject.CreateInstance<DollTargeting>()),
                    Effects.GenerateEffect(PreviousHeal, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(OilRemove, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(FrailRemove, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            assimilation2.AddIntentsToTarget(ScriptableObject.CreateInstance<DollTargeting>(), [nameof(IntentType_GameIDs.Damage_Death)]);
            assimilation2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            assimilation2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Rem_Status_OilSlicked)]);
            assimilation2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Rem_Status_Frail)]);

            Ability assimilation3 = new Ability("Military Assimilation", "HIF_Assimilation_4_A")
            {
                Description = "Kill all friendly dolls.\nHeal all party members for the damage dealt.\nRemove Oil Slicked, Frail, and Ruptured from all party members.",
                AbilitySprite = ResourceLoader.LoadSprite("HoftstoldtAssimilation"),
                Cost = [Pigments.Red, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 999, ScriptableObject.CreateInstance<DollTargeting>()),
                    Effects.GenerateEffect(PreviousHeal, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(OilRemove, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(FrailRemove, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(RupturedRemove, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(FaceOff),
                ],
            };
            assimilation3.AddIntentsToTarget(ScriptableObject.CreateInstance<DollTargeting>(), [nameof(IntentType_GameIDs.Damage_Death)]);
            assimilation3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            assimilation3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Rem_Status_OilSlicked)]);
            assimilation3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Rem_Status_Frail)]);
            assimilation3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Rem_Status_Ruptured)]);

            hoftstoldt.AddLevelData(15, [soul0, ofThePeople0, assimilation0]);
            hoftstoldt.AddLevelData(15, [soul1, ofThePeople1, assimilation1]);
            hoftstoldt.AddLevelData(15, [soul2, ofThePeople2, assimilation2]);
            hoftstoldt.AddLevelData(15, [soul3, ofThePeople3, assimilation3]);

            hoftstoldt.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Hoftstoldt_Witness_ACH");
            hoftstoldt.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Hoftstoldt_Divine_ACH");
            hoftstoldt.AddCharacter(true, false);
        }
    }
}
