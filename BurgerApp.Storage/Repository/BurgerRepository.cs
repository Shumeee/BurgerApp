using BurgerApp.Domain.Entities;
using BurgerApp.Domain.Repositories;
using BurgerApp.Storage.Database;

namespace BurgerApp.Storage.Repository
{
    public class BurgerRepository : IBurgerRepository
    {
        public IReadOnlyList<Burger> GetAllBurgers()
        {
            return BurgerDatabase.BURGERS;
        }
    }
}
