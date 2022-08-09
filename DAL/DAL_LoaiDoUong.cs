using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_LoaiDoUong
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        public bool kt(string ma)
        {
            var q = from l in cafe.LOAIDOUONGs
                    where l.MALOAI.Equals(ma)
                    select l;
            return q.Count() != 0 ? true : false;
        }
        public List<LOAIDOUONG> getData()
        {
            var q = from l in cafe.LOAIDOUONGs select l;
            return q.ToList();
        }
        public int them(string maloai, string tenloai)
        {
            if(kt(maloai)== true)
            {
                return 0;
            }     
            LOAIDOUONG l = new LOAIDOUONG();
            l.MALOAI = maloai;
            l.TENLOAI = tenloai;
            cafe.LOAIDOUONGs.InsertOnSubmit(l);
            cafe.SubmitChanges();
            return 1;
        }
        public int sua(string maloai, string tenloai)
        {
            var q = from l in cafe.LOAIDOUONGs
                    where l.MALOAI.Equals(maloai)
                    select l;
            if (q.Count() != 0)
            {
                q.First().TENLOAI = tenloai;
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
        public int xoa(string maloai)
        {
            var q = from l in cafe.LOAIDOUONGs
                    where l.MALOAI.Equals(maloai)
                    select l;
            if (q.Count() != 0)
            {
                cafe.LOAIDOUONGs.DeleteOnSubmit(q.First());
                cafe.SubmitChanges();
                return 1;
            }
            return 0;
        }
    }
}
