using HRMSolution.Data.Configurations;
using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.EF
{
    public class HRMDbContext : DbContext
    {
        public HRMDbContext( DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DanhMucChucDanhConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucChuyenMonConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucDanTocConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucHieuQuaConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucKhenThuongKyLuatConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucLoaiHopDongConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucNgachCongChucConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucNgoaiNguConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucNguoiThanConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucPhongBanConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucTinhChatLaoDongConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucToConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucTonGiaoConfiguration());
            modelBuilder.ApplyConfiguration(new DanhMucTrinhDoConfiguration());
            modelBuilder.ApplyConfiguration(new DieuChuyenConfiguration());
            modelBuilder.ApplyConfiguration(new HinhThucDaoTaoConfiguration());

            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<DanhMucChucDanh> danhMucChucDanhs { get; set; }
        public DbSet<DanhMucChucVu> danhMucChucVus { get; set; }
        public DbSet<DanhMucChuyenMon> danhMucChuyenMons { get; set; }
        public DbSet<DanhMucDanToc> danhMucDanTocs { get; set; }
        public DbSet<DanhMucHieuQua> danhMucHieuQuas { get; set; }
        public DbSet<DanhMucKhenThuongKyLuat> danhMucKhenThuongKyLuats { get; set; }
        public DbSet<DanhMucNgachCongChuc> danhMucNgachCongChucs { get; set; }
        public DbSet<DanhMucNgoaiNgu> danhMucNgoaiNgus { get; set; }
        public DbSet<DanhMucNguoiThan> danhMucNguoiThans { get; set; }
        public DbSet<DanhMucPhongBan> danhMucPhongBans { get; set; }
        public DbSet<DanhMucTinhChatLaoDong> danhMucTinhChatLaoDongs { get; set; }
        public DbSet<DanhMucTo> danhMucTos { get; set; }
        public DbSet<DanhMucTonGiao> danhMucTonGiaos { get; set; }
        public DbSet<DanhMucTrinhDo> danhMucTrinhDos { get; set; }
        public DbSet<DieuChuyen> dieuChuyens { get; set; }
        public DbSet<HinhThucDaoTao> hinhThucDaoTaos { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<LichSuBanThan> lichSuBanThans { get; set; }
        public DbSet<LienHeKhanCap> lienHeKhanCaps { get; set; }
        public DbSet<Luong> luongs { get; set; }
        public DbSet<NgoaiNgu> ngoaiNgus { get; set; }
        public DbSet<NguoiThan> nguoiThans { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<TrinhDoVanHoa> trinhDoVanHoas { get; set; }
        public DbSet<YTe> yTes { get; set; }


    }
}
