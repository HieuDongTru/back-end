using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMSolution.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMucChucDanh",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maChucDanh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    tenChucDanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phuCap = table.Column<float>(type: "real", nullable: false, defaultValue: 0f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucChucDanh", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucChucVu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maChucVu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    tenChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phuCap = table.Column<float>(type: "real", nullable: false, defaultValue: 0f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucChucVu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucChuyenMon",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenChuyenMon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    maChuyenMon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucChuyenMon", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucDanToc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucDanToc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucHieuQua",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maDanhMuc = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    tenDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucHieuQua", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucKhenThuongKyLuat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucKhenThuongKyLuat", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucLoaiHopDong",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maLoaiHopDong = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    tenLoaiHopDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucLoaiHopDong", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucNgachCongChuc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenNgach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucNgachCongChuc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucNgoaiNgu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucNgoaiNgu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucNguoiThan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucNguoiThan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucPhongBan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maPhongBan = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    tenPhongBan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucPhongBan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "danhMucTinhChatLaoDongs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTinhChat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danhMucTinhChatLaoDongs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucTo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maTo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    tenTo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    idPhongBan = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucTo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucTonGiao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenDanhMuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucTonGiao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucTrinhDo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTrinhDo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucTrinhDo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DieuChuyen",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ngayHieuLuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    phong = table.Column<int>(type: "int", nullable: false),
                    to = table.Column<int>(type: "int", nullable: false),
                    chucVu = table.Column<int>(type: "int", nullable: false),
                    chiTiet = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieuChuyen", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HinhThucDaoTao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenHinhThuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhThucDaoTao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    maHopDong = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    loaiHopDong = table.Column<int>(type: "int", nullable: false),
                    chucDanh = table.Column<int>(type: "int", nullable: false),
                    luongCoBan = table.Column<float>(type: "real", nullable: false),
                    hopDongTuNgay = table.Column<DateTime>(type: "datetime", nullable: false),
                    hopDongDenNgay = table.Column<DateTime>(type: "datetime", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.maHopDong);
                });

            migrationBuilder.CreateTable(
                name: "Luong",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maHopDong = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    nhomLuong = table.Column<int>(type: "int", nullable: false),
                    heSoLuong = table.Column<float>(type: "real", nullable: false),
                    bacLuong = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    phuCapTrachNhiem = table.Column<float>(type: "real", nullable: false),
                    phuCapKhac = table.Column<float>(type: "real", nullable: false),
                    tongLuong = table.Column<float>(type: "real", nullable: false),
                    thoiHanLenLuong = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ngayHieuLuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    ngayKetThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luong", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NgoaiNgu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngoaiNgu = table.Column<int>(type: "int", nullable: false),
                    ngayCap = table.Column<DateTime>(type: "datetime", nullable: false),
                    trinhDo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    noiCap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgoaiNgu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiThan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenNguoiThan = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    quanHe = table.Column<int>(type: "int", nullable: false),
                    ngheNghiep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    dienThoai = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    khac = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiThan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    honNhan = table.Column<int>(type: "int", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    dienThoai = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    dienThoaiKhac = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    diDong = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    facebook = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    skype = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    cccd = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ngayCap = table.Column<DateTime>(type: "datetime", nullable: false),
                    noiCap = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    noiSinh = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    queQuan = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    thuongTru = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    tamTru = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    danToc = table.Column<int>(type: "int", nullable: false),
                    tonGiao = table.Column<int>(type: "int", nullable: false),
                    ngheNghiep = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    chucVuHienTai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ngayTuyenDung = table.Column<DateTime>(type: "datetime", nullable: false),
                    ngayThuViec = table.Column<DateTime>(type: "datetime", nullable: false),
                    congViecChinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ngayVaoBan = table.Column<DateTime>(type: "datetime", nullable: false),
                    ngayChinhThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    coQuanTuyenDung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ngachCongChuc = table.Column<int>(type: "int", nullable: false),
                    ngachCongChucNoiDung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ngayVaoDang = table.Column<DateTime>(type: "datetime", nullable: false),
                    ngayVaoDangChinhThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    ngayNhapNgu = table.Column<DateTime>(type: "datetime", nullable: false),
                    ngayXuatNgu = table.Column<DateTime>(type: "datetime", nullable: false),
                    quanHamCaoNhat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    danhHieuCaoNhat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ngayVaoDoan = table.Column<DateTime>(type: "datetime", nullable: false),
                    noiThamGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    laThuongBinh = table.Column<bool>(type: "bit", nullable: false),
                    laConChinhSach = table.Column<bool>(type: "bit", nullable: false),
                    thuongBinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    conChinhSach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    bhxh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    bhyt = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    atm = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    nganHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phongBan = table.Column<int>(type: "int", nullable: false),
                    to = table.Column<int>(type: "int", nullable: false),
                    trangThaiLaoDong = table.Column<bool>(type: "bit", nullable: false),
                    ngayNghiViec = table.Column<DateTime>(type: "datetime", nullable: false),
                    lyDoNghiViec = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tinhChatLaoDong = table.Column<int>(type: "int", nullable: false),
                    anh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.maNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "lichSuBanThans",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    biBatDiTu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thamGiaChinhTri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thanNhanNuocNgoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichSuBanThans", x => x.id);
                    table.ForeignKey(
                        name: "FK_lichSuBanThans_NhanVien_maNhanVien",
                        column: x => x.maNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "maNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LienHeKhanCap",
                columns: table => new
                {
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    quanHe = table.Column<int>(type: "int", nullable: false),
                    dienThoai = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LienHeKhanCap", x => x.maNhanVien);
                    table.ForeignKey(
                        name: "FK_LienHeKhanCap_NhanVien_maNhanVien",
                        column: x => x.maNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "maNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrinhDoVanHoa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenTruong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    chuyenNganh = table.Column<int>(type: "int", nullable: false),
                    tuThoiGian = table.Column<DateTime>(type: "datetime", nullable: false),
                    denThoiGian = table.Column<DateTime>(type: "datetime", nullable: false),
                    hinhThucDaoTao = table.Column<int>(type: "int", nullable: false),
                    trinhDo = table.Column<int>(type: "int", nullable: false),
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NhanVienmaNhanVien = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrinhDoVanHoa", x => x.id);
                    table.ForeignKey(
                        name: "FK_TrinhDoVanHoa_NhanVien_NhanVienmaNhanVien",
                        column: x => x.NhanVienmaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "maNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YTe",
                columns: table => new
                {
                    maNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    nhomMau = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    chieuCao = table.Column<float>(type: "real", nullable: false),
                    canNang = table.Column<float>(type: "real", nullable: false),
                    tinhTrangSucKhoe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    benhTat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    luuY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    khuyetTat = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YTe", x => x.maNhanVien);
                    table.ForeignKey(
                        name: "FK_YTe_NhanVien_maNhanVien",
                        column: x => x.maNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "maNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lichSuBanThans_maNhanVien",
                table: "lichSuBanThans",
                column: "maNhanVien",
                unique: true,
                filter: "[maNhanVien] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TrinhDoVanHoa_NhanVienmaNhanVien",
                table: "TrinhDoVanHoa",
                column: "NhanVienmaNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhMucChucDanh");

            migrationBuilder.DropTable(
                name: "DanhMucChucVu");

            migrationBuilder.DropTable(
                name: "DanhMucChuyenMon");

            migrationBuilder.DropTable(
                name: "DanhMucDanToc");

            migrationBuilder.DropTable(
                name: "DanhMucHieuQua");

            migrationBuilder.DropTable(
                name: "DanhMucKhenThuongKyLuat");

            migrationBuilder.DropTable(
                name: "DanhMucLoaiHopDong");

            migrationBuilder.DropTable(
                name: "DanhMucNgachCongChuc");

            migrationBuilder.DropTable(
                name: "DanhMucNgoaiNgu");

            migrationBuilder.DropTable(
                name: "DanhMucNguoiThan");

            migrationBuilder.DropTable(
                name: "DanhMucPhongBan");

            migrationBuilder.DropTable(
                name: "danhMucTinhChatLaoDongs");

            migrationBuilder.DropTable(
                name: "DanhMucTo");

            migrationBuilder.DropTable(
                name: "DanhMucTonGiao");

            migrationBuilder.DropTable(
                name: "DanhMucTrinhDo");

            migrationBuilder.DropTable(
                name: "DieuChuyen");

            migrationBuilder.DropTable(
                name: "HinhThucDaoTao");

            migrationBuilder.DropTable(
                name: "HopDong");

            migrationBuilder.DropTable(
                name: "lichSuBanThans");

            migrationBuilder.DropTable(
                name: "LienHeKhanCap");

            migrationBuilder.DropTable(
                name: "Luong");

            migrationBuilder.DropTable(
                name: "NgoaiNgu");

            migrationBuilder.DropTable(
                name: "NguoiThan");

            migrationBuilder.DropTable(
                name: "TrinhDoVanHoa");

            migrationBuilder.DropTable(
                name: "YTe");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
