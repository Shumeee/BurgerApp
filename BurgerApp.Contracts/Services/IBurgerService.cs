using BurgerApp.Contracts.ViewModels;

namespace BurgerApp.Contracts.Services
{
    public interface IBurgerService
    {
        IReadOnlyList<BurgerViewModel> GetAllBurgers();
    }
}
