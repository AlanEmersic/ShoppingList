using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingList.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(ShoppingList))]
        public int ShoppingListId { get; set; }
        public ShoppingList ShoppingList { get; set; }
    }
}
