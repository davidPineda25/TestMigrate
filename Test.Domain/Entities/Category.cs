namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Category{
    [Key]
    public Guid IdCategory { get; set; } = Guid.NewGuid();
    public string CategoryName { get; set; } = null!; 
}