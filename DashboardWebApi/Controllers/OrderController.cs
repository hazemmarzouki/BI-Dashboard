using System.Linq;
using DashboardWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace DashboardWebApi.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly ApiContext _ctx;

        public OrderController(ApiContext ctx)
        {
            _ctx = ctx;
        }

        //Get api/order/pageNumber/Page size
        [HttpGet("{pageIndex:int}/{pageSize:int}")]
        public IActionResult Get(int pageIndex, int pageSize)
        {
            var data = _ctx.Orders.Include(o => o.Customer).OrderByDescending(c => c.Placed);

            var page = new DataPagination<Order>(data, pageIndex, pageSize);
            var totalCount = data.Count();
            var totalPages = Math.Ceiling((double)totalCount / pageSize);

            var response = new { Page = page, TotalPages = totalPages };

            return Ok(response);
        }

        [HttpGet("ByState")]
        public IActionResult ByState()
        {
            //get all orders from DB and include (Customer: complexe object who has State as a property)
            var orders = _ctx.Orders.Include(o => o.Customer).ToList();
            //group orders by State Property
            var groupResult = orders
                .GroupBy(r => r.Customer.State)
                .ToList()
                .Select(grp =>new
                        { //select new object from previous query result
                            State = grp.Key,
                            Total = grp.Sum(x => x.Total)
                        }
                )
                .OrderByDescending(res => res.Total) //res = Desc list of State and total orders by state
                .ToList();

            return Ok(groupResult);
        }

        [HttpGet("ByCustomer/{n}")] 
        public IActionResult ByCustomer(int n)
        {
            var orders = _ctx.Orders.Include(o => o.Customer).ToList();

            var groupResult = orders
                .GroupBy(o => o.Customer.Id)
                .ToList()
                .Select(
                    grp =>
                        new
                        {
                            Name = _ctx.Customers.Find(grp.Key).Name, //Get the name of Customer using it's ID
                            Total = grp.Sum(x => x.Total)
                        }
                )
                .OrderByDescending(res => res.Total)
                .Take(n)
                .ToList();

            return Ok(groupResult);
        }

        [HttpGet("GetOrder/{id}", Name = "GetOrder")]
        public IActionResult GetOrder(int id)
        {
            var order = _ctx.Orders.Include(o => o.Customer).First(o => o.Id == id);
            return Ok(order);
        }
    }    

}


