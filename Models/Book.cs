using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sirbu_Iulia_Laborator2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")]

        [Required(ErrorMessage = "Titlul trebuie completat obligatoriu!")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Title trebuie aiba o lungime minima de 3 caractere si o lungime maxima de 150 de caractere.")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]

        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        public int? BorrowingID { get; set; }
        public Borrowing? Borrowing { get; set; } 

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
