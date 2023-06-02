using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BulkyBookWeb.Data
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
