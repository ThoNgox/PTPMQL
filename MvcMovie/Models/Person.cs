using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models

{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string FullName { get; set; }
        public string PersonID{ get; set; }
        public string Address { get; set; }
        public int YearOfBirth { get; set; }
    }
}