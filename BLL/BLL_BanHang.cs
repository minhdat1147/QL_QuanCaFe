using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_BanHang
    {
        DAL_BanHang bh = new DAL_BanHang();
        public int taoHD(string manv)
        {
            if( bh.taoHD(manv)==1)
            {
                return 1;
            }          
            return 0;

        }
        public List<HOADON>laymaHD()
        {
            return bh.laymaHD();
        }
        public List<DOUONG> layCombobox(string ma)
        {
            return bh.laycombox(ma);
        }
        public int them(int mahd, string maloai, string mathuoc, int sl, string dvt, int gia, int thanhtien)
        {
            if(bh.themCTHD(mahd, maloai, mathuoc, sl, dvt, gia, thanhtien)==1)
            {
                return 1;
            }    
            return 0;
        }
        public int themTam(int mahd, string maloai, string mathuoc, int sl, string dvt, int gia, int thanhtien)
        {
            if (bh.themTam(mahd, maloai, mathuoc, sl, dvt, gia, thanhtien) == 1)
            {
                return 1;
            }
            return 0;
        } 
        public List<CHITIETHD_TAM> loadData(int ma)
        {
            return bh.getLoai_TAM(ma);
        }
        public int xoaHDTam(int mahd)
        {
            if(bh.xoaHDTam(mahd)==1)
            {
                return 1;
            }
            return 0;
        }
        public int xoaHD(int mahd, string maloai,string tensp)
        {
            if(bh.xoaHD(mahd, maloai, tensp)==1)
            {
                return 1;
            }
            return 0;
        }
        public int UpdateHD1(int mahd, string maloai, string masp, int soluong, int thanhtien)
        {
            if (bh.suaHD(mahd, maloai, masp,soluong,thanhtien) == 1)
            {
                return 1;
            }
            return 0;
        }
        public void UpdateHDTam(int mahd, string tenloai, string tensp, int soluong, int thanhtien)
        {
            bh.suaHDTam(mahd, tenloai, tensp, soluong, thanhtien);
           
            
        }
        public void xoaHDTam1(int mahd, string tenloai, string tensp)
        {
            bh.xoaHDTam1(mahd, tenloai, tensp);
        }
        public void UpdateHD(int mahd, string makh, int tongtien)
        {
            bh.UpdateHD(mahd, makh, tongtien);
            
        }
        public void UpdateDiemKH(string makh, int diem, string mathe)
        {
            bh.UpdateDiemKH(makh, diem, mathe);
            
        }
        public List<HOADON> loadData1(string ngay1,string ngay2)
        {
            DateTime a = Convert.ToDateTime(ngay1);
            DateTime b = Convert.ToDateTime(ngay2);
            return bh.ThongKeHD(a,b);
        }
    }
   
}
