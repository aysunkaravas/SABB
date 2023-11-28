using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SABB.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.DataAccess.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Surname).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Password).IsRequired();
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.CreateDate).IsRequired();
            builder.Property(p => p.Gender).IsRequired();
        }
    }
}
