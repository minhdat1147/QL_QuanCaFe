using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_NhapHang
    {
        DAL_NhapHang nh = new DAL_NhapHang();
        public int taoPN(string manv)
        {
            if (nh.taoPN(manv) == 1)
            {
                return 1;
            }
            return 0;

        }
        public List<PHIEUNHAP> layMaPN()
        {
            return nh.layMaPN();
        }
        public List<DOUONG> layCombobox(string ma)
        {
            return nh.laycombox(ma);
        }
        public int them(int mapn, string maloai, string mathuoc, int sl, string dvt, int gia, int thanhtien)
        {
            if (nh.themCTHD(mapn, maloai, mathuoc, sl, dvt, gia, thanhtien) == 1)
            {
                return 1;
            }
            return 0;
        }
        public int themTam(int mapn, string maloai, string mathuoc, int sl, string dvt, int gia, int thanhtien)
        {
            if (nh.themTam(mapn, maloai, mathuoc, sl, dvt, gia, thanhtien) == 1)
            {
                return 1;
            }
            return 0;
        }
    }
}
