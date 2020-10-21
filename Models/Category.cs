using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverSideScripting_Assignment1B.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // CategoryId = Primary Key for Table

        public int FirstName { get; set; }

        // Create Category and Item Model relationship to show item list within this category.
        public List<Item>Items { get; set; }
    }
}
