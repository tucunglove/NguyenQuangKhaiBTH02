using System.ComponentModel.DataAnnotations;

namespace NguyenQuangKhaiBTH02.Models
{
    public class Student
    {
        [Key]
        public string StudentID {get; set;}
        
        public string StudentName {get; set;}
    }
}