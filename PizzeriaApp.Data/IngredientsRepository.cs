using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzeriaApp.Data
{
    public class IngredientsRepository : GenericRepository<Ingredients>,IIngredientsRepository
    {
        public IngredientsRepository(PizzeriaDbContext context) : base(context)
        {

        }


    }
}
