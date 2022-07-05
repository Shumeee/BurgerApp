using BurgerApp.Domain.Entities;

namespace BurgerApp.Domain.Repositories
{
    public interface IBurgerRepository
    {
        IReadOnlyList<Burger> GetAllBurgers();
        Burger GetBurger(int id);
        IReadOnlyList<Burger> GetBurgers(Burger burger);
    }
}
