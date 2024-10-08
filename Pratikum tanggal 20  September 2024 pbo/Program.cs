﻿// Nama : Naufal Kemal Athilla
// Nim  : 232410101045
// Kelas: PBO B
using System;

class Hewan
{
    public string Nama;
    public int Umur;
    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }
    public virtual string Suara()
    {
        return "Hewan ini Bersuara";

    }
    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}\nUmur: {Umur}";
    }
}

class Mamalia : Hewan
{
    public int Jumlahkaki;

    public Mamalia(string nama, int umur, int jumlahkaki) : base(nama, umur)
    {
        Jumlahkaki = jumlahkaki;
    }
    public override string Suara()
    {
        return "Mamalia ini bersuara \n ";
    }
    //public override string InfoHewan()
    //{
    //    return $"{base.InfoHewan()}\nJumlah Kaki:{Jumlahkaki}";
    //}

}
class Reptil:Hewan
{
    public double PanjangTubuh; //Meter

    public Reptil(string nama, int umur, double panjangtubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangtubuh;
    }
    public override string Suara()
    {
        return "reptil ini bersuara";
    }

    //public override string InfoHewan()
    //{
    //    return $"{base.InfoHewan()}\nPanjang Tubuh: {PanjangTubuh}";
    //}
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahkaki) : base(nama,umur,jumlahkaki)
    {

    }
    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum sekeras - kerasnya: 'Meowwwww!!!!'");
    }
    public override string Suara()
    {
        return "Singa mengaum";
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlakaki) : base(nama, umur, jumlakaki)
    {

    }

    public override string Suara()
    {
        return "Gajah mengeluarkan suara terompet keras";
    }
}

class Ular:Reptil
{
    public Ular(string nama, int umur, double panjangtubuh) : base(nama,umur,panjangtubuh)
    {

    }
    public void Merayap()
    {
        Console.WriteLine("Ular lagi  merayap");
    }
    public override string Suara()
    {
        return "Ular lagi mendesis";
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangtubuh) : base(nama,umur,panjangtubuh)
    {

    }

    public override string Suara()
    {
        return "Buaya menggeram";
    }
}


class KebunBinatang
{
    private List<Hewan> koleksiHewanhewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewanhewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewanhewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine("");

        }
    }
}


class ProgramUtama
{
    static void Main()
    {
        // Membuat berbagai objek Hewan baru
        Singa singa1 = new Singa("Singa Leonidas", 3, 4);
        Gajah gajah1 = new Gajah("Gajah Dono", 2, 4);
        Ular ular1 = new Ular("Ular Pito", 3, 0.06);
        Buaya buaya1 = new Buaya("Buaya Trino", 2, 4.2);

        //Membuat Kebun binatang baru

        KebunBinatang kebunbinatang = new KebunBinatang();

        //Menambahkan hewan - hewan tersebut ke Kebun binatang yang telah dibuat
        kebunbinatang.TambahHewan(singa1);
        kebunbinatang.TambahHewan(gajah1);
        kebunbinatang.TambahHewan(ular1);
        kebunbinatang.TambahHewan(buaya1);

        //Menampikan semua hewan yang berada pada kebun binatang
        Console.WriteLine("Daftar hewan di kebun binatang:");
        kebunbinatang.DaftarHewan();

        //Menampilkan metode suara semua hewan (Demonstrasi Polymorp)
        Console.WriteLine("");
        Console.WriteLine("Suara Hewan");
        Console.WriteLine($"{singa1.Suara()}");
        Console.WriteLine($"{gajah1.Suara()}");
        Console.WriteLine($"{ular1.Suara()}");
        Console.WriteLine($"{buaya1.Suara()}");

        //Menampilkan Method khusus
        Console.WriteLine("");
        Console.WriteLine("Method Khusus:");
        singa1.Mengaum();
        ular1.Merayap();

        //Mengerjakan tugas analisis percobaan 3
        Console.WriteLine("");
        Console.WriteLine("Percobaan 3");
        Console.WriteLine($"{singa1.InfoHewan()}");
        Console.WriteLine($"Jumlah kaki: {singa1.Jumlahkaki}");

        //Mengerjakan tugas analisis percobaan 5
        Console.WriteLine("");
        Console.WriteLine("Percobaan 5");
        Reptil reptil = new Buaya("Buaya biro", 5, 4.1);
        Console.WriteLine($"{reptil.Suara()}");



    }
}
