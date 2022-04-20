
using System.Collections.Generic;
using System;



namespace DashboardWebApi
{
    public class Helpers {
        private static Random _rand = new Random();

        private static string GetRandom(List<string> items) {

            return items[ _rand.Next(items.Count) ];
        }
        
        internal static string MakeCustomerName() {

            var prefix = GetRandom(B_prefix);
            var suffix = GetRandom(B_suffix);
            return prefix + suffix;

        }


        internal static string MakeCustomerEmail(string name){
            return $"contact@{name.ToLower()}.com";

        }

        internal static string MakeRandomState(){
            return GetRandom(TnStates);
            
        }

        internal static decimal GetRandomOrderTotal(){
            return _rand.Next(100,5000);
        }

        internal static DateTime GetRandomOrderPlaced(){
            var end = DateTime.Now;
            var start = end.AddDays(-90);// max date an order is placed is 90 days ago
            TimeSpan possibleSpan = end -start;
            TimeSpan newSpan = new TimeSpan(0,_rand.Next(0, (int)possibleSpan.TotalMinutes),0); 
            //we defined a new timespan by passing seconds,hours,minutes to it 
            return start + newSpan; //retrun a random date 90 days ago
        }

        internal static DateTime? GetRandomOrderCompleted(DateTime orderPlaced){
            var now = DateTime.Now;
            var minLeadTime = TimeSpan.FromDays(7); // minimum lead time of any order is 7 days
            var TimePassed = now - orderPlaced ;

            if (TimePassed < minLeadTime)
            {
                return null ;
            }
            return orderPlaced.AddDays(_rand.Next(7,14));

        }

        private static readonly List<string> TnStates = new List<string>(){
            "Ariana","Beja","Ben Arous","Bizerte","Gabes","Gafsa","Jendouba","Kairouan",
            "Kef","Mahdia","Manouba","Kasserine","Mahdia","Medenine","Nabeul","Zaghouan",
            "Monastir","Sousse","Sfax","Sidi Bouzid","Siliana","Tunis","Tataouine","Touzeur"

        };

        public static readonly List < string > B_prefix = new List < string > () {
            "Mega",
            "Vivo",
            "Omni",
            "Smart",
            "First",
            "Urban",
            "XYZ",
            "ABC",
            "Entreprise",
            "Meta",
            "Business",
            "The Merch",
            "Data",
            "Shop",
            "Aero"

        };

        public static readonly List<string> B_suffix = new List<string> () {
            " Ltd.",
            " S.A.",
            " Corp",
            " Logistics",
            " Co",
            " Tech",
            " X",
            " Info",
            " Media",
            " LLC",
            " Inc.",
            " Corporation",
            " Limited",
            " Company"
            
        };


    }
}