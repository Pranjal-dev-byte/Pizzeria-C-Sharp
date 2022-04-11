namespace PizzeriaApp.Data
{
    public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(PizzeriaDbContext context) : base(context)
        {

        }
    }
}