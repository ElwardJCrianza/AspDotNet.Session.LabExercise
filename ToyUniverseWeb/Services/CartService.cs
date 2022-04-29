using System;
using System.Linq;
using ToyUniverseData.Data;
using ToyUniverseData.Models;
using ToyUniverseData.Repository;
using ToyUniverseWeb.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace ToyUniverseWeb.Services
{
    public class CartService
    {
    }
    public interface ICartService
    {
        public PagedResult<Toy> GetToyPage(int currentPage);
    }

/*    public class CartService : GenericService, ICartService
    {
        private IShoppingCartRepository shoppingcartRepository;
        public CartService(IShoppingCartRepository shoppingcartRepository, ToyUniverseDbContext context) : base(context)
        {
            this.shoppingcartRepository = shoppingcartRepository;
        }
        public PagedResult<ShoppingCart> GetToyPage(int currentPage)
        {
            return GetPaged<ShoppingCart>(Context.Session.GetObject<List<ShoppingCart>>, 2);
        }
    }*/
}
