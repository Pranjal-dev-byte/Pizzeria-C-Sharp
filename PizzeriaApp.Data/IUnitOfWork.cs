using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace PizzeriaApp.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IIngredientsRepository Ingredients { get; }
        IPizzaRepository Pizza { get; }
        ICartItemRepository CartItem { get; }
        int Complete();
    }
}
