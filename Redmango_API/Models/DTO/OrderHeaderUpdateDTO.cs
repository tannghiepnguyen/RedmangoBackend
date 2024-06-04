using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redmango_API.Models.DTO;

public class OrderHeaderUpdateDTO
{
    [Key]
    public Guid OrderHeaderId { get; set; }
    [Required]
    public string PickupName { get; set; }
    [Required]
    public string PickupPhoneNumber { get; set; }
    [Required]
    public string PickupEmail { get; set; }
    
    public string StripePaymentIntentID { get; set; }
    public string Status { get; set; }
}