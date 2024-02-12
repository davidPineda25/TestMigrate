namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Customer{
    [Key]
    public Guid IdCustomer { get; set; } = Guid.NewGuid();
    public string CustomerName { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Email { get; set; } = null!;
    
    public ICollection<Order> Order { get; set; } = null!;
    public ICollection<DetailOrderCustomer> DetailOrderClient { get; set; } = null!;
}