using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_DSHDKH
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        public List<HOADON> layDSHD(string makh)
        {
            var q = from l in cafe.HOADONs
                    where l.MAKH.Equals(makh)
                    select l;
            return q.ToList();
        }
    }
}
