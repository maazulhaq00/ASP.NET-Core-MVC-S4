using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirst.Models;

public partial class Student
{
    
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public int StudentAge { get; set; }

    public string StudentEmail { get; set; } = null!;

    public string? StudentImage { get; set; }
}
