using System.ComponentModel.DataAnnotations; // Inkludera DataAnnotations

namespace MyBookApp.Models;

public class Author
{
    // Properties 
    public int Id { get; set; } // Primärnyckel 

    [Required(ErrorMessage = "Du måste ange författare")]
    [Display(Name = "Författare")]
    public string? Name { get; set; }  // Författarens namn

    public List<Book>? Books { get; set; } // Kan ha skrivit flera böcker 
}
