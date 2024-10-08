using System.Collections.Generic;
using KitapDuragi.entity;

namespace KitapDuragi.webui.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}