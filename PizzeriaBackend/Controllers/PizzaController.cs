using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzeriaApp.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBackend.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {

            #region"Variable declaration"
            private readonly PizzeriaDbContext _context;
            private readonly IUnitOfWork _unitOfWork;
            #endregion

            public PizzaController(PizzeriaDbContext _context)
            {
                this._context = _context;
            }

            [HttpGet("Pizza")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public ActionResult<IEnumerable<Pizza>> Get()
            {

                {
                    var unitOfWork = new UnitOfWork(_context);
                    var result = unitOfWork.Pizza.GetAll();
                //foreach(var elem in result)
                //{
                //    elem.Toppings = JsonConvert.DeserializeObject<String>(elem.Toppings);
                //}

                if (result == null)
                    {
                        return NotFound();
                    }

                    return Ok(result);
                }


            }
        }
    
}
