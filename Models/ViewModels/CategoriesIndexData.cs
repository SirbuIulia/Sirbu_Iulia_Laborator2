using Sirbu_Iulia_Laborator2.Models;

namespace Sirbu_Iulia_Laborator2.Models.ViewModels
{
    public class CategoriesIndexData
    {
        public IEnumerable<Category> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
