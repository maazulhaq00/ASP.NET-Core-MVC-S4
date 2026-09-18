namespace DatabaseFirst.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; } = null!;

        public int StudentAge { get; set; }

        public string StudentEmail { get; set; } = null!;

        public IFormFile StudentImage { get; set; }
    }
}
