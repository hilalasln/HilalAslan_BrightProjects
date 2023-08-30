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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Url).IsRequired();

            builder.HasData(
            new Category
            {
                Id = 1,
                Name = "Resim",
                Description = "Resim kursları, sanatseverlere resim becerilerini geliştirme ve yaratıcılıklarını keşfetme fırsatı sunan bir eğitim programıdır. Bu kurslar, çeşitli resim teknikleri ve malzemeleri üzerinde odaklanırken, katılımcılara renk, kompozisyon ve perspektif gibi temel sanat prensiplerini öğretir. Öğrenciler, uzman ressamlardan rehberlik alırken, kendi sanatsal tarzlarını keşfeder ve eserlerini yaratıcı bir şekilde ifade ederler. Resim kursları, sanatı sevdiren, ilham veren ve katılımcılara güven veren bir ortamda sanatsal becerilerini geliştirmek isteyen herkes için idealdir.",
                Url = "resim"
            },
            new Category
            {
                Id = 2,
                Name = "Seramik Ve Çömlekçilik",
                Description = "Seramik ve çömlekçilik, binlerce yıllık bir geçmişe sahip olan zanaat ve sanat dalıdır. Bu disiplin, kilin şekillendirilmesi, pişirilmesi ve süslemesiyle özgün ve dayanıklı seramik eserlerin yaratılmasını içerir. Seramik ve çömlekçilik kursları, katılımcılara temel teknikleri öğretirken, el becerilerini ve yaratıcılıklarını geliştirme imkanı sunar. Öğrenciler, çömlek tekerleği kullanarak vazolar, tabaklar ve heykeller gibi çeşitli eserler yapabilir, glazelerle renklendirme ve dekorasyon tekniklerini öğrenebilirler. Bu kurslar, sanatsal ifadeye ilgi duyan ve kendi benzersiz seramik eserlerini yaratmak isteyen herkese hitap eder.",
                Url = "seramik-comlekcilik"
            },
            new Category
            {
                Id = 3,
                Name = "Mozaik",
                Description = "Mozaik kursları, katılımcılara renkli ve çarpıcı mozaik eserlerinin nasıl oluşturulacağını öğretmek için mükemmel bir fırsattır. Bu kurslar, mozaik sanatının temel prensiplerini ve tekniklerini kapsar. Öğrenciler, farklı renk ve şekillerdeki mozaik parçalarını kullanarak, çeşitli yüzeylere güzel desenler ve görüntüler oluşturabilir. Kurslar genellikle farklı mozaik malzemelerinin kullanımını, kesmeyi, yerleştirmeyi ve tutkalı içerir. Mozaik kursları, yaratıcılığı teşvik ederken, kişilerin el becerilerini geliştirmelerini ve kendilerini sanatla ifade etmelerini sağlar.",
                Url = "mozaik"
            },
            new Category
            {
                Id = 4,
                Name = "Cam İşleme",
                Description = "Cam işleme kursu, camın farklı tekniklerle şekillendirilmesi ve dekoratif eserlerin yapılmasını öğreten bir eğitim programıdır. Bu kurslar, cam kesme, cam eritme, cam füzyonu, cam süsleme ve cam oyma gibi çeşitli tekniklere odaklanabilir. Katılımcılar, camdan vazolar, heykeller, takılar, lambalar ve vitray panolar gibi çeşitli objeler oluşturabilir. Cam işleme kursları, camın ışığı yansıtma özelliği ve renk çeşitliliğiyle sanatsal ifade imkanı sağlar. Bu kurslar, el becerilerini geliştirmek isteyen, estetik açıdan etkileyici cam eserler yaratmak isteyen herkese hitap eder.",
                Url = "cam-isleme"
            },
            new Category
            {
                Id = 5,
                Name = "Ahşap İşleme",
                Description = "Cam işleme kursu, camın farklı tekniklerle şekillendirilmesi ve dekoratif eserlerin yapılmasını öğreten bir eğitim programıdır. Bu kurslar, cam kesme, cam eritme, cam füzyonu, cam süsleme ve cam oyma gibi çeşitli tekniklere odaklanabilir. Katılımcılar, camdan vazolar, heykeller, takılar, lambalar ve vitray panolar gibi çeşitli objeler oluşturabilir. Cam işleme kursları, camın ışığı yansıtma özelliği ve renk çeşitliliğiyle sanatsal ifade imkanı sağlar. Bu kurslar, el becerilerini geliştirmek isteyen, estetik açıdan etkileyici cam eserler yaratmak isteyen herkese hitap eder.",
                Url = "ahsap-isleme-sanati"
            },
            new Category
            {
                Id = 6,
                Name = "Güzel Sanatlar",
                Description = "",
                Url = "güzel-sanatlar"
            },
            new Category
            {
                Id = 7,
                Name = "El Sanatları",
                Description = "",
                Url = "el-sanatlari",

            },
            new Category
            {
                Id = 8,
                Name = "Hovi ve Sanat",
                Description = "",
                Url="hobi-ve-sanat"
            }) ;
        }
    }
}
