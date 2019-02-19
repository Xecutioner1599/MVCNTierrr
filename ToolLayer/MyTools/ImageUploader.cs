using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ToolLayer.MyTools
{
    public static class ImageUploader
    {
        public static string UploadImage(string serverPath, HttpPostedFile file)
        {
            if (file !=null)
            {
                Guid uniqueName = Guid.NewGuid();

                serverPath = serverPath.Replace("~", string.Empty);//Eğer gelen ServerPath parametresinde ~ diye işaret varsa boşlukla değiştirsin.

                string[] fileArray = file.FileName.Split('.');

                string extension = fileArray[fileArray.Length - 1].ToLower();

                string fileName = $"{uniqueName}.{extension}";//Burada oluşturduğumuz guid tipindeki değişkenlerimizle yakaladığımız extension'ı birşeltirip ondan sonra yeni bir değişkene atıyoruz.
                if (extension=="jpg"||extension=="gif"||extension=="png"||extension=="jpeg")
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath+file.FileName)))
                    {
                        return "Dosya zaten var";
                    }
                    else
                    {
                        string filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);
                        file.SaveAs(filePath);
                        return serverPath + fileName;
                    }
                }
                else
                {
                    return "Arkadaşım niye resim seçmiyorsun ?";
                }

                
            }

            return "Dosya Boş";
        }
    }
}
