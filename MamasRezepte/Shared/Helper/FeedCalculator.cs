using System;
using System.Collections.Generic;
using System.Text;
using MamasRezepte.Shared.Models;

namespace MamasRezepte.Shared.Helper
{
    public static class FeedCalculator
    {

        public static double CalculateScore(List<Click> _Clicks)
        {
            var hScore = 0.0;
            var hNow = DateTime.Now;
            foreach(var hClick in _Clicks)
            {
                hScore += 1 / Math.Pow(hNow.Subtract(hClick.Time).TotalDays, 2);
            }
            return hScore;
        }

    }
}
