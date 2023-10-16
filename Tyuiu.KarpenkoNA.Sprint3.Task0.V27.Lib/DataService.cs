﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarpenkoNA.Sprint3.Task0.V27.Lib
{
    public class DataService : ISprint3Task0V27
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (Math.Pow((4 / Math.Pow(startValue, value)), 2));
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
