using System.Collections;
using System.Reflection.Metadata.Ecma335;


namespace Daspro04;

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
