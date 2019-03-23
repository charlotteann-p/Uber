using System;
using System.Data;
using System.Diagnostics;

namespace Uber
{
    class Program
    {
        static void Main(string[] args)
        {
             Fare.FareEstimator(30, 7, new [] { 0.2, 0.35, 0.4, 0.45 }, new [] { 1.1, 1.8, 2.3, 3.5});
        }
    }
}
