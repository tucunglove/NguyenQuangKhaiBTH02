using System.ComponentModel.DataAnnotations;

namespace NguyenQuangKhaiBTH02.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID {get; set;}
        
        public string CustomerName {get; set;}
    }
}