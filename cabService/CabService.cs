using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cabService
{
    public class CabService
    {
       
        //total distance in minute
        public int Distance  {set; get;} 
        //total time 
        public int TimeInMinutes {set; get;}
        //rate per km 
        public int ratePerKm = 10;
        //rate per minute
        public int ratePerMinute = 1;
        //minimum pay
        public int minimumFair = 5;
        public int TotalFair { get; }
        public CabService(int distanceInKm, int minutes)
        {
            this.Distance = distanceInKm;
            this.TimeInMinutes = minutes;
            this.TotalFair=getTotalFair();
        }
       
        /// <summary>
        /// get total fair of journey
        /// </summary>
        /// <returns></returns>
        public int getTotalFair()
        {
            //calculate total fair
            int Fair = (Distance * ratePerKm) + (TimeInMinutes * ratePerMinute);
            //if total fair is less than min fair then return minimum fair otherwise return total fair
            if(Fair< minimumFair)
            {
                return minimumFair;
            }
            else
            {
                return Fair;
            }
        }
    }
}
