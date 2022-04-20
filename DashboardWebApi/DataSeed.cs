using DashboardWebApi.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace DashboardWebApi
{
    public class DataSeed
    {
        private readonly ApiContext _ctx;
        public DataSeed(ApiContext ctx)
        {
            _ctx = ctx;
        }

        public void SeedData(int nbr_Cust, int nbr_ord)
        { // check if we have any instances of cust,ord,ser in our DB 
            if (!_ctx.Customers.Any())
            { // if not add instances 
                SeedCustomers(nbr_Cust);
                _ctx.SaveChanges();

            }

            if (!_ctx.Orders.Any())
            {
                SeedOrders(nbr_ord);
                 _ctx.SaveChanges();

            }

            if (!_ctx.Servers.Any())
            {
                SeedServers();
                _ctx.SaveChanges();

            }
            
        }

        internal void SeedServers()
        {
            List<Server> servers = BuildServerList();
            foreach (var server in servers)
            {      _ctx.Servers.Add(server);            }
        }

        internal void SeedCustomers(int n)
        {
            List<Customer> customers = BuildCustomerList(n);
            foreach (var customer in customers)
            {
                _ctx.Customers.Add(customer);
            }
        }
        internal void SeedOrders(int n)
        {
            List<Order> orders = BuildOrderList(n);
            foreach (var order in orders)
            {
                _ctx.Orders.Add(order);
            }
        }

        internal static List<Customer> BuildCustomerList(int nbr_Cust)
        {
            var customers = new List<Customer>();

            for (int i = 1; i < nbr_Cust; i++)
            {
                var name = Helpers.MakeCustomerName();

                customers.Add(new Customer
                {
                    Id = i,
                    Name = name,
                    Email = Helpers.MakeCustomerEmail(name),
                    State = Helpers.MakeRandomState()
                });
            }
            return customers;
        }

        internal List<Order> BuildOrderList(int nbr_ord)
        {

            var orders = new List<Order>();
            var rand = new Random();

            for (int i = 1; i < nbr_ord; i++)
            {
                var randCustomerId = rand.Next(1,_ctx.Customers.Count());
                var placed = Helpers.GetRandomOrderPlaced();
                var completed = Helpers.GetRandomOrderCompleted(placed);
                var customers = _ctx.Customers.ToList();

                orders.Add(new Order
                { //Add New order to orders array 
                    Id = i,
                    Customer = customers.First(c => c.Id == randCustomerId),
                    Total = Helpers.GetRandomOrderTotal(),
                    Placed = placed,
                    Completed = completed
                });
            }
            return orders;
        }

       internal static List<Server> BuildServerList()
        {
            return new List<Server>()
            {
                new Server
                {
                    Id = 1,
                    Name = "Dev-Web",
                    IsOnline = true
                },

                new Server
                {
                    Id = 2,
                    Name = "Dev-Analysis",
                    IsOnline = true
                },

                new Server
                {
                    Id = 3,
                    Name = "Dev-Logistics",
                    IsOnline = false
                },

                new Server
                {
                    Id = 4,
                    Name = "QA-Logistics",
                    IsOnline = true
                },

                new Server
                {
                    Id = 5,
                    Name = "QA-Analysis",
                    IsOnline = true
                },

                new Server
                {
                    Id = 6,
                    Name = "QA-Web",
                    IsOnline = false
                },

                new Server
                {
                    Id = 7,
                    Name = "Prod-Web",
                    IsOnline = false
                },

                new Server
                {
                    Id = 8,
                    Name = "Prod-Analysis",
                    IsOnline = true
                },

                new Server
                {
                    Id = 9,
                    Name = "Prod-Logistics",
                    IsOnline = false
                },
            };
        }

    }
}