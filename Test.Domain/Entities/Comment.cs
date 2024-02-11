namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Comment{
    [Key]
    public Guid IdComment { get; set; } = Guid.NewGuid();
    public string Content { get; set; } = null!; 

    public Guid IdProduct { get; set; }
    public Guid IdCustomer { get; set; }

    public Product Product { get; set; } = null!;
    public Customer Customer { get; set; } = null!;
    
    

}