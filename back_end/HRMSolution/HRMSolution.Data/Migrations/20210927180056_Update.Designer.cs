﻿// <auto-generated />
using System;
using HRMSolution.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRMSolution.Data.Migrations
{
    [DbContext(typeof(HRMDbContext))]
    [Migration("20210927180056_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucChucDanh", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("maChucDanh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("phuCap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasDefaultValue(0f);

                    b.Property<string>("tenChucDanh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucChucDanh");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucChucVu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("maChucVu")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("phuCap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasDefaultValue(0f);

                    b.Property<string>("tenChucVu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucChucVu");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucChuyenMon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("maChuyenMon")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tenChuyenMon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucChuyenMon");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucDanToc", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucDanToc");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucHieuQua", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("maDanhMuc")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tenDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucHieuQua");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucKhenThuongKyLuat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucKhenThuongKyLuat");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucLoaiHopDong", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("maLoaiHopDong")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tenLoaiHopDong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucLoaiHopDong");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucNgachCongChuc", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenNgach")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucNgachCongChuc");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucNgoaiNgu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucNgoaiNgu");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucNguoiThan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucNguoiThan");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucPhongBan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("maPhongBan")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tenPhongBan")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucPhongBan");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucTinhChatLaoDong", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenTinhChat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("danhMucTinhChatLaoDongs");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucTo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idPhongBan")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<string>("maTo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tenTo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucTo");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucTonGiao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucTonGiao");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DanhMucTrinhDo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenTrinhDo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("DanhMucTrinhDo");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.DieuChuyen", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("chiTiet")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("chucVu")
                        .HasColumnType("int");

                    b.Property<string>("maNhanVien")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("ngayHieuLuc")
                        .HasColumnType("datetime");

                    b.Property<int>("phong")
                        .HasColumnType("int");

                    b.Property<int>("to")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("DieuChuyen");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.HinhThucDaoTao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenHinhThuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("HinhThucDaoTao");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.HopDong", b =>
                {
                    b.Property<string>("maHopDong")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("chucDanh")
                        .HasColumnType("int");

                    b.Property<string>("ghiChu")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("hopDongDenNgay")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("hopDongTuNgay")
                        .HasColumnType("datetime");

                    b.Property<int>("loaiHopDong")
                        .HasColumnType("int");

                    b.Property<float>("luongCoBan")
                        .HasColumnType("real");

                    b.Property<string>("maNhanVien")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("maHopDong");

                    b.ToTable("HopDong");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.LichSuBanThan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("biBatDiTu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maNhanVien")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("thamGiaChinhTri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thanNhanNuocNgoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("maNhanVien")
                        .IsUnique()
                        .HasFilter("[maNhanVien] IS NOT NULL");

                    b.ToTable("lichSuBanThans");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.LienHeKhanCap", b =>
                {
                    b.Property<string>("maNhanVien")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("diaChi")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("dienThoai")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("hoTen")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("quanHe")
                        .HasColumnType("int");

                    b.HasKey("maNhanVien");

                    b.ToTable("LienHeKhanCap");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.Luong", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bacLuong")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ghiChu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("heSoLuong")
                        .HasColumnType("real");

                    b.Property<string>("maHopDong")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("ngayHieuLuc")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<int>("nhomLuong")
                        .HasColumnType("int");

                    b.Property<float>("phuCapKhac")
                        .HasColumnType("real");

                    b.Property<float>("phuCapTrachNhiem")
                        .HasColumnType("real");

                    b.Property<string>("thoiHanLenLuong")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("tongLuong")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Luong");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.NgoaiNgu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("maNhanVien")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("ngayCap")
                        .HasColumnType("datetime");

                    b.Property<int>("ngoaiNgu")
                        .HasColumnType("int");

                    b.Property<string>("noiCap")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("trinhDo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("NgoaiNgu");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.NguoiThan", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diaChi")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("dienThoai")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("khac")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("maNhanVien")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime");

                    b.Property<string>("ngheNghiep")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("quanHe")
                        .HasColumnType("int");

                    b.Property<string>("tenNguoiThan")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("id");

                    b.ToTable("NguoiThan");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.NhanVien", b =>
                {
                    b.Property<string>("maNhanVien")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("anh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("atm")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("bhxh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("bhyt")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("cccd")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("chucVuHienTai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("coQuanTuyenDung")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("conChinhSach")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("congViecChinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("danToc")
                        .HasColumnType("int");

                    b.Property<string>("danhHieuCaoNhat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("diDong")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("dienThoai")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("dienThoaiKhac")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("facebook")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("hoChieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("honNhan")
                        .HasColumnType("int");

                    b.Property<bool>("laConChinhSach")
                        .HasColumnType("bit");

                    b.Property<bool>("laThuongBinh")
                        .HasColumnType("bit");

                    b.Property<string>("lyDoNghiViec")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("maSoThue")
                        .HasColumnType("int");

                    b.Property<int>("ngachCongChuc")
                        .HasColumnType("int");

                    b.Property<string>("ngachCongChucNoiDung")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nganHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ngayCapCCCD")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayCapHoChieu")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayChinhThuc")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayHetHanHoChieu")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayNghiViec")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayNhapNgu")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayThuViec")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayTuyenDung")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayVaoBan")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayVaoDang")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayVaoDangChinhThuc")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayVaoDoan")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ngayXuatNgu")
                        .HasColumnType("datetime");

                    b.Property<string>("ngheNghiep")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("noiCapCCCD")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("noiCapHoChieu")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("noiSinh")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("noiThamGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("phongBan")
                        .HasColumnType("int");

                    b.Property<string>("quanHamCaoNhat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("queQuan")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("skype")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("tamTru")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("thuongBinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("thuongTru")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("tinhChatLaoDong")
                        .HasColumnType("int");

                    b.Property<int>("to")
                        .HasColumnType("int");

                    b.Property<int>("tonGiao")
                        .HasColumnType("int");

                    b.Property<bool>("trangThaiLaoDong")
                        .HasColumnType("bit");

                    b.HasKey("maNhanVien");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.TrinhDoVanHoa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NhanVienmaNhanVien")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("chuyenNganh")
                        .HasColumnType("int");

                    b.Property<DateTime>("denThoiGian")
                        .HasColumnType("datetime");

                    b.Property<int>("hinhThucDaoTao")
                        .HasColumnType("int");

                    b.Property<string>("maNhanVien")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("tenTruong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("trinhDo")
                        .HasColumnType("int");

                    b.Property<DateTime>("tuThoiGian")
                        .HasColumnType("datetime");

                    b.HasKey("id");

                    b.HasIndex("NhanVienmaNhanVien");

                    b.ToTable("TrinhDoVanHoa");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.YTe", b =>
                {
                    b.Property<string>("maNhanVien")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("benhTat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("canNang")
                        .HasColumnType("real");

                    b.Property<float>("chieuCao")
                        .HasColumnType("real");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<bool>("khuyetTat")
                        .HasColumnType("bit");

                    b.Property<string>("luuY")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("nhomMau")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("tinhTrangSucKhoe")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("maNhanVien");

                    b.ToTable("YTe");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.LichSuBanThan", b =>
                {
                    b.HasOne("HRMSolution.Data.Entities.NhanVien", "NhanVien")
                        .WithOne("LichSuBanThan")
                        .HasForeignKey("HRMSolution.Data.Entities.LichSuBanThan", "maNhanVien");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.LienHeKhanCap", b =>
                {
                    b.HasOne("HRMSolution.Data.Entities.NhanVien", "NhanVien")
                        .WithOne("LienHeKhanCap")
                        .HasForeignKey("HRMSolution.Data.Entities.LienHeKhanCap", "maNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.TrinhDoVanHoa", b =>
                {
                    b.HasOne("HRMSolution.Data.Entities.NhanVien", "NhanVien")
                        .WithMany("TrinhDoVanHoas")
                        .HasForeignKey("NhanVienmaNhanVien");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.YTe", b =>
                {
                    b.HasOne("HRMSolution.Data.Entities.NhanVien", "NhanVien")
                        .WithOne("YTe")
                        .HasForeignKey("HRMSolution.Data.Entities.YTe", "maNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("HRMSolution.Data.Entities.NhanVien", b =>
                {
                    b.Navigation("LichSuBanThan");

                    b.Navigation("LienHeKhanCap");

                    b.Navigation("TrinhDoVanHoas");

                    b.Navigation("YTe");
                });
#pragma warning restore 612, 618
        }
    }
}
