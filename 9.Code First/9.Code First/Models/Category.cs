using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _9.Code_First.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Column("CategoryName", TypeName ="varchar(100)")]
        public string CategoryName { get; set; }
        
        [Column("CategoryDescription", TypeName = "varchar(255)")]
        public string CategoryDescription { get; set; }
    }
}
