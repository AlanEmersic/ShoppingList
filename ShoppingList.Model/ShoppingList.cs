using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Model
{
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
