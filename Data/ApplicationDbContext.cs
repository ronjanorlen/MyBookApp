using Microsoft.EntityFrameworkCore;
using MyBookApp.Models; // Inkludera modell 

namespace MyBookApp.Data;

public class ApplicationDbContext: DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

    }

    // Tabeller i databas 
    public DbSet<Book> Books { get; set; } // Böcker 
    public DbSet<Author> Authors { get; set; } // Författare 

}