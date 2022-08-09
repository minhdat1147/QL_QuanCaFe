using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_DoUong
    {
       DAL_DoUong sp = new DAL_DoUong();
        public List<DOUONG> loadData()
        {
            return sp.getLoai();
        }
        public int themSP(string masp, string tensp, string dvt, int dongia, string maloai)
        {
            if (sp.them(masp, tensp, dvt, dongia, maloai) == 1)
            {
                return 1;
            }
            return 0;
        }
        public int suaSP(string masp, string tensp, string dvt, int dongia, string maloai)
        {
            if (sp.sua(masp, tensp, dvt, dongia, maloai) == 1)
            {
                return 1;
            }
            return 0;
        }
        public int xoa(string ma)
        {
            if (sp.xoa(ma) == 1)
            {
                return 1;
            }
            return 0;
        }
        public List<DOUONG> timkiem(string ten)
        {
            return sp.timkiem(ten);
        }
    }
}
