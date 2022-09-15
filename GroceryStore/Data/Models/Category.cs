namespace GroceryStore.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string description { get; set; }
        public List<Product> Products { get; set; }
    }
}
