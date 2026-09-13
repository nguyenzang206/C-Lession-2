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

public class HinhTamGiac : IHinh
{
    private double a;
    private double b;
    private double c;

    public double A
    {
        get { return a; }
        set
        {
            if (value > 0)
                a = value;
            else
                throw new ArgumentException("Cạnh A phải lớn hơn 0!");
        }
    }

    public double B
    {
        get { return b; }
        set
        {
            if (value > 0)
                b = value;
            else
                throw new ArgumentException("Cạnh B phải lớn hơn 0!");
        }
    }

    public double C
    {
        get { return c; }
        set
        {
            if (value > 0)
                c = value;
            else
                throw new ArgumentException("Cạnh C phải lớn hơn 0!");
        }
    }

    public HinhTamGiac()
    {
        A = 3;
        B = 4;
        C = 5;
    }

    public HinhTamGiac(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;

        if (!IsTamGiac())
            throw new ArgumentException("Ba cạnh không tạo thành tam giác!");
    }

    public bool IsTamGiac()
    {
        return A + B > C &&
               A + C > B &&
               B + C > A;
    }

    public double GetChuVi()
    {
        return A + B + C;
    }

    public double GetDienTich()
    {
        double p = GetChuVi() / 2;

        return Math.Sqrt(
            p * (p - A) * (p - B) * (p - C)
        );
    }

    public void Nhap()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập cạnh A: ");
                A = double.Parse(Console.ReadLine());

                Console.Write("Nhập cạnh B: ");
                B = double.Parse(Console.ReadLine());

                Console.Write("Nhập cạnh C: ");
                C = double.Parse(Console.ReadLine());

                if (IsTamGiac())
                    break;

                Console.WriteLine(
                    "Ba cạnh không tạo thành tam giác! Vui lòng nhập lại."
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public void HienThi()
    {
        Console.WriteLine("\n--- HÌNH TAM GIÁC ---");
        Console.WriteLine("Cạnh A: " + A);
        Console.WriteLine("Cạnh B: " + B);
        Console.WriteLine("Cạnh C: " + C);
        Console.WriteLine("Diện tích: " + GetDienTich());
        Console.WriteLine("Chu vi: " + GetChuVi());
    }
}
