using Microsoft.EntityFrameworkCore;
using TodoAppWithJWT.Models;
using TodoAppWithJWT.Data;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace TodoAppWithJWT.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}