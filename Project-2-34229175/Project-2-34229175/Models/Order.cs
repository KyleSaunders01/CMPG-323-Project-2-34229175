using System;
using System.Collections.Generic;

namespace Project_2_34229175.Models;

public partial class Order
{
    public short OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public short CustomerId { get; set; }

    public string? DeliveryAddress { get; set; }

    public virtual Customer? Customer { get; set; } 

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
