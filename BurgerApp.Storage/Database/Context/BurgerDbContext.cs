using BurgerApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BurgerApp.Storage.Database.Context
{
    public class BurgerDbContext : DbContext, IBurgerDbContext
    {

    }
}
