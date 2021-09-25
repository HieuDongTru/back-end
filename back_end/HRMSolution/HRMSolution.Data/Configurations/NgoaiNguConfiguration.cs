﻿using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Configurations
{
    public class NgoaiNguConfiguration : IEntityTypeConfiguration<NgoaiNgu>
    {
        public void Configure(EntityTypeBuilder<NgoaiNgu> builder)
        {
            builder.ToTable("NgoaiNgu");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.ngoaiNgu);
            builder.Property(x => x.ngayCap);
            builder.Property(x => x.trinhDo).HasMaxLength(50);
            builder.Property(x => x.noiCap).HasMaxLength(50);
            builder.Property(x => x.maNhanVien).HasMaxLength(10).IsRequired();
        }
    }
}
