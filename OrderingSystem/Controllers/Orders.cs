using Microsoft.AspNetCore.Mvc;

namespace OrderingSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Orders : ControllerBase
    {
        private readonly ILogger<Orders> _logger;

        public Orders(ILogger<Orders> logger)
        {
            _logger = logger;
        }

        public Order[] Get()
        {
            return new[] {new Order
            {
                Id = 1,
            }};
        }
    }
}