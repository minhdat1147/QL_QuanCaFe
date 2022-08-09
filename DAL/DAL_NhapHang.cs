using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhapHang
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        public bool kt(int mapn, string masp)
        {
            var p = from l in cafe.CHITIETPNs
                    where l.MAPN.Equals(mapn) && l.MASP.Equals(masp)
                    select l;
            return p.Count() == 0 ? false : true;
        }
        public List<PHIEUNHAP> layMaPN()
        {
            var q = (from s in cafe.PHIEUNHAPs orderby s.MAPN descending select s).Take(1);
            return q.ToList();
        }
        public List<CHITIETPN> getLoai(int mapn)
        {
            var q = from l in cafe.CHITIETPNs
                    where l.MAPN.Equals(mapn)
                    select l;
            return q.ToList();
        }
        public List<CHITIETPN_TAM> getLoai_TAM(int mapn)
        {
            var q = from l in cafe.CHITIETPN_TAMs
                    where l.MAPN.Equals(mapn)
                    select l;
            return q.ToList();
        }
        public List<DOUONG> laycombox(string ma)
        {
            var q = (from s in cafe.DOUONGs where s.MALOAI.Equals(ma) select s);
            return q.ToList();
        }
        public int taoPN(string manv)
        {
            PHIEUNHAP pn = new PHIEUNHAP();
            pn.MANV = manv;
            pn.NGAYLAP = System.DateTime.Now.Date;
            pn.TONGTIEN = 0;
            cafe.PHIEUNHAPs.InsertOnSubmit(pn);
            cafe.SubmitChanges();
            return 1;
        }
        public int themCTHD(int mapn, string maloai, string masp, int sl, string dvt, int gia, int thanhtien)
        {
            if (kt(mapn, masp) == true)
            {
                return 0;
            }
            CHITIETPN ctpn = new CHITIETPN();
            ctpn.MAPN = mapn;
            ctpn.MALOAI = maloai;
            ctpn.MASP = masp;
            ctpn.SOLUONG = sl;
            ctpn.DVT = dvt;
            ctpn.DONGIA = gia;
            ctpn.THANHTIEN = thanhtien;
            cafe.CHITIETPNs.InsertOnSubmit(ctpn);

            cafe.SubmitChanges();
            return 1;
        }
        public int themTam(int mapn, string tenloai, string tensp, int sl, string dvt, int gia, int thanhtien)
        {

            CHITIETPN_TAM ctpn = new CHITIETPN_TAM();
            ctpn.MAPN = mapn;
            ctpn.TENLOAI = tenloai;
            ctpn.TENSP = tensp;
            ctpn.SOLUONG = sl;
            ctpn.DVT = dvt;
            ctpn.DONGIA = gia;
            ctpn.THANHTIEN = thanhtien;
            cafe.CHITIETPN_TAMs.InsertOnSubmit(ctpn);
            cafe.SubmitChanges();
            return 1;
        }
    }
}
