using EasyShop.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyShop.Perisistence.Data
{
    public class EasyShopDbContext : IdentityDbContext<User>
    {
        public EasyShopDbContext(DbContextOptions<EasyShopDbContext> options)
            : base(options)
        {
        }
    }
}
