using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodOrderingSystem.Models;

public partial class Employee
{
    [Display(Name = "Employee Id")]
    public int EmployeeId { get; set; }

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

    [Display(Name = "Date of Birth")]
    public DateTime DateOfBirth { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
