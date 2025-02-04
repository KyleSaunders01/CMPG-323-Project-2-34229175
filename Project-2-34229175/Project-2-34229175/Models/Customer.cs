﻿using System;
using System.Collections.Generic;

namespace Project_2_34229175.Models;

public partial class Customer
{
    public short CustomerId { get; set; }

    public string? CustomerTitle { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerSurname { get; set; }

    public string? CellPhone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
