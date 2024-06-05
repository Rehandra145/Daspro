using System;
using System.Collections;

namespace Game
{
    class Program
    {
        static int kesempatan = 3;
        static string kataRahasia = "informatika";
        static ArrayList hurufTebakanPemain = new ArrayList();

        static void Main(string[] args)
        {
            intro();
            MulaiMain();
        }

        static void intro()
        {
            Console.WriteLine("Halo, hari ini kita akan bermain tebak kata....");
            Console.WriteLine($"Saya memiliki kata rahasia yang terdiri dari {kataRahasia.Length} huruf.");
            Console.WriteLine($"Kamu punya {kesempatan} kesempatan untuk menebak kata tersebut");
            Console.WriteLine("Petunjuknya, kata ini adalah salah satu prodi di Universitas Riau");
            Console.WriteLine("Dapatkah kamu menebaknya ?");
        }

        static void MulaiMain()
        {
            for (int kesempatan = 3; kesempatan<=3; kesempatan--)
            while (kesempatan > 0)
            {
                Console.Write("Masukkan huruf tebakanmu (a-z): ");
                string input = Console.ReadLine();
                hurufTebakanPemain.Add(input);

                if (kataRahasia.Contains(input))
                {
                    Console.WriteLine("Tebakan anda benar");
                    Console.WriteLine("Huruf itu ada didalam kata rahasia");
                    Console.WriteLine("kesempatan anda tidak berkurang, kesempatan menebak anda tersisa : "+kesempatan);
                    Console.WriteLine("Lanjutkan tebakan anda...");
                }
                else
                {   Console.WriteLine("Kesempatan kamu menebak tinggal " + kesempatan);
                    Console.WriteLine("Maaf, huruf itu tidak ada dalam kata rahasia");
                    kesempatan--;
                }

                if (cekJawaban())
                {
                    Console.WriteLine("Selamat tebakan anda benar");
                    Console.WriteLine("Anda berhasil memenangkan game ini");
                    return;
                }
            
            }
            Console.WriteLine("Sayang sekali, permainan selesai");
            Console.WriteLine("Kata Rahasia yang benar adalah " + kataRahasia);
        }

        static void cekHuruf()
        {
            Console.WriteLine("Huruf-huruf yang sudah ditebak:");
            foreach (var huruf in hurufTebakanPemain)
            {
                Console.Write(huruf + " ");
            }
            Console.WriteLine();
        }

        static bool cekJawaban()
        {
            string tebakan = "";
            foreach (var huruf in kataRahasia)
            {
                if (hurufTebakanPemain.Contains(huruf.ToString()))
                {
                    tebakan += huruf;
                }
                else
                {
                    tebakan += "_";
                }
            }
            Console.WriteLine("Hasil tebakan: " + tebakan);

            return tebakan == kataRahasia;
        }
    }
}





//Belajar Array

class Program
{
    static void Main(string[] args)
    {
        //Array
        string[] namaMahasiswa = new string[5];

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Array list");

        namaMahasiswa[0] = "Auzia";
        namaMahasiswa[1] = "Ichwan";
        namaMahasiswa[2] = "Channiyan";
        namaMahasiswa[3] = "Riska";
        namaMahasiswa[4] = "Ai'Nur";

        for(int i=0;i<namaMahasiswa.Length;i++){

             Console.WriteLine("Nama Mahasiswa : "+namaMahasiswa[i]);
        }
        
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Mahasiswa Semester 2 :");
        namaMahasiswa[1] = "Hilmi";
        namaMahasiswa[2] = "Syachrul";
        namaMahasiswa[3] = "Rehan";

          for(int i=0;i<namaMahasiswa.Length;i++){

             Console.WriteLine("Nama Mahasiswa : "+namaMahasiswa[i]);
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine("Array list : ");



        //ArrayList
        ArrayList namaMahasiswaList = new ArrayList();
        namaMahasiswaList.Add("Auzia");
        namaMahasiswaList.Add("Ichwan");
        namaMahasiswaList.Add("Channiyan");
        namaMahasiswaList.Add("Riska");
        namaMahasiswaList.Add("Ai'Nur");

        for(int i=0;i<5;i++){
            Console.WriteLine("Nama Mahasiswa : "+namaMahasiswaList[i]);
        }


        Console.WriteLine("--------------------------");
        Console.WriteLine("Mahasiswa Semester 2 : ");

        namaMahasiswaList.Remove("Ichwan");
        namaMahasiswaList.Remove("Channiyan");
        namaMahasiswaList.Remove("Auzia");

        namaMahasiswaList.Add("Hilmi");
        namaMahasiswaList.Add("Syachrul");
        namaMahasiswaList.Add("Rehan");

        foreach (string name in namaMahasiswaList)
        {
           Console.WriteLine("Nama Mahasiswa : "+name);
        }




        
    }
}
