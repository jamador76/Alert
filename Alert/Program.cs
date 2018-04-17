using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            AlertType[] alerts = new AlertType[]
            {
                new AlertType
                {
                    Min = 1,
                    Max = 10,
                    Name = "Low",
                    Param = "A"
                },
                new AlertType
                {
                    Min = 11,
                    Max = 20,
                    Name = "Medium",
                    Param = "A"
                },
                new AlertType
                {
                    Min = 21,
                    Max = 30,
                    Name = "High",
                    Param = "A"
                },
                new AlertType
                {
                    Min = 1,
                    Max = 10,
                    Name = "Low",
                    Param = "B"
                },
                new AlertType
                {
                    Min = 11,
                    Max = 20,
                    Name = "Medium",
                    Param = "B"
                }
            };

            int value = 15;
            string param = "A";

            var alertType = alerts.Where(a => a.Param.Equals(param) && (value >= a.Min && value <= a.Max)).SingleOrDefault();
            string alertName = alertType.Name;

            Console.WriteLine("Name: " + alertName);
        }
    }
}