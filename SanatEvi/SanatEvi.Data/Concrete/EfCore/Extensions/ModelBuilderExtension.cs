﻿using SanatEvi.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete.EfCore.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Rol Bilgileri
            List<Role> roles = new List<Role>
            {
                new Role { Name="Admin", Description="Yöneticilerin rolü bu.", NormalizedName="ADMIN"},
                new Role { Name="User", Description="Diğer tüm kullanıcıların rolü bu.", NormalizedName="USER"}
            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion
            #region Kullanıcı Bilgileri
            List<User> users = new List<User>
            {
                new User
                {
                    FirstName="Murat",
                    LastName="yılmaz",
                    UserName="admin",
                    NormalizedUserName="ADMIN",
                    Email="muratyilmaz@gmail.com",
                    NormalizedEmail="MURATYILMAZ@GMAIL.COM",
                    Gender="Erkek",
                    DateOfBirth= new DateTime(1983,6,12),
                    Address="Kemalpaşa Mh. Zühtübey Sk. No:12 D:3 Üsküdar",
                    City="İstanbul",
                    EmailConfirmed=true,
                    SecurityStamp="",
                    LockoutEnabled=true,
                    PhoneNumber="+905436478990",
                    PhoneNumberConfirmed=true
                },
                new User
                {
                    FirstName="Cemre",
                    LastName="Kendirli",
                    UserName="user",
                    NormalizedUserName="USER",
                    Email="cemrekendirli@gmail.com",
                    NormalizedEmail="CEMREKENDIRLI@GMAIL.COM",
                    Gender="Kadın",
                    DateOfBirth= new DateTime(1983,9,10),
                    Address="Barbaros Bulvarı Feda İş Hanı K:5 D:23 Beşiktaş",
                    City="İstanbul",
                    EmailConfirmed=true,
                    SecurityStamp="",
                    LockoutEnabled=true,
                    PhoneNumber="+904556677888",
                    PhoneNumberConfirmed=true
                }
            };
            modelBuilder.Entity<User>().HasData(users);
            #endregion
            #region Şifre İşlemleri
            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            #endregion
            #region Rol Atama İşlemleri
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>{ UserId=users[0].Id, RoleId=roles[0].Id },
                new IdentityUserRole<string>{ UserId=users[1].Id, RoleId=roles[1].Id }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion
            #region Alışveriş Sepeti İşlemleri
            List<Cart> carts = new List<Cart>
            {
                new Cart{ Id=1, UserId=users[0].Id},
                new Cart{ Id=2, UserId=users[1].Id}
            };
            modelBuilder.Entity<Cart>().HasData(carts);
            #endregion
        }
    }
}
