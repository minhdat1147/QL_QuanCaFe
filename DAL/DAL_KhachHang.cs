using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_KhachHang
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        public bool kt(string makh)
        {
            var q = from kh in cafe.KHACHHANGs
                    where kh.MAKH.Equals(makh)
                    select kh;
            return q.Count() != 0 ? true : false;
        }
        public List<KHACHHANG> loadData()
        {
            var q = from kh in cafe.KHACHHANGs select kh;
            return q.ToList();
        }
        public int themKH(string makh, string tenkh, string diachi, string sdt)
        {
            if(kt(makh)== true)
            {
                return 0;
            }
            KHACHHANG kh = new KHACHHANG();
            kh.MAKH = makh;
            kh.TENKH = tenkh;
            kh.DIACHI = diachi;
            kh.SDT = sdt;
            kh.DIEMTL = 0;
            kh.MATHE = "COP";
            cafe.KHACHHANGs.InsertOnSubmit(kh);
            cafe.SubmitChanges();
            return 1;
        }
        public int suaKH(string makh, string tenkh, string diachi, string sdt)
        {
            var q = from kh in cafe.KHACHHANGs
                    where kh.MAKH.Equals(makh)
                    select kh;
            if(q.Count() !=0)
            {
                q.First().TENKH = tenkh;
                q.First().DIACHI = diachi;
                q.First().SDT = sdt;
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoaKH(string makh)
        {
            var q = from kh in cafe.KHACHHANGs
                    where kh.MAKH.Equals(makh)
                    select kh;
            if(q.Count()!=0)
            {
                cafe.KHACHHANGs.DeleteOnSubmit(q.First());
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}
