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
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Url).IsRequired();
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.CurrentPerson).IsRequired();
            builder.Property(x => x.IsHome).IsRequired();
            builder.HasOne(x => x.Teacher).WithMany(x => x.Courses).HasForeignKey(x => x.TeacherId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new Course
                {
                    Id = 1,
                    Name = "Temel Resim Kursu",
                    Description = "Bu tür kurslar, resim yapmaya yeni başlayanlar için temel resim becerilerini öğretmeyi amaçlar. Renk teorisi, kompozisyon, perspektif, ışık-gölge gibi temel resim prensipleri ve teknikleri bu kurslar kapsamında öğretilebilir.",
                    Duration = "120 saat",
                    Price = 1000,
                    Url = "temel-resim-kursu",
                    ImageUrl = "temel-resim-kursu.jpeg",
                    CurrentPerson = 25,
                    IsHome = true,
                    TeacherId = 1,

                },
                new Course
                {
                    Id = 2,
                    Name = "Yağlı Boya Kursu",
                    Description = "Yağlı boya resim tekniğine odaklanan kurslardır. Yağlı boya malzemeleri, fırça teknikleri, renk karışımları ve tablo üzerinde çalışma gibi konular bu kurslar kapsamında ele alınır.",
                    Duration = "80 saat",
                    Price = 1200,
                    Url = "yagli-boya-kursu",
                    ImageUrl = "yagli-boya-kursu.jpeg",
                    CurrentPerson = 25,
                    IsHome = true,
                    TeacherId = 1,
                },
                new Course
                {
                    Id = 3,
                    Name = "Karakalem Kursu",
                    Description = "Karakalem tekniğiyle resim yapmayı öğretmeyi amaçlayan kurslardır. Karakalem fırçaları, tonlama, çizim teknikleri ve gölgelendirme gibi konular bu kurslar içinde yer alır.",
                    Duration = "70 saat",
                    Price = 800,
                    Url = "kara-kalem-kursu",
                    ImageUrl = "kara-kalem-kursu.jpeg",
                    CurrentPerson = 25,
                    IsHome = true,
                    TeacherId = 1,
                },
                new Course
                {
                    Id = 4,
                    Name = "Portre Resim Kursu",
                    Description = "Portre resim yapmayı öğretmeyi hedefleyen kurslardır. İnsan yüzünün anatomisi, yüz ifadeleri, ışık-gölge ilişkileri ve detaylandırma gibi konular bu kurslar kapsamında ele alınır.",
                    Duration = "100 saat",
                    Price = 1000,
                    Url = "portre-resim-kursu",
                    ImageUrl = "portre-resim-kursu.jpeg",
                    CurrentPerson = 25,
                    IsHome = true,
                    TeacherId = 1,
                },
                new Course
                {
                    Id = 5,
                    Name = "Akrilik Boya Kursu",
                    Description = "Akrilik boya kullanarak resim yapmayı öğretmeyi hedefleyen kurslardır. Akrilik boya malzemeleri, fırça teknikleri, renk geçişleri ve katmanlar gibi konular bu kurslar kapsamında ele alınır.",
                    Duration = "60 saat",
                    Price = 1400,
                    Url = "akrilik-resim-kursu",
                    ImageUrl = "akrilik-resim-kursu.jpeg",
                    CurrentPerson = 25,
                    IsHome = true,
                    TeacherId = 1,
                },
                new Course
                {
                    Id = 6,
                    Name = "Temel Seramik Kursu",
                    Description = "Bu kurs, seramik malzemeleri, el şekillendirme teknikleri, kilin hazırlanması, merkezleme ve şekil verme gibi temel becerileri öğretir. Katılımcılar, çeşitli seramik formları oluşturma ve kilin pişirme sürecini deneyimleme fırsatı bulurlar.",
                    Duration = "100 saat",
                    Price = 1500,
                    Url = "temel-seramik-kursu",
                    ImageUrl = "temel-seramik-kursu.jpeg",
                    CurrentPerson = 20,
                    IsHome = true,
                    TeacherId = 3,
                },
                new Course
                {
                    Id = 7,
                    Name = "Çarkta Çömlekçilik Kursu",
                    Description = "Bu kurs, çömlekçilik tekerleği üzerinde çalışmayı öğretir. Katılımcılar, çömlekçilik tekerleği kullanarak çeşitli kaplar, vazolar veya tabaklar gibi formlar oluşturma becerilerini geliştirir. Ayrıca, eserlerin sonraki aşamaları olan kurutma, glazelenme ve pişirme süreçlerini de öğrenirler.",
                    Duration = "50 saat",
                    Price = 1400,
                    Url = "carkta-comlekcilik-kursu",
                    ImageUrl = "carkta-comlekcilik-kursu.jpeg",
                    CurrentPerson = 20,
                    IsHome = true,
                    TeacherId = 3,
                },
                new Course
                {
                    Id = 8,
                    Name = "Dekoratif Seramik Kursu",
                    Description = "Bu kurs, seramik parçaların dekoratif tekniklerle süslenmesini öğretir. Katılımcılar, boyama, sırlama, transfer baskı, kabartma ve serigrafi gibi farklı dekoratif yöntemleri kullanarak seramik eserlerini kişiselleştirme becerisini kazanırlar.",
                    Duration = "100 saat",
                    Price = 1000,
                    Url = "dekoratif-seramik-kursu",
                    ImageUrl = "dekoratif-seramik-kursu.jpeg",
                    CurrentPerson = 20,
                    IsHome = true,
                    TeacherId = 3,
                },
                new Course
                {
                    Id = 9,
                    Name = "Temel Mozaik Kursu",
                    Description = "Bu kurs, mozaik sanatının temellerini öğretir. Mozaik malzemeleri seçme, kesme, düzenleme ve yapıştırma teknikleri gibi konuları kapsar. Katılımcılar, küçük projelerde pratik yaparak mozaik sanatına giriş yaparlar.",
                    Duration = "120 saat",
                    Price = 1100,
                    Url = "temel-mozaik-kursu",
                    ImageUrl = "temel-mozaik-kursu.jpeg",
                    CurrentPerson = 20,
                    IsHome = true,
                    TeacherId = 2,
                },
                new Course
                {
                    Id = 10,
                    Name = "Mozaik Tablo Kursu",
                    Description = "Bu kurs, mozaik tablolar oluşturmayı öğretir. Katılımcılar, ahşap bir tablo yüzeyine mozaik parçalarını yerleştirerek kişisel ve dekoratif bir tablo yapma becerilerini geliştirirler. Mozaik tasarımı, renk uyumu ve yapıştırma teknikleri kursun odak noktalarıdır.",
                    Duration = "85 saat",
                    Price = 1350,
                    Url = "mozaik-tablo-kursu",
                    ImageUrl = "mozaik-tablo-kursu.jpeg",
                    CurrentPerson = 20,
                    IsHome = true,
                    TeacherId = 2,
                },
                new Course
                {
                    Id = 11,
                    Name = "Vitray Cam Kursu",
                    Description = "Bu kurs, vitray cam tekniklerini öğretir. Katılımcılar, cam levhaları kesme, lehimleme ve farklı renklerdeki camları bir araya getirerek vitray pencereler, lambalar veya dekoratif cam paneller gibi ürünler yapmayı öğrenirler.",
                    Url = "vitray-cam-kursu",
                    ImageUrl = "vitray-cam-kursu.jpeg",
                    Duration = "150 saat",
                    Price = 2000,
                    CurrentPerson = 20,
                    IsHome = true,
                    TeacherId = 2,
                },
                new Course
                {
                    Id = 12,
                    Name = "Cam Kabartma Kursu",
                    Description = "Bu kurs, cam yüzeyine kabartma efektleri verme tekniklerini öğretir. Katılımcılar, cam levhaları ısıtma ve şekillendirme yöntemleriyle üç boyutlu desenler ve kabartmalar oluştururlar.",
                    Url = "cam-kabartma-kursu",
                    ImageUrl = "cam-kabartma-kursu.jpeg",
                    Duration = "100 saat",
                    Price = 1000,
                    CurrentPerson = 25,
                    IsHome = true,
                    TeacherId = 2,
                },
                new Course
                {
                    Id = 13,
                    Name = "Temel Ahşap İşleme Kursu",
                    Description = "Bu kurs, ahşap işleme tekniklerinin temellerini öğretir. Katılımcılar, ahşap malzemeleri kesme, şekillendirme, zımparalama ve birleştirme gibi temel becerileri kazanarak küçük projeler yaparlar.",
                    Duration = "130 saat",
                    Price = 1500,
                    Url = "temel-ahsap-isleme-kursu",
                    ImageUrl = "temel-ahsap-isleme-kursu.jpeg",
                    CurrentPerson = 25,
                    IsHome = true,
                    TeacherId = 4,
                },
                new Course
                {
                    Id = 14,
                    Name = "Ahşap Oyma Kursu",
                    Description = "Bu kurs, ahşap oyma sanatını öğretir. Katılımcılar, çeşitli oyma teknikleri kullanarak ahşap üzerine desenler ve kabartmalar oluştururlar. Ahşap oyma aletlerini kullanma becerilerini geliştirirler ve kendi oyma projelerini tamamlarlar.",
                    Duration = "100 saat",
                    Price = 1100,
                    Url = "ahsap-oyma-kursu",
                    ImageUrl = "ahsap-oyma-kursu.jpeg",
                    CurrentPerson = 20,
                    IsHome = true,
                    TeacherId = 4,
                }); ;
        }
    }
}
