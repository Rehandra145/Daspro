using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Daspro_6;

class Program
{
    /*static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Matriks Pertama");
            Console.WriteLine("------------------");
            int[,] matriks = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriks[i, j] = i * 3 + j + 1;
                    Console.Write(matriks[i, j] + " ");
                }
                Console.WriteLine("");
            }
            
            Console.WriteLine("------------------");
            Console.WriteLine("Matriks kedua");
            Console.WriteLine("------------------");

            int[,] matriks2 = new int[3, 3]{
                {9,8,7},
                {5,6,4},
                {8,7,2}};

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriks2[i, j] + " ");
                }
                Console.WriteLine("");
            }

            int[,] hasil = PenambahanMatriks(matriks, matriks2);
            Console.WriteLine("------------------");
            Console.WriteLine("Hasil jumlah kedua matriks");
            Console.WriteLine("------------------");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(hasil[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static int[,] PenambahanMatriks(int[,] matriks, int[,] matriks2)
        {
            int[,] hasil = new int[3, 3];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    hasil[x, y] = matriks[x, y] + matriks2[x, y];
                }
            }

            return hasil;
        }
    }*/

static void Main(string[] args)
{ 
char pemain = 'X';
bool GameSelesai = false;
char[,] papan = new char[3,3];
init(papan);

while(!GameSelesai){
    Console.Clear();
    TampilkanPapan(papan);
    
    try
    {
     Console.Write("Baris (0-2) : ");
     int baris = Convert.ToInt32(Console.ReadLine());
     Console.Write("Kolom (0-2) : ");
     int kolom = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Baris : " + baris + " Kolom : " + kolom);

    if (papan[baris, kolom] != ' ')
    {
        Console.WriteLine("Tempat tersebut sudah ditandai");
        Console.Write("Tekan Enter untuk melanjutkan");
        Console.ReadLine();
        continue;
    }
    papan[baris, kolom] = pemain;
     if (CekMenang(papan, pemain))
    {
        Console.Clear();
        TampilkanPapan(papan);
        Console.WriteLine($"{pemain} menang, terimakasih sudah bermain...");
        Console.WriteLine("Dan untuk yang kalah, terimakasih sudah mencoba :)");
        Console.Read();
        GameSelesai = true;
    }
    else (CekSeri());
    {
        Console.Clear();
        TampilkanPapan(papan);
        Console.Write($"{pemain} hasil seri, terimakasih sudah bermain...");
        Console.Read();
        GameSelesai = true;
    }

    papan[baris, kolom] = pemain;
    } 
    catch (Exception e)
    {
        Console.WriteLine("Terjadi eror" + e.Message);
        Console.Write("Tekan enter untuk melanjutkan");
        Console.ReadLine();
    }

    
    pemain =  GantiPemain(pemain);
}
}
static char GantiPemain(char pemain){
    if(pemain=='X'){
        return 'O';
    }else{
    } return 'X';

    
}
static bool CekMenang(char[,] papan, char pemain)
{
    for (int i = 0; i<3;i++)
    {
     if (papan[i, 0] == pemain && papan[i,1] == pemain && papan[i,2] == pemain) return true;
     if (papan[0, i] == pemain && papan[1,i] == pemain && papan[2,i] == pemain) return true;
    }
    if (papan[0, 0] == pemain && papan[1,1] == pemain && papan[2,2] == pemain) return true;
    if (papan[0, 2] == pemain && papan[1,1] == pemain && papan[2,0] == pemain) return true;
    return false;
}

static bool CekSeri(Char[,] papan)
{
    for (int i=0;i<3;i++){
        for (int j=0;j<3;j++){
            if(papan[i,j]==' ') return false;
        }
    }
    return false;
}
static void TampilkanPapan(char[,] papan)
{
    Console.WriteLine("  | 0 | 1 | 2 |");
    for (int i=0;i<3;i++)
    {
        Console.Write(i+" | ");
        for(int j=0;j<3;j++)
        {
           Console.Write(papan[i,j]);
           Console.Write(" | ");
    }
    Console.WriteLine();
}
}
static void init(char[,] papan){

    for(int baris=0;baris<3;baris++){
        
        for(int kolom=0;kolom<3;kolom++){
          papan[baris, kolom] = ' ';
        }
    }
    }
}
      
