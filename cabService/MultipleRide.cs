using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cabService
{
    public class MultipleRide
    {
        //store multiple rides
        ArrayList list = new ArrayList();
        //geting total fair
        public int totalFair { get; }
        //geting total aggregateOfTotalFair
        public int aggregateOfTotalFair { get; }
        //geting TotalNumberOfRides
        public int TotalNumberOfRides { get; }
        public MultipleRide(int[] DistanceArray, int[] muinetArray,int[] forPremiumorNormal,string[] userid)
        {
           
            //add all dist and rides in array list by loop
            //creating object of distance and muinet by using single cab service
            for (int i = 0; i < muinetArray.Length; i++)
            {
                list.Add(new CabService(DistanceArray[i], muinetArray[i], forPremiumorNormal[i],userid[i]));
            }
            //getting multiple rides total amount
            totalFair = getMultipleTotalFair();
            //total rides
            TotalNumberOfRides = list.Count;
            //aggreget rides
            aggregateOfTotalFair = getaggregateMoney();
        }
        /// <summary>
        /// calculate total money of all rides
        /// </summary>
        /// <returns>total faers</returns>
        public int getMultipleTotalFair()
        {
            int Fair = 0;
            //geting Total fair of individual object amount and add in fair affter all list fair 
            foreach(CabService data in list)
            {
                Fair += data.TotalFair;
            }
            return Fair;
        }
        /// <summary>
        /// calculate aggregate fair
        /// </summary>
        /// <returns></returns>
        public int getaggregateMoney()
        {
            //total amount divided by number of ride and calculaate
            int aggregateMoney = totalFair / TotalNumberOfRides;
            return aggregateMoney;
        }
       
    }
}
