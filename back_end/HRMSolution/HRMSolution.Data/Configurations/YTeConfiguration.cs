using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Configurations
{
    public class YTeConfiguration : IEntityTypeConfiguration<YTe>
    {
        public void Configure(EntityTypeBuilder<YTe> builder)
        {
            builder.ToTable("YTe");
            builder.HasKey(x => x.maNhanVien);
            builder.Property(x => x.maNhanVien).HasMaxLength(10);
            builder.Property(x => x.nhomMau).HasMaxLength(5);
            builder.Property(x => x.chieuCao);
            builder.Property(x => x.canNang);
            builder.Property(x => x.tinhTrangSucKhoe).HasMaxLength(50);
            builder.Property(x => x.benhTat).HasMaxLength(50);
            builder.Property(x => x.luuY).HasMaxLength(50);
            builder.Property(x => x.khuyetTat);
        }
    }
}
