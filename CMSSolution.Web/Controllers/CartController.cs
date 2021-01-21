using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CMSSolution.Data.Context;
using CMSSolution.Web.Models.DTOs;
using CMSSolution.Web.Models.Extensions;
using CMSSolution.Web.Models.Vms;

namespace YMS5177_CMS.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CartController(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;

        public IActionResult Index()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();

            CartViewModel cartViewModel = new CartViewModel
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Price * x.Quantity)
            };

            return View(cartViewModel);
        }
    }
}
