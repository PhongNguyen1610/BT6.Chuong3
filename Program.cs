using System;

namespace BT6.Chuong3
{
    class Program
    {
        static void Main(string[] args)
        { 
            DsSinhVien htttak21 = new DsSinhVien();
            htttak21.Nhap();
            htttak21.Xuat();
            htttak21.SapXep();
            htttak21.Xuat();
            htttak21.xuatsvtren8();
            Console.ReadLine();
        }
    }
}
