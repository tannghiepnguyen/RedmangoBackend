using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Redmango_API.Data;
using Redmango_API.Models;

namespace Redmango_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        protected ApiResponse _response;
        private readonly ApplicationDbContext _db;

        public ShoppingCartController(ApplicationDbContext db)
        {
            _db = db;
            _response = new();
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetShoppingCart(String userId)
        {
            try
            {
                ShoppingCart shoppingCart;
                if (string.IsNullOrEmpty(userId))
                {
                    shoppingCart = new();
                }
                else
                {
                    shoppingCart = await _db.ShoppingCarts.Include(u => u.CartItems).ThenInclude(u => u.MenuItem)
                        .FirstOrDefaultAsync(u => u.UserId == userId);
                }
                if (shoppingCart.CartItems != null && shoppingCart.CartItems.Count > 0)
                {
                    shoppingCart.CartTotal = shoppingCart.CartItems.Sum(u => u.Quantity * u.MenuItem.Price);
                }
                _response.Result = shoppingCart;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { e.Message };
                _response.StatusCode = HttpStatusCode.BadRequest;
            }

            return _response;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> AddOrUpdateItemInCart(String userId, Guid menuItemId, int updateQuantityBy)
        {
            ShoppingCart shoppingCart = await _db.ShoppingCarts.Include(u => u.CartItems).FirstOrDefaultAsync(u => u.UserId == userId);
            MenuItem menuItem = await _db.MenuItems.FirstOrDefaultAsync(u => u.Id == menuItemId);
            if (menuItem == null)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                return BadRequest(_response);
            }

            if (shoppingCart == null && updateQuantityBy > 0)
            {
                ShoppingCart newCart = new()
                {
                    UserId = userId
                };
                await _db.ShoppingCarts.AddAsync(newCart);
                await _db.SaveChangesAsync();

                CartItem newCartItem = new()
                {
                    MenuItemId = menuItemId,
                    Quantity = updateQuantityBy,
                    ShoppingCartId = newCart.Id,
                    MenuItem = null
                };
                await _db.CartItems.AddAsync(newCartItem);
                await _db.SaveChangesAsync();
            }
            else
            {
                CartItem cartItemInCart = shoppingCart.CartItems.FirstOrDefault(u => u.MenuItemId == menuItemId);
                if (cartItemInCart == null)
                {
                    CartItem menuCartItem = new()
                    {
                        MenuItemId = menuItemId,
                        Quantity = updateQuantityBy,
                        ShoppingCartId = shoppingCart.Id,
                        MenuItem = null
                    };
                }
                else
                {
                    int newQuantity = cartItemInCart.Quantity + updateQuantityBy;
                    if (updateQuantityBy == 0 || newQuantity <= 0)
                    {
                        _db.CartItems.Remove(cartItemInCart);
                        if (shoppingCart.CartItems.Count == 1)
                        {
                            _db.ShoppingCarts.Remove(shoppingCart);
                            await _db.SaveChangesAsync();
                        }
                    }
                    else
                    {
                        cartItemInCart.Quantity = newQuantity;
                        await _db.SaveChangesAsync();
                    }
                }
            }
            return _response;
        }
    }
}
