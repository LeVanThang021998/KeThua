using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_01
{
    class hinhtru : hinhtron
    {
        private double chieucao;
        public hinhtru()
        {
            chieucao = 1.0;
        }
        public hinhtru(double bankinh, double chieucao) : base(bankinh)
        {
            setChieuCao(chieucao);
        }
        public void setChieuCao(double chieucao)
        {
            this.chieucao = Math.Abs(chieucao);
        }
        public double getChieuCao()
        {
            return chieucao;
        }      
        public double tinhTheTich()
        {
            return tinhDienTich()* chieucao;
        }
        public double tinhDienTich()
        {
            return  tinhDienTich() + TinhChuVi() * chieucao;
        }
    }
}
