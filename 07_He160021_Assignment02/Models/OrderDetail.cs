﻿using System;
using System.Collections.Generic;

namespace _07_He160021_Assignment02.Models;

public partial class OrderDetail
{
    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
