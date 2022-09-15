using GroceryStore.Data.Models;

namespace GroceryStore.Data.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
