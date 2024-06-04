using System.ComponentModel.DataAnnotations.Schema;

namespace Redmango_API.Models;

public class CartItem{
    public Guid Id { get; set; }
    public Guid MenuItemId { get; set; }
    public int Quantity { get; set; }
    public Guid ShoppingCartId { get; set; }

    [ForeignKey("MenuItemId")]
    public MenuItem MenuItem { get; set; } = new();
}