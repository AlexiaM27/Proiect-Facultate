using System.Collections.Generic;
using Goia_Alexia_Lab2.Models;

namespace Goia_Alexia_Lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
