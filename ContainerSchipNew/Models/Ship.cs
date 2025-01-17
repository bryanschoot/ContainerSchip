﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainerSchipNew.Models
{
    public class Ship
    {
        public decimal Balance { get; set; }
        public double MaxWeight { get; set; }
        public double MinWeight { get; set; }
        public double UpperRow { get; set; }
        public double LowerRow { get; set; }
        public List<Place> Places { get; set; }

        public Ship() { }

        /// <summary>
        /// Costructor to create the new ship;
        /// </summary>
        /// <param name="maxWeight">Sets the weight of the ship</param>
        /// <param name="places">Creates a list of places</param>
        public Ship(double maxWeight, List<Place> places)
        {
            MaxWeight = maxWeight;
            MinWeight = CalculateMinWeight();
            Places = places;
        }

        public override string ToString()
        {
            return $"Max: {MaxWeight} \nMin: {MinWeight}";
        }

        /// <summary>
        /// Calculate the min weight needed to let the ship sail.
        /// </summary>
        /// <returns>The minimum weight</returns>
        public double CalculateMinWeight()
        {
            return Convert.ToDouble(MaxWeight / 2);
        }

        /// <summary>
        /// Calculates the balance of the ship to prevent it from capseizing.
        /// </summary>
        /// <returns></returns>
        public decimal CalculateBalance()
        {
            double row1 = 0;
            double row2 = 0;

            for (int i = 0; i < 6; i++)
            {
                if (i == 0 || i == 1 || i == 2)
                    row1 = row1 + Places[i].Weight;
                else
                    row2 = row2 + Places[i].Weight;
            }
            Balance = Convert.ToDecimal((row2 - row1) / row1 * 100);
            return Balance;
        }

        /// <summary>
        /// Rebalance the ship if it is under above 20%
        /// </summary>
        /// TODO Optimize BalanceShip section
        public void BalanceShip()
        {
            if (UpperRow > LowerRow)
            {
                List<double> UpperList = new List<double>();
                UpperList.Add(Places[0].Weight);
                UpperList.Add(Places[1].Weight);
                UpperList.Add(Places[2].Weight);

                double max = UpperList.Max();
                for (int i = 0; i < 3; i++)
                {
                    if (Places[i].Weight == max)
                    {
                        foreach (var container in Places[i].Containers)
                        {
                            if (!container.Valuable)
                            {
                                Places[i + 3].AddContainer(container);
                                Places[i].RemoveContainer(container);
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                List<double> lowerList = new List<double>();
                lowerList.Add(Places[3].Weight);
                lowerList.Add(Places[4].Weight);
                lowerList.Add(Places[5].Weight);

                double max = lowerList.Max();
                for (int i = 3; i < 6; i++)
                {
                    if (Places[i].Weight == max)
                    {
                        foreach (var container in Places[i].Containers)
                        {
                            if (!container.Valuable && !container.Cooled)
                            {
                                Places[i + 2].Containers.Add(container);
                                Places[i].Containers.Remove(container);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}