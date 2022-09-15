using GroceryStore.Data.Models;

namespace GroceryStore.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get;}
        IEnumerable<Product> GetFavProducts { get; set; }
        Product GetObjectProduct(int ProductId);

    }
}
