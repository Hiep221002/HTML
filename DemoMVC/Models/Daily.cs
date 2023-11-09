using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models;
[Table("Daily")]
public class Daily 
{
[Key]
    public string? MaDaily{get;set;}
    public string? TenDaily{get;set;}
    public string? Diachi{get;set;}
    public string? Nguoidaidien{get;set;}
    public string? Dienthoi{get;set;}
    public string? MaHTPP{get;set;}
    [ForeignKey("MaHTPP")]
        public  HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
}
