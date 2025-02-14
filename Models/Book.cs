using System.ComponentModel.DataAnnotations; // Inludera DataAnnotations

namespace MyBookApp.Models;

    public class Book
    {
        // Properties 
        public int Id { get; set; } // Primärnyckel 

        [Required(ErrorMessage = "Du måste ange titel")]
        [Display(Name = "Titel")]
        public string? Title { get; set; } // Bok-titel

        [Required(ErrorMessage = "Ange utgivningsår")]
        [Display(Name = "Utgivningsår")]
        public int PublishedYear { get; set; } // Publiceringsår

        [Display(Name = "Författare")]
        public int? AuthorId { get; set; } // FörfattarId, främmandenyckel

        [Display(Name = "Författare")]
        public Author? Author { get; set; } // Författare, knyt ihop med author-modell 

    }
