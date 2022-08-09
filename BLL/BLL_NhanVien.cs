using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();
        public BLL_NhanVien() { }
       public int themNV(string manv, string ten, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cmnd, string chucvu)
        {
           if(nv.themNV(manv, ten, ngaysinh, gioitinh, diachi, sdt, cmnd, chucvu )==1)
           {
                return 1;
           }
           return 0;
        }
        public int themTK(string taikhoan, string manv)
        {
            if (nv.themTK(taikhoan,manv) == 1)
            {
                return 1;
            }
            return 0;
        }
        public List<NHANVIEN> loadData()
        {
           return nv.getData();
            
        }
        public int suaNV( string manv, string ten, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cmnd, string chucvu)
        {
            if(nv.suaNV(manv,ten,ngaysinh, gioitinh,diachi,sdt,cmnd,chucvu)==1)
            {
                return 1;
            }
            return 0;
        }
        public int xoaNV(string manv)
        {
            if(nv.xoaNV(manv)==1)
            {
                return 1;

            }
            return 0;
        }
        public int doiPass(string manv , string matkhau)
        {
            if(nv.doiPass(manv, matkhau)==1)
            {
                return 1;

            }
            return 0;
        }
        public void xoaTKNV(string manv)
        {
            nv.xoaTKNV(manv);
        }
    }
}
