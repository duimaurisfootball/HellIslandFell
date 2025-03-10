using FMODUnity;
using System;
using System.Collections.Generic;
using System.Text;
using Tools;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class ErasCharacterSO : CharacterSO
    {
        public override int[] GenerateAbilities()
        {
            int num = UnityEngine.Random.Range(0, 3);
            int num2 = (num == 0) ? 1 : 0;
            int num3 = (num == 2) ? 1 : 2;
            return [3, num2, num3];
        }
    }
}
