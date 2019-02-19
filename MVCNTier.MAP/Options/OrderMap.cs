using MVCNtier.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNTier.MAP.Options
{
    public class OrderMap:BaseMap<Order>
    {
        public OrderMap()
        {
            ToTable("Siparişler");
            Property(x => x.ShippedAddress).HasColumnName("Gönderim Adresi").IsRequired().HasMaxLength(50);
            Property(x => x.RequiredDate).HasColumnName("Son Gün").IsOptional();
            Property(x => x.AppUserID).HasColumnName("KullanıcıID").IsOptional();
        }
    }
}
