﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class orderItem
    {
        public int Id { get; set; }
        public Guid IWeb { get; set; }
        public string ProductId { get; set; }
        public int Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsPayed { get; set; }

    }
}
