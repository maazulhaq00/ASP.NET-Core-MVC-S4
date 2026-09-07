using System.ComponentModel.DataAnnotations;

namespace ModelForm.Models
{
    public class CategoryModel
    {
        [Required(ErrorMessage = "Category Name is must")]
        [StringLength(15, MinimumLength=3)]
        [Display(Name = "Category ka naam")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Category Description is must")]
        public string CategoryDescription { get; set; }
        
        [Required(ErrorMessage = "Category Parent is must")]
        public ParentCategory? CategoryParent { get; set; }
        
        [Required(ErrorMessage = "Product Count is must")]
        [Range(0, 50, ErrorMessage ="Products per category can not be more than 50 & less than 0")]
        public int? ProductCount { get; set; }

        // --------------- SOME OTHER VALIDATIONS --------------

        //[EmailAddress]
        //[DataType(DataType.EmailAddress)]
        //[Range(0, 50)]
        //[RegularExpression("expression")]
        //
    }
    public enum ParentCategory
    {
        Men, Women, Kid
    }

    //public enum TrafficLight
    //{
    //    Red, Yellow, Green
    //}
    //public enum Gender
    //{
    //    Male, Female
    //}

}
