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
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Branch).IsRequired();
            builder.Property(x => x.EducationStatus).IsRequired().HasMaxLength(200);
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.About).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Url).IsRequired();
            builder.Property(x => x.PhotoUrl).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(200);
            builder.Property(x => x.City).IsRequired().HasMaxLength(100);

            builder.HasData(
                new Teacher
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Asaf",
                    Gender = "Erkek",
                    Branch = "Resim",
                    EducationStatus = "Lisans",
                    DateOfBirth = 1994,
                    About = "Yetenekli ve deneyimli bir resim sanatçısı ve eğitmenim. Sanatsal yeteneklerimi öğrencilere aktarmaktan keyif alıyorum ve onları motive ederek yaratıcılıklarını geliştirmelerine yardımcı oluyorum. Çeşitli sanatsal tekniklerle resim yapmayı öğretme konusunda uzmanım ve öğrencilerimin bireysel ihtiyaçlarına odaklanarak etkili dersler sunuyorum.",
                    Url = "ali-asaf",
                    PhotoUrl = "ali-asaf.jpg",
                    Phone = "02164785696",
                    Address = "Bahçelievler",
                    City = "İstanbul"
                },
                new Teacher
                {
                    Id = 2,
                    FirstName = "Zeynep",
                    LastName = "Hafsa",
                    Gender = "Kadın",
                    Branch = "Mozaik",
                    EducationStatus = "Lisans",
                    DateOfBirth = 1990,
                    About = "Tutkulu, motive edici ve öğrencilere ilham veren bir eğitmenim.Yaratıcı ve yenilikçi düşünce tarzıyla ders içeriğini zenginleştiriyorum.Sabırlı ve anlayışlı bir tutumla öğrencilerin özgüvenlerini artırıyorum.Takım çalışmasına yatkın ve iletişim becerileri güçlüyüm.",
                    Url = "zeynep-hafsa",
                    PhotoUrl = "zeynep-hafsa.jpg",
                    Phone = "05567789839",
                    Address = "Kadıköy",
                    City = "İstanbul",
                },
                new Teacher
                {
                    Id = 3,
                    FirstName = "Ahmet",
                    LastName = "Salih",
                    Gender = "Erkek",
                    Branch = "Seramik",
                    EducationStatus = "Lisans",
                    DateOfBirth = 1992,
                    About = "Seramik sanatında uzmanlaşmış, yaratıcı ve öğrenci odaklı bir seramik öğretmeniyim. 10 yılı aşkın deneyimimle öğrencilere sanatsal yeteneklerini geliştirmede rehberlik ettim. Çeşitli seramik teknikleri, döküm, el işçiliği ve glazürleme konusunda bilgi ve becerilere sahibim. Öğrencilerin sanatsal ifade ve özgüvenlerini artırmak için etkili ders planları ve projeler tasarlarım.",
                    Url = "ahmet-salih",
                    PhotoUrl = "ahmet-salih.jpg",
                    Phone = "05067782089",
                    Address = "Şirinevler",
                    City = "İstanbul"
                },
                new Teacher
                {
                    Id = 4,
                    FirstName = "Ela",
                    LastName = "Suna",
                    Gender = "Kadın",
                    Branch = "Ahşap",
                    EducationStatus = "Lisans",
                    DateOfBirth = 1990,
                    About = "Tecrübeli ahşap ustası ve tutkulu öğretmen olarak, öğrencilere ahşap işleme sanatını öğretme ve onların yaratıcı becerilerini geliştirme konusunda uzmanım. Eğitim materyallerini ve öğretim yöntemlerini kişiselleştirerek öğrencilerin ilgi ve ihtiyaçlarına uygun dersler sunarım. Motive edici bir yaklaşım benimseyerek öğrencilerin başarıya ulaşmasına katkıda bulunurum.",
                    Url = "ela-suna",
                    PhotoUrl = "ela-suna.jpg",
                    Phone = "05447658990",
                    Address = "Eyüp",
                    City = "İstanbul",
                },
                new Teacher
                {
                    Id=5,
                    FirstName="Genel",
                    LastName = "Eğitmen",
                    Gender = "Kadın",
                    Branch = "Güzel Sanatlar",
                    EducationStatus = "Lisans",
                    DateOfBirth=1990,
                    About = "Henüz bir eğitmen atanmadı.",
                    Url= "genel-egitmen",
                    PhotoUrl = "default-profile.jpg",
                    Phone = "05467678904",
                    Address = "Beşiktaş",
                    City = "İstanbul",

                });
        }
    }
}
