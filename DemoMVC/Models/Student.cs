using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models;
public class Student
{
    [Key]
    public string? StudentID{get;set;}
    public string? Fullname{get;set;}
    public string? Age{get;set;}
}
