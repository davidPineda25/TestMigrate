namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Order{
    [Key]
    public Guid IdOrder { get; set; } = Guid.NewGuid();
    public DateTime DateOrder { get; set; }

    public Guid IdCustomer { get; set; }

    public Customer Customer {get; set;} = null!;

    [JsonIgnore]
    public ICollection<DetailOrder> DetailOrder = null!;

    public ICollection<DetailOrderCustomer> DetailOrderClient { get; set; } = null!;

  
}