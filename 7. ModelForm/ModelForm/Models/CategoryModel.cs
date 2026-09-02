using System.ComponentModel.DataAnnotations;

namespace ModelForm.Models
{
    public class CategoryModel
    {
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string CategoryDescription { get; set; }
        [Required]
        public ParentCategory CategoryParent { get; set; }
        [Required]
        public int ProductCount { get; set; }
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
