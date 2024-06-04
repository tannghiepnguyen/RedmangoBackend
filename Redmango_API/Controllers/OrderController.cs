using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Redmango_API.Data;
using Redmango_API.Models;
using Redmango_API.Models.DTO;
using Redmango_API.Utility;

namespace Redmango_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private ApiResponse _response;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
            _response = new ApiResponse();
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetOrder(string? userId)
        {
            try
            {
                var orderHeaders = _db.OrderHeaders.Include(u => u.OrderDetails).ThenInclude(u => u.MenuItem)
                    .OrderByDescending(u => u.OrderHeaderId);
                if (!string.IsNullOrEmpty(userId))
                {
                    _response.Result = orderHeaders.Where(u => u.ApplicationUserId == userId);
                }
                else
                {
                    _response.Result = orderHeaders;
                }

                return Ok(_response);
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new() { e.Message };
            }

            return _response;
        }
        
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<ApiResponse>> GetOrder([FromRoute]Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var orderHeaders = _db.OrderHeaders.Include(u => u.OrderDetails).ThenInclude(u => u.MenuItem)
                    .Where(u => u.OrderHeaderId == id);
                if (orderHeaders == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                _response.Result = orderHeaders;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new() { e.Message };
            }

            return _response;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> CreateOrder([FromBody] OrderHeaderCreateDTO orderHeaderCreateDto)
        {
            try
            {
                OrderHeader order = new()
                {
                    ApplicationUserId = orderHeaderCreateDto.ApplicationUserId,
                    PickupEmail =orderHeaderCreateDto.PickupEmail,
                    PickupName = orderHeaderCreateDto.PickupName,
                    PickupPhoneNumber = orderHeaderCreateDto.PickupPhoneNumber,
                    OrderTotal = orderHeaderCreateDto.OrderTotal,
                    OrderDate = DateTime.Now,
                    StripePaymentIntentID = orderHeaderCreateDto.StripePaymentIntentID,
                    TotalItems = orderHeaderCreateDto.TotalItems,
                    Status = String.IsNullOrEmpty((orderHeaderCreateDto.Status)) ? SD.status_pending : orderHeaderCreateDto.Status
                };
                if (ModelState.IsValid)
                {
                    await _db.OrderHeaders.AddAsync(order);
                    await _db.SaveChangesAsync();
                    foreach (var orderDetailDTO in orderHeaderCreateDto.OrderDetailsDTO)
                    {
                        OrderDetails orderDetails = new()
                        {
                            OrderHeaderId = order.OrderHeaderId,
                            ItemName = orderDetailDTO.ItemName,
                            MenuItemId = orderDetailDTO.MenuItemId,
                            Price = orderDetailDTO.Price,
                            Quantity = orderDetailDTO.Quantity
                        };
                        await _db.OrderDetails.AddAsync(orderDetails);
                    }

                    await _db.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.Message };
            }

            return _response;
        }

        [HttpPut("{id:Guid}")]
        public async Task<ActionResult<ApiResponse>> UpdateOrderHeader([FromRoute]Guid id,
            [FromBody] OrderHeaderUpdateDTO orderHeaderUpdateDto)
        {
            try
            {
                if (orderHeaderUpdateDto == null || id != orderHeaderUpdateDto.OrderHeaderId)
                {
                    _response.IsSuccess = false;
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                OrderHeader orderFromDb = await _db.OrderHeaders.FirstOrDefaultAsync(u => u.OrderHeaderId == id);
                if (orderFromDb == null)
                {
                    _response.IsSuccess = false;
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }

                if (!string.IsNullOrEmpty(orderHeaderUpdateDto.PickupName))
                {
                    orderFromDb.PickupName = orderHeaderUpdateDto.PickupName;
                }
                if (!string.IsNullOrEmpty(orderHeaderUpdateDto.PickupPhoneNumber))
                {
                    orderFromDb.PickupPhoneNumber = orderHeaderUpdateDto.PickupPhoneNumber;
                }
                if (!string.IsNullOrEmpty(orderHeaderUpdateDto.PickupEmail))
                {
                    orderFromDb.PickupEmail = orderHeaderUpdateDto.PickupEmail;
                }
                if (!string.IsNullOrEmpty(orderHeaderUpdateDto.Status))
                {
                    orderFromDb.Status = orderHeaderUpdateDto.Status;
                }
                if (!string.IsNullOrEmpty(orderHeaderUpdateDto.StripePaymentIntentID))
                {
                    orderFromDb.StripePaymentIntentID = orderHeaderUpdateDto.StripePaymentIntentID;
                }

                await _db.SaveChangesAsync();
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.Message };
            }

            return _response;
        }
    }
}
