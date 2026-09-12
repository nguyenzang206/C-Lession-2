using System;

public interface IHinh
{
    double TinhDienTich();
    double TinhChuVi();
    void Print();
    void Nhap();
}

public class HinhChuNhat : IHinh
{
    private double dai;
    private double rong;

    public double ChieuDai
    {
        get => dai;
        set
        {
            if (value < 0)
                throw new Exception("Chieu dai khong duoc am");
            dai = value;
        }
    }

    public double ChieuRong
    {
        get => rong;
        set
        {
            if (value < 0)
                throw new Exception("Chieu rong khong duoc am");
            rong = value;
        }
    }

    public HinhChuNhat()
    {
    }

    public HinhChuNhat(double chieuDai, double chieuRong)
    {
        ChieuDai = chieuDai;
        ChieuRong = chieuRong;
    }

    public double TinhDienTich()
    {
        return ChieuDai * ChieuRong;
    }

    public double TinhChuVi()
    {
        return 2 * (ChieuDai + ChieuRong);
    }

    public void Print()
    {
        Console.WriteLine($"Hinh chu nhat: chieu dai = {ChieuDai}, chieu rong = {ChieuRong}");
    }

    public void Nhap()
    {
        Console.Write("Nhap chieu dai: ");
        ChieuDai = double.Parse(Console.ReadLine());

        Console.Write("Nhap chieu rong: ");
        ChieuRong = double.Parse(Console.ReadLine());
    }
}
