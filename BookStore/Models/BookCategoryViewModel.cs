using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookCategoryViewModel
    {
        public List<Book> Books { get; set; }
        public SelectList Category { get; set; }
        public string BookCategory { get; set; }
        public string SearchString { get; set; }
    }
}
