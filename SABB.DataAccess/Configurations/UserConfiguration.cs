using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SABB.Domain.Abstract;
using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasBaseType<Person>();

            builder.Property(u => u.DailyCalorieGoal).IsRequired();
            builder.Property(u => u.DietitianId).HasColumnName("DietitianId").IsRequired();
            builder.HasOne(u => u.Dietitian).WithMany(d => d.Users).HasForeignKey(u => u.DietitianId);

            
        }
    }
}
