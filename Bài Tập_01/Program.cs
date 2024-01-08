using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_01
{
    class Program
    {
        static void Main(string[] args)
        {
            hinhtron htron = new hinhtron(5);
            Console.WriteLine("*****Thong tin hinh tron*****");
            Console.WriteLine("Ban kinh: {0} - Dien tich: {1} - Chu vi: {2}",
                htron.getBanKinh(), htron.TinhDienTich(), htron.TinhChuVi());
            hinhtru htru = new hinhtru(5,4);
            Console.WriteLine("*****Thong tin hinh tru*****");
            Console.WriteLine("Ban kinh: {0} - Chieu cao: {1} - Dien tich: {2} - The tich: {3}",
                htru.getBanKinh(), htru.getChieuCao(), htru.tinhDienTich(), htru.tinhTheTich());
            Console.ReadLine();
        }
    }
}
