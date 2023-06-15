using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodOrderingSystem.Models;

public partial class PaymentType
{
    [Display(Name = "Payment Type Id")]
    public int PaymentTypeId { get; set; }

    [Display(Name = "Payment Type")]
    public string PaymentType1 { get; set; } = null!;
}
