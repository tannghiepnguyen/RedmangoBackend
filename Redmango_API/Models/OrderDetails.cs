using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redmango_API.Models;

public class OrderDetails
{
    [Key]
    public Guid OrderDetailId { get; set; }
    [Required]
    public Guid OrderHeaderId { get; set; }
    [Required]
    public Guid MenuItemId { get; set; }
    [ForeignKey("MenuItemId")] 
    public MenuItem MenuItem { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public string ItemName { get; set; }
    [Required]
    public double Price { get; set; }
}