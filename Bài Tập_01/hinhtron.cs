using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_01
{
    class hinhtron
    {
        private double bankinh;
        public hinhtron()
        {
            bankinh = 1.0;
        }
        public hinhtron(double bankinh)
        {
           SetBanKinh(bankinh);
        }
        public void SetBanKinh(double bankinh)
        {
            this.bankinh =Math.Abs(bankinh);
        }
        public double getBanKinh()
        {
            return bankinh;
        }
        public double TinhDienTich()
        {
            return Math.PI * bankinh * bankinh;
        }
        public double TinhChuVi()
        {
            return Math.PI + 2 * bankinh;
        }                   
    }
}
