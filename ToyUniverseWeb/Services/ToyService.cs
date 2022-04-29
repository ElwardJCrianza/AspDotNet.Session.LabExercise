using System;
using System.Linq;
using ToyUniverseData.Data;
using ToyUniverseData.Models;
using ToyUniverseData.Repository;
using ToyUniverseWeb.Models;


namespace ToyUniverseWeb.Services
{
    public interface IToyService
    {
        public PagedResult<Toy> GetToyPage(int currentPage);
    }

    public class ToyService: GenericService, IToyService
    {
        private IToyRepository toyRepository;
        public ToyService(IToyRepository toyRepository, ToyUniverseDbContext context) : base (context)
        {
            this.toyRepository = toyRepository;
        }
        public PagedResult<Toy> GetToyPage(int currentPage)
        {
            return GetPaged<Toy>(toyRepository.Context.Toys, currentPage, 5);
        }
    }
}
