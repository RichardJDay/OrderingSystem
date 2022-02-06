using OrderingSystem.Models;

namespace OrderingSystem.Controllers
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem>? OrderItems { get; set; }

    }
}