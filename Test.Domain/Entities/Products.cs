namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Product{
    [Key]
    public Guid IdProduct { get; set; } = Guid.NewGuid();
    public string ProductName { get; set; } = null!;
    public string Content { get; set; } = null!;
    public decimal Price { get; set; }
}