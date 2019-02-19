using MVCNtier.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNTier.MAP.Options
{
    public abstract class BaseMap<T>:EntityTypeConfiguration<T> where T:BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.CreatedDate).HasColumnName("Oluşturma Tarihi").HasColumnType("datetime2");
            Property(x => x.ModifiedDate).HasColumnName("Güncelleme Tarihi").HasColumnType("datetime2");
            Property(x => x.CreatedBy).HasColumnName("Oluşturan Kişi").HasMaxLength(30);
            Property(x => x.ModifiedBy).HasColumnName("Güncelleyen Kişi").HasMaxLength(30);
            Property(x => x.Status).HasColumnName("Veri Durumu").IsOptional();
        }
        
    }
}
