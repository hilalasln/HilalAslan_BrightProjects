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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.EducationStatus).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(500);
            builder.Property(x => x.City).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Url).IsRequired();
            builder.Property(x => x.ImageUrl).IsRequired();

            builder.HasData(
                new User
                {
                    Id = "1",
                    FirstName = "Mehmet",
                    LastName = "Derik",
                    Gender = "Erkek",
                    EducationStatus = "Lisans",
                    DateOfBirth = 2000,
                    Address = "Halide Edip Adıvar Mahallesi Darülaceze Caddesi No:3A BOMONTİ / ŞİŞLİ",
                    City = "İstanbul",
                    Url = "mehmet-derik",
                    ImageUrl = "mehmet-derik.jpg",
                },
                new User
                {
                    Id = "2",
                    FirstName = "Selen",
                    LastName = "Sargın",
                    Gender = "Kadın",
                    EducationStatus = "Lisans",
                    DateOfBirth = 1998,
                    Address = "Meliha Avni Sezen Cad. Sakız Ağacı Sok. No: 47/C Esentepe",
                    City = "İstanbul",
                    Url = "selen-sargın",
                    ImageUrl = "selen-sargin.jpg",
                }

                );
        }
    }
}
