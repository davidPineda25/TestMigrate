namespace Test.Domain.Entities;
using System.ComponentModel.DataAnnotations;
public class Comment{
    [Key]
    public Guid IdComment { get; set; } = Guid.NewGuid();
    public string Content { get; set; } = null!; 

}