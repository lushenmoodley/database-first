using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.Models;

public partial class Employee
{
    public int Id { get; set; }

    [DisplayName("First Name")]
    public string Firstname { get; set; } = null!;
    [DisplayName("Last Name")]
    public string? Lastname { get; set; }
}
