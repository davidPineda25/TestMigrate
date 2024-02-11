namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Order{
    [Key]
    public Guid IdOrder { get; set; } = Guid.NewGuid();
    public DateTime DateOrder { get; set; }

    public Guid IdCustomer { get; set; }

    public Customer Customer {get; set;} = null!;

    public ICollection<DetailOrder> DetailOrder = null!;
    
}