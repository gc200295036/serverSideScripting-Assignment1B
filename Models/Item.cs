using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverSideScripting_Assignment1B.Models
{
    public class Item
    {
        //start of creating my table this will give a unique ItemId to a persons contact information.
        // This would help a website keep track of what item is linked to a specific person.
        public int ItemId { get; set; } // ItemId = Primary Key for Table
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        //Foreign Key CategoryId Referenced, must be referenced here so it is useable in applicationdbcontext.cs for this code to work .HasConstraintName("FK_Items_CategoryId");
        public int CategoryId { get; set; }
        // Category creates relationship with our model category so we can show our list of items
        public Category Category { get; set; }

    }
}
