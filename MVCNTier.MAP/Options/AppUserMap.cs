using MVCNtier.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNTier.MAP.Options
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Kullanıcılar");
            Property(x => x.ActivationCode).HasColumnName("Aktivasyon");
            Property(x => x.IsBanned).HasColumnName("Yasaklı");
            Property(x => x.IsActive).HasColumnName("Aktif");
            Property(x => x.Password).HasColumnName("Şifre").HasMaxLength(100);
            Ignore(x => x.RePassword);
            Property(x => x.UserIdentity).HasColumnName("Bilgisayar İsmi");
            Property(x => x.UserName).HasColumnName("Kullanıcı İsmi").HasMaxLength(40).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.UserIP).HasColumnName("Bilgisayar Ip");
            Property(x => x.Role).HasColumnName("Rol").IsOptional();

            HasOptional(x => x.AppUserDetail).WithRequired(x => x.AppUser);//birebir ilişkiyi burada tamamlamış olduk..
        }
    }
}
