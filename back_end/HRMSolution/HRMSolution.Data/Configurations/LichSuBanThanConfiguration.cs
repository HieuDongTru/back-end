using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Configurations
{
    public class LichSuBanThanConfiguration : IEntityTypeConfiguration<LichSuBanThan>
    {
        public void Configure(EntityTypeBuilder<LichSuBanThan> builder)
        {
            builder.ToTable("LichSuBanThan");
            builder.HasKey(x => x.maNhanVien);
            builder.Property(x => x.maNhanVien).HasMaxLength(10);
            builder.Property(x => x.biBatDiTu).HasMaxLength(1000);
            builder.Property(x => x.thamGiaChinhTri).HasMaxLength(1000);
            builder.Property(x => x.thanNhanNuocNgoai).HasMaxLength(1000);
        }
    }
}
