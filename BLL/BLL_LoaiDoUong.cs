using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_LoaiDoUong
    {
        DAL_LoaiDoUong l = new DAL_LoaiDoUong();
        public int themLoaiDoUong(string maloai, string tenloai)
        {
            if(l.them(maloai, tenloai)==1)
            {
                return 1;
            }
            return 0;
        }
        public int xoaLoaiDoUong(string maloai)
        {
            if(l.xoa(maloai)==1)
            {
                return 1;
            }
            return 0;
        }
        public int suaLoaiDoUong(string maloai, string tenloai)
        {
            if (l.sua(maloai, tenloai) == 1)
            {
                return 1;
            }
            return 0;
        }
        public List<LOAIDOUONG> loadData()
        {
            return l.getData();
        }
    }
}
