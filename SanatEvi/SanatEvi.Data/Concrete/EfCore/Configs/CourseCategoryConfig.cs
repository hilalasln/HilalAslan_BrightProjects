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
    public class CourseCategoryConfig : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.HasKey(cc => new { cc.CourseId, cc.CategoryId });
            builder.HasData(
                new CourseCategory { CourseId = 1, CategoryId = 1 },
                new CourseCategory { CourseId = 1, CategoryId = 6 },

                new CourseCategory { CourseId = 2, CategoryId = 1 },
                new CourseCategory { CourseId = 2, CategoryId = 6 },

                new CourseCategory { CourseId = 3, CategoryId = 1 },
                new CourseCategory { CourseId = 3, CategoryId = 6 },

                new CourseCategory { CourseId = 4, CategoryId = 1 },
                new CourseCategory { CourseId = 4, CategoryId = 6 },

                new CourseCategory { CourseId = 5, CategoryId = 1 },
                new CourseCategory { CourseId = 5, CategoryId = 6 },

                new CourseCategory { CourseId = 6, CategoryId = 2 },
                new CourseCategory { CourseId = 6, CategoryId = 7 },

                new CourseCategory { CourseId = 7, CategoryId = 2 },
                new CourseCategory { CourseId = 7, CategoryId = 7 },


                new CourseCategory { CourseId = 8, CategoryId = 2 },
                new CourseCategory { CourseId = 8, CategoryId = 7 },

                new CourseCategory { CourseId = 9, CategoryId = 3 },
                new CourseCategory { CourseId = 9, CategoryId = 7 },

                new CourseCategory { CourseId = 10, CategoryId = 3 },
                new CourseCategory { CourseId = 10, CategoryId = 8 },

                new CourseCategory { CourseId = 11, CategoryId = 4 },
                new CourseCategory { CourseId = 11, CategoryId = 8 },

                new CourseCategory { CourseId = 12, CategoryId = 4 },
                new CourseCategory { CourseId = 12, CategoryId = 7 },

                new CourseCategory { CourseId = 13, CategoryId = 5 },
                new CourseCategory { CourseId = 13, CategoryId = 8 },

                new CourseCategory { CourseId = 14, CategoryId = 5 },
                new CourseCategory { CourseId = 14, CategoryId = 8 });

        }
    }
}
