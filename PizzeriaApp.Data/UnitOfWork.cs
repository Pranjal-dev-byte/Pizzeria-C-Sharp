using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaApp.Data
{
    public class UnitOfWork:IUnitOfWork
    {

        private readonly PizzeriaDbContext _context;    
        public UnitOfWork(PizzeriaDbContext context)
        {
            _context = context;
            Ingredients = new IngredientsRepository(_context);
            Pizza = new PizzaRepository(_context);
            CartItem = new CartItemRepository(_context);

        }

        public IIngredientsRepository Ingredients { get; private set; }
        public IPizzaRepository Pizza { get; private set; }

        public ICartItemRepository CartItem { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.SaveChanges();
        }
    }
}
