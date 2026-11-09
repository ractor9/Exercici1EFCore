using Microsoft.EntityFrameworkCore;

namespace Ex1;

public class RefugiContext:DbContext
{
    public RefugiContext(){}
    //Mapegem els DBsets com mapejaven les taules a hibernate
    public DbSet<Animal> Animal { get; set; }
    public DbSet<Xip> Xip { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured) optionsBuilder.UseSqlite("Data Source=refugi.db");
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>()
            .HasOne(a => a.XipID)
            .WithOne(x => x.Animal)
            .HasForeignKey<Animal>("XipID")
            .IsRequired()
            .OnDelete(Delete(DeleteBehavior.Restrict);
    }
}