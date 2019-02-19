using MVCNtier.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNTier.MAP.Options
{
    public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Kategoriler");
            Property(x => x.CategoryName).HasColumnName("Kategori İsmi").IsRequired().HasMaxLength(50);
            Property(x => x.Description).HasColumnName("Açıklama").IsRequired().HasMaxLength(50);
        }
    }
}
