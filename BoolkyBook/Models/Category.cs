using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BoolkyBook.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1,1000,ErrorMessage = "Display order must be between 1 and 1000")]
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}