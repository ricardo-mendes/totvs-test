using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotvsTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private static DbContext _dbContext = new DbContext();

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var orders = _dbContext.Orders;

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var order = _dbContext.Orders.FirstOrDefault(o => o.Id == id);

            order.Code = string.Empty;

            return Ok(order);
        }

        [HttpPost]
        public IActionResult Post(Order order)
        {
            _dbContext.Orders.Add(order);
            return Ok();
        }
    }
}
