using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class UnitStoreData_Nick_ModIntSO : UnitStoreData_BasicSO
    {
        public Color m_TextColor = Color.black;

        public int m_CompareDataToThis;

        public bool m_ShowIfDataIsOver = true;

        public override bool TryGetUnitStoreDataToolTip(UnitStoreDataHolder holder, out string result)
        {
            bool flag = holder.m_MainData > 0;
            result = holder.m_MainData == 1 ? "Hammer is Lowered" : "Hammer is Raised";
            return flag;
        }

        public string GenerateString(int value)
        {
            string fill = "";
            if (value == 1)
            {
                fill = "Hammer is Lowered";
            }
            if (value == 2)
            {
                fill = "Hammer is Raised";
            }
            if (value > 2)
            {
                fill = "Number Magnet user spotted\nHammer is Raised";
            }
            string text = fill;
            string text2 = ColorUtility.ToHtmlStringRGB(m_TextColor);
            string text3 = "<color=#" + text2 + ">";
            string text4 = "</color>";
            return text3 + text + text4;
        }
    }
}
