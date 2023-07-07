using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public string OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
