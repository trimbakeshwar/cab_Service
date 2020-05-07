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
        /// <summary>
        /// add rides one by one in arraylist
        /// </summary>
        /// <param name="Distance"> how much distance u travle</param>
        /// <param name="muinet"> how much time require</param>
        /// <param name="forPremiumorNormal"> 1 for primiun 0 for normal ride</param>
        /// <param name="userid">user id for travler</param>
        
            //add all information as object in array list
        public void AddRides(int Distance, int muinet, int forPremiumorNormal, string userid)
        {
            list.Add(new CabService(Distance, muinet, forPremiumorNormal, userid));
        }
        /// <summary>
        /// add multiple rides at a time
        /// </summary>
        /// <param name="DistanceArray">array of distance</param>
        /// <param name="muinetArray">muinit array </param>
        /// <param name="forPremiumorNormal"> 1 for primium o for normal</param>
        /// <param name="userid"></param>
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
        /// <summary>
        /// get all rides information regarding user
        /// </summary>
        /// <param name="UId">user id</param>
        /// <returns></returns>
       public dynamic getAllRides(string UId)
        {
            try 
            {
                int CountOfRide = 0;
                //list for add user id travling information in list
                List<CabService> detailOfUser = new List<CabService>();
                //get one by one record by loop
                foreach (CabService data in list)
                {
                    //if uid match with parameter uid then add all information in list  
                    if (UId.Equals(data.UserId))
                    {
                        //count number of rides
                        CountOfRide++;
                        //add matching uid information in list
                        detailOfUser.Add(data);

                    }
                }
                //return information and count of rides
                return (detailOfUser, CountOfRide);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message); 
            }
            
        }
    }
}
