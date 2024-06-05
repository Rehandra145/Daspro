using System.Reflection;
using System.Runtime.InteropServices;

namespace Daspro_8;

class Program
{
    static void Main(string[] args)
    {
    Manusia manusia = new Manusia();
    Console.WriteLine("----------Manusia----------");
    manusia.nama = "Rehandra";
    manusia.umur = 19;
    manusia.jenisKelamin = "Pria";
    Console.WriteLine(manusia.printKeterangan(2.0));
    Console.WriteLine("---------------------------");
    Console.WriteLine("");
    Mahasiswa mahasiswa = new Mahasiswa();
    Console.WriteLine("---------Mahasiswa---------");
    mahasiswa.nama = "Rehandra";
    mahasiswa.nim = 2307113322;
    mahasiswa.jenisKelamin = "Pria";
    mahasiswa.umur = 19;
    mahasiswa.nilai = 98;
    mahasiswa.prodi = "Teknik Informatika";
    mahasiswa.jurusan = "Teknik Elektro";
    mahasiswa.kelas = "A";
    Console.WriteLine(mahasiswa.printKeterangan());
    Console.WriteLine("---------------------------");
    Console.WriteLine("");
    Dosen dosen =  new Dosen();
    Console.WriteLine("-----------Dosen-----------");
    dosen.nama = "Rizal";
    dosen.umur = 40;
    dosen.jenisKelamin = "Pria";
    dosen.prodi = "Teknik Informatika";
    dosen.jurusan = "Teknik Elektro";
    dosen.fakultas = "Fakultas Teknik ";
    dosen.universitas = "Universitas Riau";
    Console.WriteLine(dosen.printKeterangan());
    Console.WriteLine("---------------------------");
    }
}
class Manusia
{
    public string? nama{get; set;}
    public int umur{get; set;}
    public string? jenisKelamin{get; set;}
    
    public virtual string printKeterangan()
    {
        return $"Nama : {nama}\nUmur : {umur}\nJenis kelamin : {jenisKelamin}";
    }
    public virtual string printKeterangan(double nip)
    {
        return $"Nama : {nama}\nUmur : {umur}\nJenis kelamin : {jenisKelamin}";
    }
}
class Mahasiswa : Manusia
{
    public uint nim{get; set;}
    public int nilai{get; set;}
    public string? prodi{get; set;}
    public string? kelas{get; set;}
    public string? jurusan{get; set;}
    public override string printKeterangan()
    {
        return $"Nama : {nama}\nUmur : {umur}\nJenis kelamin : {jenisKelamin}\nNIM : {nim}\nProdi : {prodi}\nJurusan : {jurusan}\nKelas : {kelas}\nnilai : {nilai}";
    } 
}
class Dosen : Manusia
{
    public string? prodi{get; set;}
    public string? jurusan{get; set;}
    public string? fakultas{get; set;}
    public string? universitas{get; set;}
    public override string printKeterangan()
    {
        return $"Nama : {nama}\nUmur : {umur}\nJenis kelamin : {jenisKelamin}\nprodi : {prodi}\njurusan : {jurusan}\nfakultas : {fakultas}\nUniversitas : {universitas}";
    }
}
