using DashboardWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DashboardWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApiContext _ctx ; 
        public CustomerController(ApiContext ctx )
        {
            _ctx = ctx ;
        }

        //GET api/customers
        [HttpGet]
        public IActionResult Get()
        {
            var data = _ctx.Customers.OrderBy(c => c.Id);
            return Ok(data);                                   //Ok: Http 200 response
        }

        //GET api/customers/5
        [HttpGet("{id}", Name = "GetCustomer")]// example :http://localhost:5001/api/Customer/7
        public IActionResult Get(int id)
        {
            var customer = _ctx.Customers.Find(id);
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer){

            if(customer == null){
                return BadRequest();
            }
            
                _ctx.Customers.Add(customer);
                _ctx.SaveChanges();

                return CreatedAtRoute("GetCustomer", new { id = customer.Id}, customer);
                //CreatedAtroute returns : Http 201 response => "Created Successfully"

        }


        
    }
}