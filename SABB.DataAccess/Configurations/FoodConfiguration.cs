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
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(f => f.Id).HasColumnName("FoodId").IsRequired();
            builder.Property(f => f.Name).IsRequired();
            builder.Property(f => f.Calories).IsRequired();
            builder.Property(f => f.Description).IsRequired();
            builder.Property(f => f.Status).IsRequired();
            builder.Property(f => f.FoodType).IsRequired();
        }
    }
}
