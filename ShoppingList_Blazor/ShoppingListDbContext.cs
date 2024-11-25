using Microsoft.EntityFrameworkCore;
using ShoppingList_Blazor.Models;

namespace ShoppingList_Blazor;

public class ShoppingListDbContext : DbContext
{
    public DbSet<ShoppingItem> ShoppingItems { get; set; }

    public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ShoppingItem>()
            .Property(item => item.Id)
            .ValueGeneratedNever(); // Ensures the Guid is manually set.
    }
}