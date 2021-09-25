using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Configurations
{
    public class DanhMucToConfiguration : IEntityTypeConfiguration<DanhMucTo>
    {
        public void Configure(EntityTypeBuilder<DanhMucTo> builder)
        {
            builder.ToTable("DanhMucTo");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.maTo).HasMaxLength(10);
            builder.Property(x => x.tenTo).HasMaxLength(50);
            builder.Property(x => x.idPhongBan).HasMaxLength(5).IsRequired();
        }
    }
}
