using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_DSHDKH
    {
        DAL_DSHDKH l = new DAL_DSHDKH();
        public List<HOADON> loadData(string makh)
        {
            return l.layDSHD(makh);
        }
    }
}
