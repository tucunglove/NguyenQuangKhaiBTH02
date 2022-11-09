using System.ComponentModel.DataAnnotations;

namespace NguyenQuangKhaiBTH02.Models
{
    public class Person
    {
        [Key]
        public string PersonID {get; set;}
        
        public string PersonName {get; set;}
    }
}