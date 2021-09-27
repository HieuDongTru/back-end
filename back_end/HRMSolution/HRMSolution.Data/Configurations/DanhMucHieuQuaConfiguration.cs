using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Configurations
{
    class DanhMucHieuQuaConfiguration : IEntityTypeConfiguration<DanhMucHieuQua>
    {
        public void Configure(EntityTypeBuilder<DanhMucHieuQua> builder)
        {
            builder.ToTable("DanhMucHieuQua");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.maDanhMuc).HasMaxLength(10);
            builder.Property(x => x.tenDanhMuc).HasMaxLength(50);
        }
    }
}
