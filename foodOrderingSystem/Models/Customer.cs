using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodOrderingSystem.Models;

public partial class Customer
{
    [Display(Name = "Customer Id")]
    public int CustomerId { get; set; }

    [Display(Name = "First Name")]
    [StringLength(10, MinimumLength = 3)]
    [Required]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    [StringLength(10, MinimumLength = 3)]
    [Required]
    public string LastName { get; set; } = null!;

    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = null!;

    public string? Email { get; set; }

    public string Street { get; set; } = null!;

    public string City { get; set; } = null!;

    [Display(Name = "Zip Code")]
    public string ZipCode { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
