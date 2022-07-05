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

        public Burger GetBurger(int id)
        {
            return BurgerDatabase.BURGERS.SingleOrDefault(x => x.Id == id);
        }
        public IReadOnlyList<Burger> GetBurgers(Burger burger)
        {
            return BurgerDatabase.BURGERS.Where(x => x.Id == burger.Id).ToArray();
        }
    }
}
