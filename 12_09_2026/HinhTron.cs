using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCAdvance.Hinh
{
    public interface IHinh
    {
        void Print();

        double getDienTich();

        double getChuVi();

        void nhapThongTin();
    }
}

public class HinhTron : IHinh
{
    private double banKinh;

    public double BanKinh
    {
        get { return banKinh; }
        set
        {
            if (value > 0)
                banKinh = value;
            else
                throw new ArgumentException("Bán kính phải lớn hơn 0!");
        }
    }

    public HinhTron()
    {
        BanKinh = 1;
    }

    public HinhTron(double banKinh)
    {
        BanKinh = banKinh;
    }

    public double GetDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }

    public double GetChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }

    public void Nhap()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập bán kính: ");
                BanKinh = double.Parse(Console.ReadLine());
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public void HienThi()
    {
        Console.WriteLine("\n--- HÌNH TRÒN ---");
        Console.WriteLine("Bán kính: " + BanKinh);
        Console.WriteLine("Diện tích: " + GetDienTich());
        Console.WriteLine("Chu vi: " + GetChuVi());
    }
}
