using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_KhachHang
    {
        DAL_KhachHang kh = new DAL_KhachHang();
        public List<KHACHHANG>loadData()
        {
            return kh.loadData();
        }
        public int themKH(string ma, string ten, string diachi, string sdt)
        {
            if(kh.themKH(ma,ten,diachi,sdt)==1)
            {
                return 1;
            }
            return 0;
        }
        public int suaKH(string ma, string ten, string diachi, string sdt)
        {
            if(kh.suaKH(ma,ten,diachi,sdt)==1)
            {
                return 1;
            }
            return 0;
        }
        public int xoaKH(string makh)
        {
            if(kh.xoaKH(makh)==1)
            {
                return 1;
            }
            return 0;
        }
    }
}
