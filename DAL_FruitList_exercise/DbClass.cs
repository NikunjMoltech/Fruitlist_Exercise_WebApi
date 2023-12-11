using DAL_FruitList_exercise.Entity.Tables;
using Microsoft.EntityFrameworkCore;

namespace DAL_FruitList_exercise
{
    public class DbClass :DbContext
    {
        public DbSet<BudgetCount> BudgetCount { get; set; }
        public DbClass() { }    
        public DbClass(DbContextOptions opitons) :base(opitons) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BudgetCount>().HasNoKey();
        }
    }
}
