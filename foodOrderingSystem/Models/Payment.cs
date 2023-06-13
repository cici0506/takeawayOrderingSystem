using System;
using System.Collections.Generic;

namespace foodOrderingSystem.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int CustomerId { get; set; }

    public int OrderItemId { get; set; }

    public DateTime PaymentDate { get; set; }

    public decimal TotalAmount { get; set; }

    public int PaymentTypeId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
