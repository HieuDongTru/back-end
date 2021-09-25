using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Configurations
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {

        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.maNhanVien);
            builder.Property(x => x.maNhanVien).HasMaxLength(10);
            builder.Property(x => x.hoTen).HasMaxLength(50);
            builder.Property(x => x.honNhan);
            builder.Property(x => x.ngaySinh);
            builder.Property(x => x.gioiTinh);
            builder.Property(x => x.dienThoai).HasMaxLength(16);
            builder.Property(x => x.dienThoaiKhac).HasMaxLength(16);
            builder.Property(x => x.diDong).HasMaxLength(16);
            builder.Property(x => x.facebook).HasMaxLength(25);
            builder.Property(x => x.skype).HasMaxLength(25);
            builder.Property(x => x.cccd).HasMaxLength(15);
            builder.Property(x => x.ngayCap);
            builder.Property(x => x.noiCap).HasMaxLength(25);
            builder.Property(x => x.noiSinh).HasMaxLength(150);
            builder.Property(x => x.queQuan).HasMaxLength(150);
            builder.Property(x => x.thuongTru).HasMaxLength(150);
            builder.Property(x => x.tamTru).HasMaxLength(150);
            builder.Property(x => x.danToc);
            builder.Property(x => x.tonGiao);
            builder.Property(x => x.ngheNghiep).HasMaxLength(50);
            builder.Property(x => x.chucVuHienTai).HasMaxLength(50);
            builder.Property(x => x.ngayTuyenDung);
            builder.Property(x => x.congViecChinh).HasMaxLength(50);
            builder.Property(x => x.ngayVaoBan);
            builder.Property(x => x.ngayChinhThuc);
            builder.Property(x => x.coQuanTuyenDung).HasMaxLength(50);
            builder.Property(x => x.ngachCongChuc);
            builder.Property(x => x.ngachCongChucNoiDung).HasMaxLength(50);
            builder.Property(x => x.ngayVaoDang);
            builder.Property(x => x.ngayVaoDangChinhThuc);
            builder.Property(x => x.ngayNhapNgu);
            builder.Property(x => x.ngayXuatNgu);
            builder.Property(x => x.quanHamCaoNhat).HasMaxLength(50);
            builder.Property(x => x.danhHieuCaoNhat).HasMaxLength(50);
            builder.Property(x => x.ngayVaoDoan);
            builder.Property(x => x.noiThamGia).HasMaxLength(50);
            builder.Property(x => x.laThuongBinh);
            builder.Property(x => x.laConChinhSach);
            builder.Property(x => x.thuongBinh).HasMaxLength(50);
            builder.Property(x => x.conChinhSach).HasMaxLength(50);
            builder.Property(x => x.bhxh).HasMaxLength(10);
            builder.Property(x => x.bhyt).HasMaxLength(10);
            builder.Property(x => x.atm).HasMaxLength(20);
            builder.Property(x => x.nganHang).HasMaxLength(50);
            builder.Property(x => x.phongBan);
            builder.Property(x => x.to);
            builder.Property(x => x.trangThaiLaoDong);
            builder.Property(x => x.ngayNghiViec);
            builder.Property(x => x.lyDoNghiViec).HasMaxLength(50);
            builder.Property(x => x.tinhChatLaoDong);
            builder.Property(x => x.anh);
            
        }
    }
}
