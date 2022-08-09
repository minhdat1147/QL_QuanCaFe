using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhanVien
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
       public bool kt(string manv)
       {
            var q = from nv in cafe.NHANVIENs 
                    where nv.MANV.Equals(manv) 
                    select nv;
            return q.Count() != 0 ? true : false;
       }
        public List<NHANVIEN> getData()
        {
            var q = from nv in cafe.NHANVIENs select nv;
            return q.ToList();
        }
        public int themNV(string manv, string ten, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cmnd, string chucvu)
        {
            if(kt(manv) == true)
            {
                return 0;
            }
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = manv;
            nv.TENNV = ten;
            nv.NGAYSINH = ngaysinh;
            nv.GTINH = gioitinh;
            nv.DIACHI = diachi;
            nv.SDT = sdt;
            nv.CMND = cmnd;
            nv.CHUCVU = chucvu;
            nv.HINHANH = "NV01.jpg";
            cafe.NHANVIENs.InsertOnSubmit(nv);
            cafe.SubmitChanges();

            return 1;
        }
        public int themTK(string taikhoan, string manv)
        {
            if (kt(taikhoan) == true)
            {
                return 0;
            }
            DANGNHAP nv = new DANGNHAP();
            nv.TAIKHOAN = taikhoan;
            nv.MATKHAU = "123";
            nv.MANV = manv;        
            cafe.DANGNHAPs.InsertOnSubmit(nv);
            cafe.SubmitChanges();
            return 1;
        }

        public int suaNV(string manv,string tennv,DateTime ngaysinh, string gioitinh, string diachi, string sdt, string cmnd, string chucvu)
        {
            var q = from nv in cafe.NHANVIENs
                    where nv.MANV.Equals(manv)
                    select nv;
            if(q.Count() != 0)
            {
                q.First().TENNV = tennv;
                q.First().NGAYSINH = ngaysinh;
                q.First().GTINH = gioitinh;
                q.First().DIACHI = diachi;
                q.First().SDT = sdt;
                q.First().CMND = cmnd;
                q.First().CHUCVU = chucvu;
                cafe.SubmitChanges();
                return 1;

            }
            return 0;
        }
        public void xoaTKNV(string manv)
        {
            var q = from nv in cafe.DANGNHAPs
                    where nv.MANV.Equals(manv)
                    select nv;
            if (q.Count() != 0)
            {
                cafe.DANGNHAPs.DeleteOnSubmit(q.First());
                cafe.SubmitChanges();
            }
        }

        public int xoaNV(string manv)
        {
            var q = from nv in cafe.NHANVIENs
                    where nv.MANV.Equals(manv)
                    select nv;
            if(q.Count() != 0)
            {
                cafe.NHANVIENs.DeleteOnSubmit(q.First());
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }

        public int doiPass(string manv,string matkhau)
        {
            var q= from tk in cafe.DANGNHAPs
                   where tk.MANV.Equals(manv) 
                   select tk;
            if (q.Count() != 0)
            {            
                q.First().MATKHAU = matkhau;             
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}
