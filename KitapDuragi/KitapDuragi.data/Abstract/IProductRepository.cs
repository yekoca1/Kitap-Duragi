using System.Collections.Generic;
using KitapDuragi.entity;

namespace KitapDuragi.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
       Product GetProductDetails(string url);
       Product GetByIdWithCategories(int id);
       List<Product> GetProductsByCategory(string name,int page,int pageSize);
       List<Product> GetSearchResult(string searchString);
       List<Product> GetHomePageProducts();
       int GetCountByCategory(string category);
       void Update(Product entity, int[] categoryIds);
    }
}