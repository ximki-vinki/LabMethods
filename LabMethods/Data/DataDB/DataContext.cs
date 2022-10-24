using LabMethods.Models.DBModels;
using Microsoft.EntityFrameworkCore;


namespace LabMethods.Data.DataDB
{
    internal class DataContext : DbContext
    {
        
        public DataContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AllmethodsDb.db");
        }

        public DbSet<LabMethod> LabMethods => Set<LabMethod>();
        public DbSet<TypeObject> TypeObjects => Set<TypeObject>();
    }
}
