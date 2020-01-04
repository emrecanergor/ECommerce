using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerce.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>(){

                new Category(){Name="Kamera",Description="Kamera Ürünleri"},
                new Category(){Name="Bilgisayar",Description="Bilgisayar Ürünleri"},
                new Category(){Name="Elektronik",Description="Elektronik Ürünleri"},
                new Category(){Name="Telefon",Description="Telefon Ürünleri"},
                new Category(){Name="Beyaz Eşya",Description="Beyaz Eşya Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();


            List<Product> urunler = new List<Product>(){

                new Product(){Name="Canon Eos 1200D 18-55 mm Profesyonel Fotoğraf Makinesi",Description="Harika Bir Ürün Kullanması Çok Keyiflidir",Stock=500,IsApproved=true,CategoryId=1,Price=2500,IsHome=true,},
                new Product(){Name="Canon Eos 25g 18-55 mm Profesyonel Fotoğraf Makinesi",Description="Harika  Çok Keyiflidir",Stock=452,IsApproved=false,CategoryId=1,Price=846,IsHome=true,},
                new Product(){Name="Canon Abc Profesyonel Fotoğraf Makinesi",Description="Harika Bir Ürün Kullanması Keyiflidir",Stock=644,IsApproved=true,CategoryId=1,Price=86461,IsHome=false,},
                new Product(){Name="Canon Def Profesyonel Fotoğraf Makinesi",Description="Bir Ürün Kullanması Çok Keyiflidir",Stock=418,IsApproved=true,CategoryId=1,Price=4841,IsHome=true,},
                new Product(){Name="Canon GĞd Profesyonel Fotoğraf Makinesi",Description="Harika Bir  Çok Keyiflidir",Stock=156,IsApproved=true,CategoryId=1,Price=4555,IsHome=true,},
                new Product(){Name="Canon Fkm Profesyonel Fotoğraf Makinesi",Description="Harika  Kullanması Çok Keyiflidir",Stock=156,IsApproved=true,CategoryId=1,Price=515,IsHome=false,},


                new Product(){Name="Lenovo 25LD",Description="Muazzam Bir Pc Sende Al",Stock=45,IsApproved=true,CategoryId=2,Price=6814,IsHome=true,},
                new Product(){Name="Mac",Description="Muaz Pc Sende Al",Stock=564,IsApproved=true,CategoryId=2,Price=654654654,IsHome=true,},
                new Product(){Name="Hp",Description="Muazzam Pc  Al",Stock=6546,IsApproved=true,CategoryId=2,Price=654,IsHome=true,},
                new Product(){Name="Asus",Description="Muazzam Bir Sende Al",Stock=65465,IsApproved=true,CategoryId=2,Price=6,IsHome=false,},
                new Product(){Name="Casper",Description="Muazzam Pc Sende Al",Stock=4456456,IsApproved=true,CategoryId=2,Price=848,IsHome=true,}
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}