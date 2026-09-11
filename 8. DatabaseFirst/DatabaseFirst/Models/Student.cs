using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.Models;

public partial class Student
{
    public int StudentId { get; set; }

    [Required]
    public string StudentName { get; set; } = null!;

    [Required]
    public int? StudentAge { get; set; }

    [Required]
    public string StudentEmail { get; set; } = null!;
}
