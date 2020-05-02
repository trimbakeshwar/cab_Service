using System;
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
        public CabService(int distanceInKm, int minutes)
        {
            Distance = distanceInKm;
            TimeInMinutes = minutes;
        }
        /// <summary>
        /// get total fair of journey
        /// </summary>
        /// <returns></returns>
        public int getTotalFair()
        {
            //calculate total fair
            int TotalFair = (Distance * ratePerKm) + (TimeInMinutes * ratePerMinute);
            //if total fair is less than min fair then return minimum fair otherwise return total fair
            if(TotalFair< minimumFair)
            {
                return minimumFair;
            }
            else
            {
                return TotalFair;
            }
        }
    }
}
