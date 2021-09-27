using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Entities
{
    public class TrinhDoVanHoa
    {
        public int id { get; set; }
        public string tenTruong { get; set; }
        public int chuyenNganh { get; set; }
        public DateTime tuThoiGian { get; set; }
        public DateTime denThoiGian { get; set; }
        public int hinhThucDaoTao { get; set; }
        public int trinhDo { get; set; }
        public string maNhanVien { get; set; }

        public NhanVien NhanVien { get; set; }
    }
}
