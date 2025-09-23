﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TumashenkinYA.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            
            double FullPrise = (distance * gasPrice * gasFlow / 50 * 100);
            return Math.Round(FullPrise) / 100;
        }
    }
}
