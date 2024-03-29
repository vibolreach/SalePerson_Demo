﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SalepersonDemo_Lab8
{
    class RealEstateSalesperson: Salesperson, ISellable
    {
        public static readonly double CommissionRate;

        static RealEstateSalesperson()
        {
            CommissionRate = 2.0;
        }
        int totalValueSold = 0;
        double totalCommissionEarned = 0.0;

        public int TotalValueSold
        {
            get
            {
                return totalValueSold;
            }
            set
            {
                totalValueSold = value;
            }
        }
        public double TotalCommissionEarned
        {
            get
            {
                return totalCommissionEarned;
            }
            set
            {
                totalCommissionEarned = value;
            }
        }
        public RealEstateSalesperson(string firstName, string lastName) : base(firstName, lastName)
        {

        }
        public void SalesSpeech()
        {
            Console.WriteLine("I'm {0}, I sell houses", GetFullName());
        }
        public void MakeSale(int houseValue)
        {
            totalValueSold += houseValue;
            totalCommissionEarned += houseValue * CommissionRate / 100.0;
        }

    }
}
