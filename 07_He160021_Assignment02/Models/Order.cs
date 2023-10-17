using System;
using System.Collections.Generic;

namespace _07_He160021_Assignment02.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int? Freight { get; set; }

    public string ShipAddress { get; set; } = null!;

    public virtual Customer? Customer { get; set; }
}
