namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
public class Category{
    [Key]
    public Guid IdCategory { get; set; } = Guid.NewGuid();
    public string CategoryName { get; set; } = null!; 

    public ICollection<Product> Product {get; set;} = null!;
}