using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Person")]

public class Person
{
    [Key]
    [Required(ErrorMessage ="vui long nhap thong tin")]
    public string? PersonID{get;set;}
    [Required(ErrorMessage ="vui long nhap thong tin")]
    public string? Fullname{get;set;}
}
}