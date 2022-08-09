using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_NhaCungCap
    {
        DAL_NhaCungCap ncc = new DAL_NhaCungCap();
        public List<NHACUNGCAP> loadData()
        {
            return ncc.getData();
        }
        public int themNCC(string ma, string ten, string diachi, string sdt)
        {
            if(ncc.themNCC(ma, ten, diachi,sdt)==1)
            {
                return 1;
            }
            return 0;
        }
        public int suaNCC(string ma, string ten, string diachi,string sdt)
        {
            if(ncc.suaNCC(ma,ten,diachi,sdt)==1)
            {
                return 1;
            }
            return 0;
        }
        public int xoaNCC(string ma)
        {
            if(ncc.xoaNCC(ma)==1)
            {
                return 1;
            }
            return 0;
        }
    }
}
