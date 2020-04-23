﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT6.Chuong3
{
    class sinhVien
    {
        public string masv;
        private string HoTen;
        private int NamSinh;
        public double DiemLT, DiemCSDL, DiemTB;

        public sinhVien()
        {
            masv = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLT = DiemCSDL = DiemTB = 0;
        }

        public sinhVien(string masv, string Hoten, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.masv = masv;
            this.HoTen = Hoten;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
          this.DiemTB= (DiemCSDL + DiemLT) *0.5;
        }
        
        public void Nhap()
        {
            Console.WriteLine("Ban dang goi ham nhap tt");
            Console.WriteLine("Hay nhap ma  sinh vien");
            masv = Console.ReadLine();
            Console.WriteLine("Hay nhap ho ten cua sinh vien");
            HoTen = Console.ReadLine();
            Console.WriteLine("Hay nhap nam sinh cua sinh vien");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap vao diem  lap trinh cua sinh vien");
            DiemLT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap vao diem  co so du lieu cua sinh vien");
            DiemCSDL = Convert.ToInt32(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ban dang goi ham xuat tt");
            Console.WriteLine("Ma cua sinh vien la: " + masv);
            Console.WriteLine("Ho ten cua sinh vien la: " + HoTen);
            Console.WriteLine("Diem lap trinh cua sinh vien la: " + DiemLT);
            Console.WriteLine("Diem co so du lieu cua sinh vien la: " + DiemCSDL);
            Console.WriteLine("Diem trung binh cua sinh vien la: " + DiemTB);
            DiemTB = (DiemLT + DiemCSDL) / 2;
        }
    }
}
