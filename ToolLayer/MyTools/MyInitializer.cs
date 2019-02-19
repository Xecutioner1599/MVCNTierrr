using MVCNtier.DAL.Context;
using MVCNtier.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeData;
namespace ToolLayer.MyTools
{
    public class MyInitializer<T>:CreateDatabaseIfNotExists<T> where T:MyDBContext
    {
        protected override void Seed(T context)
        {
            AppUser ap = new AppUser();
            ap.UserName = "doruk";
            ap.Role = MVCNtier.MODEL.Enums.Role.Admin;
            ap.Password = "1234";
            ap.IsActive = true;
            ap.Email = "dorukocaal@gmail.com";

            context.Set<AppUser>().Add(ap);

            context.SaveChanges();

            AppUserDetail apd = new AppUserDetail();
            apd.FirstName = "Çağrı";
            apd.LastName = "Yolyapar";
            apd.Address = "Göztepe";
            apd.BirthDate = new DateTime(1987,10,6);
            apd.ID = ap.ID;


            for (int i = 0; i < 20; i++)
            {
                AppUser apMember = new AppUser();
                apMember.UserName = NameData.GetFirstName();
                apMember.Password = TextData.GetAlphaNumeric(8);
                apMember.IsActive = true;

                apMember.Email = $"{apMember.UserName}@gmail.com";
                context.Set<AppUser>().Add(apMember);
                context.SaveChanges();

                AppUserDetail apdMember = new AppUserDetail();
                apdMember.FirstName = apMember.UserName.ToUpper();
                apdMember.LastName = NameData.GetSurname.ToUpper();
                apdMember.ID = apMember.ID;
                apdMember.Address = PlaceData.GetAddress();
                apdMember.BirthDate =DateTime.
               



            }
        }
    }
}
