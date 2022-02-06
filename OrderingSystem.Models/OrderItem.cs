using OrderingSystem.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order? OrderId { get; set; }
        public Product? ProductId { get; set; }
    }
}
