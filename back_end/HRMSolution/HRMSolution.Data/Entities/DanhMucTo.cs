using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.Entities
{
    public class DanhMucTo
    {
        public int id { get; set; }
        public string maTo { get; set; }
        public string tenTo { get; set; }
        public int idPhongBan { get; set; }
    }
}
