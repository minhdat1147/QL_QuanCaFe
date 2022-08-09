using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_BanHang
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        public bool kt(int mahd, string masp)
        {
            var p = from l in cafe.CHITIETHDs
                    where l.MAHD.Equals(mahd) && l.MASP.Equals(masp)
                    select l;
            return p.Count() == 0 ? false : true;
        }
        public List<HOADON> laymaHD()
        {
            var q = (from s in cafe.HOADONs orderby s.MAHD descending select s).Take(1);
            return q.ToList();
        }
        public List<CHITIETHD> getLoai(int mahd)
        {
            var q = from l in cafe.CHITIETHDs
                    where l.MAHD.Equals(mahd)
                    select l;
            return q.ToList();
        }
        public List<CHITIETHD_TAM> getLoai_TAM(int mahd)
        {
            var q = from l in cafe.CHITIETHD_TAMs
                    where l.MAHD.Equals(mahd)
                    select l;
            return q.ToList();
        }
        public List<DOUONG> laycombox(string ma)
        {
            var q = (from s in cafe.DOUONGs where s.MALOAI.Equals(ma) select s);
            return q.ToList();
        }
        //public List<ChiTietHD> UDTongTien(int mahd)
        //{
        //    var q = (from s in NTT.ChiTietHDs where s.MaHD.Equals(mahd) select s);
        //    return q.ToList();
        //}
        public int taoHD(string manv)
        {       
            HOADON hd = new HOADON();
            hd.MANV = manv;
            hd.NGAYLAP = System.DateTime.Now.Date;
            hd.TONGTIEN = 0;
            cafe.HOADONs.InsertOnSubmit(hd);
            cafe.SubmitChanges();
            return 1;
        }
        public int themCTHD(int mahd, string maloai, string masp, int sl, string dvt, int gia, int thanhtien)
        {
            if (kt(mahd, masp) == true)
            {
                return 0;
            }
            CHITIETHD cthd = new CHITIETHD();
            cthd.MAHD = mahd;
            cthd.MALOAI = maloai;
            cthd.MASP = masp;
            cthd.SOLUONG = sl;
            cthd.DVT = dvt;
            cthd.DONGIA = gia;
            cthd.THANHTIEN = thanhtien;
            cafe.CHITIETHDs.InsertOnSubmit(cthd);

            cafe.SubmitChanges();
            return 1;
        }
        public int themTam(int mahd, string tenloai, string tensp, int sl, string dvt, int gia, int thanhtien)
        {

            CHITIETHD_TAM cthd = new CHITIETHD_TAM();
            cthd.MAHD = mahd;
            cthd.TENLOAI = tenloai;
            cthd.TENSP = tensp;
            cthd.SOLUONG = sl;
            cthd.DVT = dvt;
            cthd.DONGIA = gia;
            cthd.THANHTIEN = thanhtien;
            cafe.CHITIETHD_TAMs.InsertOnSubmit(cthd);
            cafe.SubmitChanges();
            return 1;

        }
        public int UpdateHD(int mahd, string makh, int tongtien)
        {
            var q = from l in cafe.HOADONs
                    where l.MAHD.Equals(mahd) 
                    select l;
            if (q.Count() != 0)
            {
                q.First().MAKH = makh;
                q.First().TONGTIEN = tongtien;
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
       public int UpdateDiemKH(string makh, int diem, string mathe)
        {
            var q = from l in cafe.KHACHHANGs
                    where l.MAKH.Equals(makh)
                    select l;
            if (q.Count() != 0)
            {
                q.First().DIEMTL = diem;
                q.First().MATHE = mathe;
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int suaHD(int mahd, string maloai, string masp, int soluong, int thanhtien)
        {
            var q = from l in cafe.CHITIETHDs
                    where l.MAHD.Equals(mahd) && l.MALOAI.Equals(maloai) && l.MASP.Equals(masp)
                    select l;
            if (q.Count() != 0)
            {
                q.First().SOLUONG = soluong;
                q.First().THANHTIEN = thanhtien;
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public void suaHDTam(int mahd, string tenloai, string tensp, int soluong,  int thanhtien)
        {
            var q = from l in cafe.CHITIETHD_TAMs
                    where l.MAHD.Equals(mahd) && l.TENLOAI.Equals(tenloai) && l.TENSP.Equals(tensp)
                    select l;
            if (q.Count() != 0)
            {
                q.First().SOLUONG = soluong;         
                q.First().THANHTIEN = thanhtien;
                cafe.SubmitChanges();
            }

        }
        //public int UpdateTT(int mahd, int tongtien)
        //{
        //    var q = from l in NTT.HoaDons
        //            where l.MaHD.Equals(mahd)
        //            select l;
        //    if (q.Count() != 0)
        //    {
        //        q.First().TongTien = tongtien;
        //        NTT.SubmitChanges();
        //        return 1;
        //    }
        //    return 0;
        //}
        public int xoaHD(int mahd, string maloai, string masp)
        {
            var q = from l in cafe.CHITIETHDs
                    where l.MAHD.Equals(mahd) && l.MALOAI.Equals(maloai) && l.MASP.Equals(masp)
                    select l;
            if (q.Count() != 0)
            {
                cafe.CHITIETHDs.DeleteOnSubmit(q.First());
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public void xoaHDTam1(int mahd, string tenloai, string tensp)
        {
            var q = from l in cafe.CHITIETHD_TAMs
                    where l.MAHD.Equals(mahd) && l.TENLOAI.Equals(tenloai) && l.TENSP.Equals(tensp)
                    select l;
            if (q.Count() != 0)
            {
                cafe.CHITIETHD_TAMs.DeleteOnSubmit(q.First());
                cafe.SubmitChanges();
            }
        }
        public int xoaHDTam(int mahd)
        {
            mahd = mahd - 1;
            var q = from l in cafe.CHITIETHD_TAMs
                    where l.MAHD.Equals(mahd)
                    select l;
            if (q.Count() != 0)
            {
                cafe.CHITIETHD_TAMs.DeleteAllOnSubmit(q);
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public List<HOADON> ThongKeHD(DateTime ngay1,DateTime ngay2)
        {
            var q = from hd in cafe.HOADONs
                    where hd.NGAYLAP>=ngay1.Date && hd.NGAYLAP<=ngay2.Date
                    select hd;
            return q.ToList();
        }
    }
}
