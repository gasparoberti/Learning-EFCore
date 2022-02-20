using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
    }
}
