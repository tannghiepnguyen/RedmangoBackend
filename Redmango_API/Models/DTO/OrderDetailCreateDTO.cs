using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redmango_API.Models.DTO;

public class OrderDetailCreateDTO
{
    [Required]
    public Guid MenuItemId { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public string ItemName { get; set; }
    [Required]
    public double Price { get; set; }
}