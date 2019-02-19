using MVCNtier.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNTier.MAP.Options
{
    public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Ürünler");
            Property(x => x.ImagePath).HasColumnName("Dosya Yolu").HasMaxLength(300);
            Property(x => x.ProductName).HasColumnName("Ürün İsmi").IsRequired().HasMaxLength(70);
            Property(x => x.UnitPrice).HasColumnName("Ürün Fiyatı").HasColumnType("money").IsOptional();
            Property(x => x.CategoryID).HasColumnName("KategoriID");
            Property(x => x.UnitsInStock).HasColumnName("Stoktaki ürün Sayısı").IsOptional();
        }
    }
}
