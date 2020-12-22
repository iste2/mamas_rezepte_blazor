using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamasRezepte.Client.Const
{
    public static class ColorConsts
    {

        public static string FOrange => "#FDCEA2";
        public static string FYellow => "#FFF6CF";
        public static string FPurple => "#D7C8E5";
        public static string FBrown => "#EAD2B8";
        public static string FPink => "#EAA7C4";
        //public static string FGreen => "#A9CFBE";
        public static string FBlue => "#C3FCF2";

        public static List<string> AllColors = new List<string> { 
            FOrange, FYellow, FPink, FPurple, FBrown, FBlue
        };

        public static string RandomColor()
        {
            var hRandom = new Random();
            int hIndex = hRandom.Next(AllColors.Count);
            return AllColors[hIndex];
        }

    }
}
