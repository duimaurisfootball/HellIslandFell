using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class CustomMusicParameters
    {
        public static HashSet<int> customHash;

        public static HashSet<int> _vusIDs = [];

        public static void TrySetCombatParameterID(Action<AudioControllerSO, MusicParameter, int, bool> orig, AudioControllerSO self, MusicParameter parameter, int ID, bool addition)
        {
            switch (parameter)
            {
                case (MusicParameter)888833:
                    TreatVusParameter(ID, addition, self);
                    break;
                default:
                    orig(self, parameter, ID, addition);
                    break;
            }
        }

        public static void TreatVusParameter(int id, bool addition, AudioControllerSO self)
        {
            bool flag = _vusIDs.Count > 0;
            _ = addition ? _vusIDs.Add(id) : _vusIDs.Remove(id);
            bool flag2 = _vusIDs.Count > 0;
            if (flag != flag2)
            {
                self.MusicCombatEvent.setParameterByName("VusOpen", flag2 ? 1 : 0);
            }
        }

        public static void Add()
        {
            IDetour val = new Hook(typeof(AudioControllerSO).GetMethod("TrySetCombatParameterID", (BindingFlags)(-1)), typeof(CustomMusicParameters).GetMethod("TrySetCombatParameterID", (BindingFlags)(-1)));
        }
    }
}
