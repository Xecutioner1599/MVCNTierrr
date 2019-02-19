using MVCNtier.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNTier.MAP.Options
{
    public class OrderDetailMap:BaseMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("Satışlar");
            Property(x => x.OrderID).HasColumnName("SiparişID");
            Property(x => x.ProductID).HasColumnName("ProductID");

            HasKey(x => new { x.OrderID, x.ProductID });

            Ignore(x => x.ID);

        }
    }
}
