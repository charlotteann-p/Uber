using System;
using System.Data;
using System.Diagnostics;

namespace Uber
{
    class Fare
    {
        public static double[] FareEstimator(int ride_time, int ride_distance, double[] cost_per_minute, double[] cost_per_mile)
        {
            double[] resultArray = new double[cost_per_minute.Length];

            for (int i = 0; i < cost_per_minute.Length; i++)
            {
                double fare = (cost_per_minute[i] * ride_time) + (cost_per_mile[i] * ride_distance);
                resultArray[i] = fare;
            }
            return resultArray;
        }
    }
}
