using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Configurations
{
    class HopDongConfiguration : IEntityTypeConfiguration<HopDong>
    {
        public void Configure(EntityTypeBuilder<HopDong> builder)
        {
            builder.ToTable("HopDong");
            builder.HasKey(x => x.maHopDong);
<<<<<<< HEAD
            builder.Property(x => x.maHopDong).HasMaxLength(30);
            builder.Property(x => x.ghiChu).HasMaxLength(300);
=======
            builder.Property(x => x.loaiHopDong);
            builder.Property(x => x.chucDanh);
            builder.Property(x => x.luongCoBan);
            builder.Property(x => x.hopDongTuNgay);
            builder.Property(x => x.hopDongDenNgay);
            builder.Property(x => x.ghiChu).HasMaxLength(50);
>>>>>>> parent of 3a8e8f8 (configuration all entity)
            builder.Property(x => x.maNhanVien).HasMaxLength(10).IsRequired();
        }
    }
}
