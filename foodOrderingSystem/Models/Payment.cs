using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foodOrderingSystem.Models;

public partial class Payment
{

    [Display(Name = "Payment Id")]
    public int PaymentId { get; set; }


    [Display(Name = "Customer Id")]
    public int CustomerId { get; set; }


    [Display(Name = "Order Item Id")]
    public int OrderItemId { get; set; }


    [Display(Name = "Payment Date")]
    [DataType(DataType.Date)]
    public DateTime PaymentDate { get; set; }


    [Display(Name = "Total Amount")]
    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(5, 2)")]
    public decimal TotalAmount { get; set; }


    [Display(Name = "Payment Type Id")]
    public int PaymentTypeId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
