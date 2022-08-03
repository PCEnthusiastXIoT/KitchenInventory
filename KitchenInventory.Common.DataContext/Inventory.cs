namespace KitchenInventory.Common.DataContext;
using Microsoft.EntityFrameworkCore;

public class Inventory : DbContext
{
    public DbSet<Condiment>? Condiments;
    public DbSet<Seasoning>? Seasonings;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connection = "Data Source=.;Initial Catalog=KitchenInventory;" +
            "Integrated Security=True";
        optionsBuilder.UseSqlServer(connection);
    }

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        // Auto Generate and require Id number
        modelBuilder.Entity<Condiment>()
            .Property(condiment => condiment.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();
        
        // Require Name and Enforce 50 Char limit
        modelBuilder.Entity<Condiment>()
            .Property(condiment => condiment.Name)
            .IsRequired()
            .HasMaxLength(50);

        // 10 Character limit on Unit name
        modelBuilder.Entity<Condiment>()
            .Property(condiment => condiment.Units)
            .HasMaxLength(10);

    }
}