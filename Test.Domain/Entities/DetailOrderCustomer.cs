namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;

public class DetailOrderCustomer{
    [Key]
    public Guid IdDetailOrderCustomer { get; set; }
    public Guid IdOrder { get; set; }
    public Guid IdCustomer { get; set; }

    public Order Order { get; set; } = null!;
    public Customer Customer { get; set; } = null!;
}