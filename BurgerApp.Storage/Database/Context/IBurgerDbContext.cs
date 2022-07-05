using BurgerApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.Storage.Database.Context
{
    public interface IBurgerDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
