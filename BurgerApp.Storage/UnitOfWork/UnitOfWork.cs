using BurgerApp.Storage.Database.Context;

namespace BurgerApp.Storage.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IBurgerDbContext _dbContext;
        public UnitOfWork(IBurgerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
