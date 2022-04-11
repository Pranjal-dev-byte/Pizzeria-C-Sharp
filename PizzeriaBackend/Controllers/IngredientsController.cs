using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzeriaApp.Data;
using PizzeriaBackend.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaBackend.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]

    public class IngredientsController : ControllerBase
    {
        #region"Variable declaration"
        private readonly PizzeriaDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        public IngredientsController(PizzeriaDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet("Ingredients")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Ingredients>> Get()
        {

                {
                    var unitOfWork = new UnitOfWork(_context);
                    var result = unitOfWork.Ingredients.GetAll();
                    if (result == null)
                    {
                        return NotFound();
                    }

                    return Ok(result);
                }
            

        }
    }
}
