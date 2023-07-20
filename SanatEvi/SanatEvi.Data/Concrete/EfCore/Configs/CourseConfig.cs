using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SanatEvi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatEvi.Data.Concrete.EfCore.Configs
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Url).IsRequired();
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.StartingDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired();
            builder.Property(x => x.Classtime).IsRequired();
            builder.Property(x => x.CurrentPerson).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.Courses).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new Course 
                { 
                    Id = 1,
                    Title = "Temel Resim Kursu",
                    Description = "Bu tür kurslar, resim yapmaya yeni başlayanlar için temel resim becerilerini öğretmeyi amaçlar. Renk teorisi, kompozisyon, perspektif, ışık-gölge gibi temel resim prensipleri ve teknikleri bu kurslar kapsamında öğretilebilir.",
                    Url ="temel-resim-kurslari",
                    ImageUrl = "temel-resim-kurslari.jpg",
                    StartingDate = new DateTime(2023, 8, 7),
                    EndDate = new DateTime(2023, 9, 18),
                    Classtime = "120 saat",
                    Price = 1000,
                    CurrentPerson = 25,
                    CategoryId = 1,
                },
                new Course 
                {
                    Id = 2,
                    Title = "Yağlı Boya Kursu",
                    Description= "Yağlı boya resim tekniğine odaklanan kurslardır. Yağlı boya malzemeleri, fırça teknikleri, renk karışımları ve tablo üzerinde çalışma gibi konular bu kurslar kapsamında ele alınır.",
                    Url = "yagli-boya-kursu",
                    ImageUrl = "yagli-boya-kursu.jpg",
                    StartingDate = new DateTime(2023, 7, 625),
                    EndDate = new DateTime(2023, 9, 1),
                    Classtime = "80 saat",
                    Price = 1200,
                    CurrentPerson = 25,
                    CategoryId = 1,
                },
                new Course 
                {
                    Id = 3,
                    Title = "Karakalem Kursu",
                    Description = "Karakalem tekniğiyle resim yapmayı öğretmeyi amaçlayan kurslardır. Karakalem fırçaları, tonlama, çizim teknikleri ve gölgelendirme gibi konular bu kurslar içinde yer alır.",
                    Url = "karakalem-kursu.jpg",
                    ImageUrl = "karakalem-kursu.jpg",
                    StartingDate = new DateTime(2023, 7, 16),
                    EndDate = new DateTime(2023, 8, 6),
                    Classtime = "70 saat",
                    Price = 800,
                    CurrentPerson = 25,
                    CategoryId = 1,
                },
                new Course 
                {
                    Id= 4,
                    Title = "Portre Resim Kursu",
                    Description = "Portre resim yapmayı öğretmeyi hedefleyen kurslardır. İnsan yüzünün anatomisi, yüz ifadeleri, ışık-gölge ilişkileri ve detaylandırma gibi konular bu kurslar kapsamında ele alınır.",
                    Url = "portre-resim-kursu",
                    ImageUrl = "portre-resim-kursu.jpg",
                    StartingDate = new DateTime(2023, 8, 11),
                    EndDate = new DateTime(2023, 9, 20),
                    Classtime = "100 saat",
                    Price = 1000,
                    CurrentPerson = 25,
                    CategoryId = 1,
                },
                new Course 
                {
                    Id= 5,
                    Title = "Akrilik Boya Kursu",
                    Description = "Akrilik boya kullanarak resim yapmayı öğretmeyi hedefleyen kurslardır. Akrilik boya malzemeleri, fırça teknikleri, renk geçişleri ve katmanlar gibi konular bu kurslar kapsamında ele alınır.",
                    Url = "akrilik-resim-kursu",
                    ImageUrl = "akrilik-resim-kursu.jpg",
                    StartingDate = new DateTime(2023, 7, 26),
                    EndDate = new DateTime(2023, 8, 13),
                    Classtime = "60 saat",
                    Price = 1400,
                    CurrentPerson = 25,
                    CategoryId = 1,
                },
                new Course 
                { 
                    Id= 6,
                    Title = "Temel Seramik Kursu",
                    Description= "Bu kurs, seramik malzemeleri, el şekillendirme teknikleri, kilin hazırlanması, merkezleme ve şekil verme gibi temel becerileri öğretir. Katılımcılar, çeşitli seramik formları oluşturma ve kilin pişirme sürecini deneyimleme fırsatı bulurlar.",
                    Url = "temel-seramik-kursu",
                    ImageUrl = "temel-seramik-kursu.jpg",
                    StartingDate = new DateTime(2023, 9, 6),
                    EndDate= new DateTime(2023, 10, 6),
                    Classtime = "100 saat",
                    Price = 1500,
                    CurrentPerson = 20,
                    CategoryId = 2,
                },
                new Course 
                {
                    Id= 7,
                    Title = "Çarkta Çömlekçilik Kursu",
                    Description = "Bu kurs, çömlekçilik tekerleği üzerinde çalışmayı öğretir. Katılımcılar, çömlekçilik tekerleği kullanarak çeşitli kaplar, vazolar veya tabaklar gibi formlar oluşturma becerilerini geliştirir. Ayrıca, eserlerin sonraki aşamaları olan kurutma, glazelenme ve pişirme süreçlerini de öğrenirler.",
                    Url = "carkta-comlekcilik-kursu",
                    ImageUrl = "carkta-comlekcilik-kursu.jpg",
                    StartingDate = new DateTime(2023, 10, 3),
                    EndDate = new DateTime(2023, 10, 30),
                    Classtime = "50 saat",
                    Price = 1400,
                    CurrentPerson = 20,
                    CategoryId = 2,
                },
                new Course 
                {
                    Id= 8,
                    Title = "Dekoratif Seramik Kursu",
                    Description = "Bu kurs, seramik parçaların dekoratif tekniklerle süslenmesini öğretir. Katılımcılar, boyama, sırlama, transfer baskı, kabartma ve serigrafi gibi farklı dekoratif yöntemleri kullanarak seramik eserlerini kişiselleştirme becerisini kazanırlar.",
                    Url = "dekoratif-seramik-kurs",
                    ImageUrl = "dekoratif-seramik-kurs.jpg",
                    StartingDate = new DateTime(2023, 8, 26),
                    EndDate = new DateTime(2023, 10, 31),
                    Classtime = "100 saat",
                    Price = 1000,
                    CurrentPerson = 20,
                    CategoryId = 2,
                },
                new Course 
                { 
                  Id = 9,
                  Title = "Temel Mozaik Kursu",
                  Description = "Bu kurs, mozaik sanatının temellerini öğretir. Mozaik malzemeleri seçme, kesme, düzenleme ve yapıştırma teknikleri gibi konuları kapsar. Katılımcılar, küçük projelerde pratik yaparak mozaik sanatına giriş yaparlar.",
                  Url = "temel-mozaik-kursu",
                  ImageUrl = "temel-mozaik-kursu.jpg",
                  StartingDate = new DateTime(2023, 7, 1),
                  EndDate = new DateTime(2023, 8, 30),
                  Classtime = "120 saat",
                  Price = 1100,
                  CurrentPerson = 20,
                  CategoryId = 3,
                },
                new Course 
                {
                    Id = 10,
                    Title = "Mozaik Tablo Kursu",
                    Description = "Bu kurs, mozaik tablolar oluşturmayı öğretir. Katılımcılar, ahşap bir tablo yüzeyine mozaik parçalarını yerleştirerek kişisel ve dekoratif bir tablo yapma becerilerini geliştirirler. Mozaik tasarımı, renk uyumu ve yapıştırma teknikleri kursun odak noktalarıdır.",
                    Url = "mozaik-tablo-kursu",
                    ImageUrl = "mozaik-tablo-kursu.jpg",
                    StartingDate = new DateTime(2023, 8, 4),
                    EndDate = new DateTime(2023, 9, 30),
                    Classtime = "85 saat",
                    Price= 1350,
                    CurrentPerson = 20,
                    CategoryId = 3,
                },
                new Course 
                {
                    Id = 11,
                    Title = "Vitray Cam Kursu",
                    Description = "Bu kurs, vitray cam tekniklerini öğretir. Katılımcılar, cam levhaları kesme, lehimleme ve farklı renklerdeki camları bir araya getirerek vitray pencereler, lambalar veya dekoratif cam paneller gibi ürünler yapmayı öğrenirler.",
                    Url = "vitray-cam-kursu",
                    ImageUrl = "vitray-cam-kursu.jpg",
                    StartingDate = new DateTime(2023, 7, 24),
                    EndDate = new DateTime(2023, 9, 1),
                    Classtime = "150 saat",
                    Price = 2000,
                    CurrentPerson = 20,
                    CategoryId = 4,
                },
                new Course 
                {
                    Id = 12,
                    Title = "Cam Kabartma Kursu",
                    Description = "Bu kurs, cam yüzeyine kabartma efektleri verme tekniklerini öğretir. Katılımcılar, cam levhaları ısıtma ve şekillendirme yöntemleriyle üç boyutlu desenler ve kabartmalar oluştururlar.",
                    Url = "cam-kabartma-kursu",
                    ImageUrl = "cam-kabartma-kursu.jpg",
                    StartingDate = new DateTime(2023, 8, 18),
                    EndDate = new DateTime(2023, 9, 30),
                    Classtime = "100 saat",
                    Price = 1000,
                    CurrentPerson = 25,
                    CategoryId = 4,
                },
                new Course 
                {
                    Id = 13,
                    Title = "Temel Ahşap İşleme Kursu",
                    Description = "Bu kurs, ahşap işleme tekniklerinin temellerini öğretir. Katılımcılar, ahşap malzemeleri kesme, şekillendirme, zımparalama ve birleştirme gibi temel becerileri kazanarak küçük projeler yaparlar.",
                    Url = "temel-ahsap-isleme-kursu",
                    ImageUrl = "temel-ahsap-isleme-kursu.jpg",
                    StartingDate = new DateTime(2023, 7, 10),
                    EndDate = new DateTime(2023, 9, 11 ),
                    Classtime = "130 saat",
                    Price= 1500,
                    CurrentPerson = 25,
                    CategoryId = 5,
                },
                new Course 
                {
                    Id = 14,
                    Title = "Ahşap Oyma Kursu",
                    Description = "Bu kurs, ahşap oyma sanatını öğretir. Katılımcılar, çeşitli oyma teknikleri kullanarak ahşap üzerine desenler ve kabartmalar oluştururlar. Ahşap oyma aletlerini kullanma becerilerini geliştirirler ve kendi oyma projelerini tamamlarlar.",
                    Url = "ahsap-oyma-kursu",
                    ImageUrl = "ahsap-oyma-kurs.jpg",
                    StartingDate = new DateTime(2023, 8, 20),
                    EndDate = new DateTime(2023, 9, 30),
                    Classtime = "100 saat",
                    Price = 1100,
                    CurrentPerson = 20,
                    CategoryId = 5,
                });
        }
    }
}
