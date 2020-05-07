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
                    //if user send other value expected 0 or 1 then throw exceptio 
                    throw new cabInoviceException(cabInoviceException.ExceptionType.ENTER_PROPER_INPUT, "enter 1 or 0");
                }
               
            }
            catch(cabInoviceException e)
            {
                Console.WriteLine(e.Message);
      
            }

            this.TotalFair = getTotalFair();
        }
       
        /// <summary>
        /// get total fair of journey
        /// </summary>
        /// <returns></returns>
        public dynamic getTotalFair()
        {
            try
            {
                //calculate total fair
                int Fair = (Distance * ratePerKm) + (TimeInMinutes * ratePerMinute);
                //if total fair is less than min fair then return minimum fair otherwise return total fair
                if (Fair < minimumFair)
                {
                    return minimumFair;
                }
                if(Distance==0)
                {
                    throw new cabInoviceException(cabInoviceException.ExceptionType.ENTER_PROPER_DISTANCE, "enter proper distance");
                }
                if (TimeInMinutes == 0)
                {
                    throw new cabInoviceException(cabInoviceException.ExceptionType.ENTER_PROPER_TIME, "enter proper time");
                }
                return Fair;

            }
            catch(cabInoviceException e)
            {
                throw new cabInoviceException(cabInoviceException.ExceptionType.ENTER_PROPER_TIME, e.Message);
            }


        }
       
    }
}
