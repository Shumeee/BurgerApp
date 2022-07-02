using BurgerApp.Contracts.Services;
using BurgerApp.Contracts.ViewModels;
using BurgerApp.Domain.Entities;
using BurgerApp.Domain.Repositories;
using BurgerApp.Services.Mappers;

namespace BurgerApp.Services
{
    public class BurgerService : IBurgerService
    {
        private readonly IBurgerRepository _burgerRepository;
        public BurgerService(IBurgerRepository burgerRepository)
        {
            _burgerRepository = burgerRepository;
        }
        public IReadOnlyList<BurgerViewModel> GetAllBurgers()
        {
            IReadOnlyList<Burger> burgers = _burgerRepository.GetAllBurgers();
            return burgers.Select(x => x.ToBurgerViewModel()).ToArray();
        }
    }
}
