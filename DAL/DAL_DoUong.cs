using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_DoUong
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        public bool kt(string masp)
        {
            var q = from sp in cafe.DOUONGs
                    where sp.MASP.Equals(masp)
                    select sp;
            return q.Count() != 0 ? true : false;
        }
        public List<DOUONG> getLoai()
        {
            var q = from du in cafe.DOUONGs select du;
            return q.ToList();
        }
        public int them(string masp, string tensp, string dvt, int dongia, string maloai)
        {
            if (kt(masp) == true)
            {
                return 0;
            }
            DOUONG sp = new DOUONG();
            sp.MASP = masp;
            sp.TENSP = tensp;
            sp.DVT = dvt;
            sp.DONGIA = dongia;
            sp.MALOAI = maloai;
            cafe.DOUONGs.InsertOnSubmit(sp);
            cafe.SubmitChanges();
            return 1;
        }
        public int sua(string masp, string tensp, string dvt, int dongia, string maloai)
        {
            var q = from sp in cafe.DOUONGs
                    where sp.MASP.Equals(masp)
                    select sp;
            if (q.Count() != 0)
            {
                q.First().TENSP = tensp;
                q.First().DVT = dvt;
                q.First().DONGIA = dongia;
                q.First().MALOAI = maloai;
                return 1;
            }
            return 0;
        }
        public int xoa(string masp)
        {
            var q = from l in cafe.DOUONGs
                    where l.MASP.Equals(masp)
                    select l;
            if (q.Count() != 0)
            {
                cafe.DOUONGs.DeleteOnSubmit(q.First());
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public List<DOUONG> timkiem(string ten)
        {
            var q = from s in cafe.DOUONGs.Where(l => l.MALOAI.Equals(ten))
                    select s;
            return q.ToList();
        }
    }
}
