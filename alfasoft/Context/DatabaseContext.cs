using alfasoft.Models;
using Microsoft.EntityFrameworkCore;

namespace alfasoft.Context
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options) { }

        public DbSet<ContactModel> Contacts { get; set; }

    }
}
