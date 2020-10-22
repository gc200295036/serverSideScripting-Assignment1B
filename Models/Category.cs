using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace serverSideScripting_Assignment1B.Models
{
    public class Category
    {
        public int CategoryId { get; set; } // CategoryId = Primary Key for Table
        // I had to lookup how to column name, I found that using data annotations will change the display for the column name, This is awesome for when I need to change category names without restarting a whole new database.
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        // Create Category and Item Model relationship to show item list within this category.
        public List<Item>Items { get; set; }
    }
}
