using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyUniverseData.Data;
using ToyUniverseData.Models;

namespace ToyUniverseData.Repository
{
    public interface IShoppingCartRepository : IBaseRepository<ShoppingCart>
    {
    }
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        public ShoppingCartRepository(ToyUniverseDbContext context) : base(context)
        {
        }
    }
}
