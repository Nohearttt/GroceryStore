using GroceryStore.Data.Interfaces;
using GroceryStore.Data.Models;

namespace GroceryStore.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories { get {
                return new List<Category> 
                { 
                    new Category{CategoryName = "Молочная продукция", description = "Пищевые продукты, вырабатываемые из молока."},
                    new Category{CategoryName = "Мясная продукция", description = "Скелетная поперечно-полосатая мускулатура животного с прилегающими к ней жировой и соединительной тканями, а также прилегающей костной тканью."}
                }; 
            }
        }
    }
}