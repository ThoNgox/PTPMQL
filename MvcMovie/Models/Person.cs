using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models

{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string PersonID { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; } 
    }
}