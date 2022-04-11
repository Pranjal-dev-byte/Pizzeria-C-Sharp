using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzeriaApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBackend.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class CartItemController:ControllerBase
    {

        #region"Variable declaration"
        private readonly PizzeriaDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        public CartItemController(PizzeriaDbContext _context)
        {
            this._context = _context;
        }


        #region"GetCartContents"
        /// <summary>
        /// Get the cart contents
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        [HttpGet("GetCartContents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<CartItem>> GetCartContents(string Email)
        {

            {
                var unitOfWork = new UnitOfWork(_context);
                var result = unitOfWork.CartItem.Find(x=>x.Email==Email);
                
                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
        }
        #endregion

        #region"UpdateCartContents"
        /// <summary>
        /// Get the cart contents
        /// </summary>
        /// <returns></returns>
        [HttpPut("UpdateCartContents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<CartItem>> UpdateCartContents(CartItem cart)
        {  

            {
                var unitOfWork = new UnitOfWork(_context);
                //foreach(var cartItem in cart)
                //{

                //}
                var cartDetails = unitOfWork.CartItem.Find(x => x.Email == cart.Email).FirstOrDefault();

                //if (cartDetails.Count() == 0)
                //{
                //    return NotFound();
                //}
                //else
                //{

                //}
                cartDetails.PizzaOption = cart.PizzaOption;
                cartDetails.PizzaIngredients = cart.PizzaIngredients;
                unitOfWork.Complete();
                return Ok(cartDetails);
        //          public List<Pizza>? PizzaOption { get; set; }

        //public List<Ingredients>? PizzaIngredients { get; set; }
    }
        }
        #endregion
    }
}
