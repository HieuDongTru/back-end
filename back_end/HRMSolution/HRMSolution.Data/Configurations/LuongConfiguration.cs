using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Configurations
{
    public class LuongConfiguration : IEntityTypeConfiguration<Luong>
    {
        public void Configure(EntityTypeBuilder<Luong> builder)
        {
            builder.ToTable("Luong");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.maHopDong).HasMaxLength(30);
            builder.Property(x => x.nhomLuong);
            builder.Property(x => x.heSoLuong);
            builder.Property(x => x.bacLuong).HasMaxLength(10);
            builder.Property(x => x.phuCapTrachNhiem);
            builder.Property(x => x.phuCapKhac);
            builder.Property(x => x.tongLuong);
            builder.Property(x => x.thoiHanLenLuong).HasMaxLength(10);
            builder.Property(x => x.ngayHieuLuc);
            builder.Property(x => x.ngayKetThuc);
            builder.Property(x => x.ghiChu).HasMaxLength(100);
        }
    }
}
