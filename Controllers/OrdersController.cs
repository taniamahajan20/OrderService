using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace OrderService.Controllers
{
    [Route("orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Order>> Get(int id)
        {
            List<Order> orders = new List<Order>();
            Order order1 = new Order();
            order1.OrderId = 1;
            order1.OrderAmount = 250;
            order1.OrderDate = new DateTime(2020, 04, 14);
            Order order2 = new Order();
            order2.OrderId = 2;
            order2.OrderAmount = 450;
            order2.OrderDate = new DateTime(2020, 04, 15);
            orders.Add(order1);
            orders.Add(order2);
            return Ok(orders);
        }
    }
}
