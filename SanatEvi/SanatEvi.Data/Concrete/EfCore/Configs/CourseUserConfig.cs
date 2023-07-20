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
    public class CourseUserConfig : IEntityTypeConfiguration<CourseUser>
    {
        public void Configure(EntityTypeBuilder<CourseUser> builder)
        {
            builder.HasKey(cu => new { cu.CourseId, cu.UserId });
            builder.HasData(
                new CourseUser { CourseId = 1, UserId = 1},
                new CourseUser { CourseId = 1, UserId = 2 },


                new CourseUser { CourseId = 2, UserId = 2 },
                new CourseUser { CourseId = 3, UserId = 1 });
        }
    }
}
