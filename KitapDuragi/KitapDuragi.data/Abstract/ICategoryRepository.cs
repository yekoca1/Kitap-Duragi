using System.Collections.Generic;
using KitapDuragi.entity;

namespace KitapDuragi.data.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Category GetByIdWithProducts(int categoryId);

        void DeleteFromCategory(int productId,int categoryId);
    }
}