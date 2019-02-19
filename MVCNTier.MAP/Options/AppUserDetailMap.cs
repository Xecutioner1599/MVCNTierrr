using MVCNtier.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNTier.MAP.Options
{
    public class AppUserDetailMap:BaseMap<AppUserDetail>
    {
        public AppUserDetailMap()
        {
            ToTable("Kullanıcı Profilleri");

            Property(x => x.BirthDate).HasColumnName("Doğum tarihi").IsOptional();
            Property(x => x.FirstName).HasColumnName("İsim").IsRequired().HasMaxLength(30);
            Property(x => x.LastName).HasColumnName("Soyisim").IsRequired().HasMaxLength(30);
            Property(x => x.Address).HasColumnName("Adres").IsRequired().HasMaxLength(300);

        }
    }
}
