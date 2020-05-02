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
        public int ratePerKm;
        //rate per minute
        public int ratePerMinute;
        //minimum pay
        public int minimumFair;
        public int TotalFair { get; }
        public string UserId { set; get; }
        public CabService(int distanceInKm, int minutes, int normalOrPrimiun,string userid)
        {
            this.Distance = distanceInKm;
            this.TimeInMinutes = minutes;
            this.UserId = userid;
            //initialize for normal ride
            try
            {
                if (normalOrPrimiun == 0)
                {
                    //rate per km
                    ratePerKm = 10;
                    //rate per minute
                    ratePerMinute = 1;
                    //minimum pay
                    minimumFair = 5;
                }
                //initalize for premium ride
                else if (normalOrPrimiun == 1)
                {
                    //rate per km
                    ratePerKm = 15;
                    //rate per minute
                    ratePerMinute = 2;
                    //minimum pay
                    minimumFair = 20;
                }
                else
                {
                    throw new Exception("not a valid input");
                }
               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
               
            }

            this.TotalFair = getTotalFair();
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
            
                return Fair;
            
        }
       
    }
}
