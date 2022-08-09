using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhaCungCap
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        public bool kt(string maNCC)
        {
            var q = from ncc in cafe.NHACUNGCAPs
                    where ncc.MANCC.Equals(maNCC)
                    select ncc;
            return q.Count() != 0 ? true : false;
        }
        public List<NHACUNGCAP> getData()
        {
            var q = from ncc in cafe.NHACUNGCAPs select ncc;
            return q.ToList();
        }
        public int themNCC(string mancc, string tenncc, string diachi, string sdt)
        {
            if(kt(mancc) ==true)
            {
                return 0;
            }
            NHACUNGCAP ncc = new NHACUNGCAP();
            ncc.MANCC = mancc;
            ncc.TENNCC = tenncc;
            ncc.DIACHI = diachi;
            ncc.SDT = sdt;
            cafe.NHACUNGCAPs.InsertOnSubmit(ncc);
            cafe.SubmitChanges();
            return 1;
        }
        public int suaNCC(string mancc, string tenncc, string diachi, string sdt)
        {
            var q = from ncc in cafe.NHACUNGCAPs
                    where ncc.MANCC.Equals(mancc)
                    select ncc;
            if(q.Count()!=0)
            {
                q.First().TENNCC = tenncc;
                q.First().DIACHI = diachi;
                q.First().SDT = sdt;
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoaNCC(string mancc)
        {
            var q = from ncc in cafe.NHACUNGCAPs
                    where ncc.MANCC.Equals(mancc)
                    select ncc;
            if(q.Count()!=0)
            {
                cafe.NHACUNGCAPs.DeleteOnSubmit(q.First());
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}
