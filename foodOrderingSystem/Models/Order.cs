using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodOrderingSystem.Models;

public partial class Order
{
    [Display(Name = "Order Id")]
    public int OrderId { get; set; }

    [Display(Name = "Order Date")]
    [DataType(DataType.Date)]
    public DateTime OrderDate { get; set; }

    public int Quantity { get; set; }

    [Display(Name = "Item Name")]
    public string ItemName { get; set; } = null!;

    public decimal Price { get; set; }

    [Display(Name = "Customer Id")]
    public int CustomerId { get; set; }

    [Display(Name = "Employee Id")]
    public int EmployeeId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
