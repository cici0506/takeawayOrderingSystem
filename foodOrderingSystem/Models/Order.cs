using System;
using System.Collections.Generic;

namespace foodOrderingSystem.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int Quantity { get; set; }

    public string ItemName { get; set; } = null!;

    public decimal Price { get; set; }

    public int CustomerId { get; set; }

    public int EmployeeId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
