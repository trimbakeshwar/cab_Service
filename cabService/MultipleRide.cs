using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cabService
{
    public class MultipleRide
    {
        ArrayList list = new ArrayList();
        public int totalFair { get; }
        public int aggregateOfTotalFair { get; }
        public int TotalNumberOfRides { get; }
        public MultipleRide(int[] DistanceArray, int[] muinetArray)
        {
            for (int i = 0; i < muinetArray.Length; i++)
            {
                list.Add(new CabService(DistanceArray[i], muinetArray[i]));
            }
            totalFair = getMultipleTotalFair();
            TotalNumberOfRides = list.Count;
            aggregateOfTotalFair = getaggregateMoney();
        }

        public int getMultipleTotalFair()
        {
            int Fair = 0;
            foreach(CabService data in list)
            {
                Fair += data.TotalFair;
            }
            return Fair;
        }
        public int getaggregateMoney()
        {
            int aggregateMoney = totalFair / TotalNumberOfRides;
            return aggregateMoney;
        }
    }
}
