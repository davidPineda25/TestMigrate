namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class DetailOrder{
    [Key]
    public Guid IdDetailOrder { get; set; } = Guid.NewGuid();
    public int Ammount { get; set; }
    public decimal UnitPrice { get; set;}

    public Guid IdOrder {get; set;}
    public Guid IdCustomer {get; set;}

    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;

}