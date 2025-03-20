using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class HoftstoldtExtraCCSprites_ArraySO : ExtraCharacterCombatSpritesSO
    {
        [Header("Data")]
        public Sprite[] _frontSprite;

        public Sprite _backSprite;

        [CharExtraSpriteIDsEnumRef]
        public string _DefaultID = "";

        [CharExtraSpriteIDsEnumRef]
        public string _SpecialID = "";

        public bool _doesLoop;

        public override ExtraSpriteOptions GetSpriteOptions(string extraSpriteID)
        {
            if (extraSpriteID.Equals(_DefaultID))
            {
                return ExtraSpriteOptions.UseDefault;
            }

            if (extraSpriteID.Equals(_SpecialID))
            {
                return ExtraSpriteOptions.UseSpecial;
            }

            return ExtraSpriteOptions.DoNothing;
        }

        public override int TryGetSpecialSprites(int specialID, out Sprite front, out Sprite back)
        {
            int num = _frontSprite.Length;
            if (num == 0)
            {
                front = null;
                back = null;
                return 0;
            }

            if (specialID >= num)
            {
                specialID = num - 1;
            }

            front = _frontSprite[specialID];
            back = _backSprite;
            specialID = UnityEngine.Random.Range(0, num);

            return specialID;
        }
    }
}
