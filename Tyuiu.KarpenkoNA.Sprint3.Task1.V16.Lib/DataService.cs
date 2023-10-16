using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KarpenkoNA.Sprint3.Task1.V16.Lib
{
    public class DataService : ISprint3Task1V16
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            double value = 0.7;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow(value, 2) * Math.Sin(startValue) + 1);
                startValue++;
            }
            
            return Math.Round(sumSeries, 3);
        }
    }
}
