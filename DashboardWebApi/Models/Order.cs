using System;
namespace DashboardWebApi.Models

{
    public class Order
    {
        public int Id {get;set;}
        public Customer Custromer {get;set;}
        public decimal Total {get;set;}
        public DateTime Placed {get;set;}
        public DateTime? Completed {get;set;}

    }
}