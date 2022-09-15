using GroceryStore.Data.Interfaces;
using GroceryStore.Data.Models;

namespace GroceryStore.Data.Mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _CatogoryProducts = new MockCategory();
        public IEnumerable<Product> Products { get
            {
                return new List<Product>
                {
                    new Product{
                        Name = "Колбаса", 
                        ShortDescription = "Колбасное изделие.", 
                        LongDescription = "Классообразующий тип колбасных изделий, представляющий собой мясной фарш в продолговатой оболочке.", 
                        Img = "https://hmcaprise.ru/800/600/https/bringston.ru/upload/iblock/ba8/ba8c584df12c4a78fb966e2f114fca71.jpg", 
                        Price = 250, 
                        isFavorite = true, 
                        Available = true, 
                        Category = _CatogoryProducts.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Product> GetFavProducts { get; set; }

        public Product GetObjectProduct(int ProductId)
        {
            throw new NotImplementedException();
        }
    }
}
