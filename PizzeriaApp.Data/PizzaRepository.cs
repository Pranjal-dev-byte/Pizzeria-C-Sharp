using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaApp.Data
{
    public class PizzaRepository:GenericRepository<Pizza>,IPizzaRepository
    {
        public PizzaRepository(PizzeriaDbContext context) : base(context)
        {

        }

    }
}
