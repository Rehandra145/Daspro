using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Daspro_9;
[System.Runtime.Versioning.SupportedOSPlatform("Windows")]

class Program
{
    static int kiri = 0;
    static int kanan = 1;
    static int atas = 2;
    static int bawah = 3;

    //pemain 1
    static int skorPemain1 = 0;
    static int skorTotal1 = 0;
    static int arahPemain1 = kanan;
    static int kolomPemain1 = 0;
    static int barisPemain1 = 0;

    //pemain 2
    static int skorPemain2 = 0;
    static int skorTotal2 = 0;
    static int arahPemain2 = kiri;
    static int kolomPemain2 = 40;
    static int barisPemain2 = 5;

    //posisi teks
    static int posisiTeksX;
    static int posisiTeksY;
    static bool IsGameRunning;


    static bool[,]? isUsed;


    static void Main(string[] args)
    {
        AturLayarPermainan();
        IsGameRunning = true;

        LayarAwal();
        skorTotal1 = skorPemain1;
        skorTotal2 = skorPemain2;

        isUsed = new bool[Console.WindowWidth, Console.WindowHeight];

        while (IsGameRunning)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                ubahGerakanPemain(key);
            }

            gerakanPemain();
            bool pemain1Kalah = CekKalah(barisPemain1, kolomPemain1);
            bool pemain2Kalah = CekKalah(barisPemain2, kolomPemain2);


            if (pemain1Kalah && pemain2Kalah)
            {
                skorPemain1++;
                skorPemain2++;
                Console.WriteLine("");
                if (posisiTeksY >= 0 && posisiTeksY < Console.WindowHeight)
                {
                    Console.SetCursorPosition(posisiTeksX, posisiTeksY);
                }
                Console.WriteLine("Permainan Berakhir");
                Console.WriteLine("Skor seri !!!!");
                Console.WriteLine("Skor : {0} - {1}", skorPemain1, skorPemain2);
                ResetGame();


            }
            else if (pemain1Kalah)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                skorPemain2++;
                Console.WriteLine("");
                if (posisiTeksY >= 0 && posisiTeksY < Console.WindowHeight)
                {
                    Console.SetCursorPosition(posisiTeksX, posisiTeksY);
                }
                Console.WriteLine("Permainan berakhir");
                Console.WriteLine("Pemain 2 menang!!");
                Console.WriteLine("Skor {0} - {1}", skorPemain1, skorPemain2);
                ResetGame();
            }
            else if (pemain2Kalah)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                skorPemain1++;
                Console.WriteLine("");
                if (posisiTeksY >= 0 && posisiTeksY < Console.WindowHeight)
                {
                    Console.SetCursorPosition(posisiTeksX, posisiTeksY);
                }
                Console.WriteLine("Permainan berakhir");
                Console.WriteLine("Pemain 1 menang!!");

                Console.WriteLine("Skor {0} - {1}", skorPemain2, skorPemain1);
                ResetGame();
            }

            isUsed[kolomPemain1, barisPemain1] = true;
            isUsed[kolomPemain2, barisPemain2] = true;

            WriteInPosition(kolomPemain1, barisPemain1, 'x', ConsoleColor.DarkBlue);
            WriteInPosition(kolomPemain2, barisPemain2, '*', ConsoleColor.Red);

            Thread.Sleep(100);


            if (skorPemain1 == 10 || skorPemain2 == 10)
            {
                Console.Clear();
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Salah satu pemain telah menyampai batas maksimal skor yang ditentukan");
                Console.WriteLine("Tekan R untuk memulai permainan baru atau Q untuk keluar.");
                bool validInput = false;
                while (!validInput)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey(true);
                    if (userInput.Key == ConsoleKey.R)
                    {
                        ResetGame();
                        validInput = true;
                        skorPemain1 = 0;
                        skorPemain2 = 0;
                    }
                    else if (userInput.Key == ConsoleKey.Q)
                    {
                        Console.WriteLine("Terimakasih sudah bermain, Selamat Tinggal");
                        IsGameRunning = false;
                        validInput = true;
                    }
                }
            }
        }
    }

    static void WriteInPosition(int kolom, int baris, char x, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(kolom, baris);
        Console.Write(x);
    }

    static void ResetGame()
    {
        isUsed = new bool[Console.WindowWidth, Console.WindowHeight];
        kolomPemain1 = 0;
        barisPemain1 = Console.WindowHeight / 2;
        kolomPemain2 = Console.WindowWidth - 1;
        barisPemain2 = Console.WindowHeight / 2;
        AturLayarPermainan();
        arahPemain1 = kanan;
        arahPemain2 = kiri;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Tekan sembarang Key untuk memulai permainan");
        Console.ReadKey();
        Console.Clear();
        gerakanPemain();
    }

    static bool CekKalah(int baris, int kolom)
    {
        if (baris < 0)
        {
            return true;
        }
        if (kolom < 0)
        {
            return true;
        }
        if (baris >= Console.WindowHeight)
        {
            return true;
        }
        if (isUsed[kolom, baris])
        {
            return true;
        }
        return false;
    }

    static void ubahGerakanPemain(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.W && arahPemain1 != bawah)
        {
            arahPemain1 = atas;
        }
        if (key.Key == ConsoleKey.A && arahPemain1 != kanan)
        {
            arahPemain1 = kiri;
        }
        if (key.Key == ConsoleKey.S && arahPemain1 != atas)
        {
            arahPemain1 = bawah;
        }
        if (key.Key == ConsoleKey.D && arahPemain1 != kiri)
        {
            arahPemain1 = kanan;
        }
        if (key.Key == ConsoleKey.UpArrow && arahPemain2 != bawah)
        {
            arahPemain2 = atas;
        }
        if (key.Key == ConsoleKey.LeftArrow && arahPemain2 != kanan)
        {
            arahPemain2 = kiri;
        }
        if (key.Key == ConsoleKey.DownArrow && arahPemain2 != atas)
        {
            arahPemain2 = bawah;
        }
        if (key.Key == ConsoleKey.RightArrow && arahPemain2 != kiri)
        {
            arahPemain2 = kanan;
        }
    }

    static void gerakanPemain()
    {
        if (arahPemain1 == kanan)
        {
            kolomPemain1++;
        }
        if (arahPemain1 == kiri)
        {
            kolomPemain1--;
        }
        if (arahPemain1 == atas)
        {
            barisPemain1--;
        }
        if (arahPemain1 == bawah)
        {
            barisPemain1++;
        }

        if (arahPemain2 == kanan)
        {
            kolomPemain2++;
        }
        if (arahPemain2 == kiri)
        {
            kolomPemain2--;
        }
        if (arahPemain2 == atas)
        {
            barisPemain2--;
        }
        if (arahPemain2 == bawah)
        {
            barisPemain2++;
        }
    }

    static void AturLayarPermainan()
    {
        Console.WindowHeight = 30;
        Console.WindowWidth = 100;

        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight;

        kolomPemain1 = 0;
        barisPemain1 = Console.WindowHeight / 2;

        kolomPemain2 = Console.WindowWidth - 1;
        barisPemain2 = Console.WindowHeight / 2;

        posisiTeksX = 0;
        posisiTeksY = 0;
    }

    static void LayarAwal()
    {
        Console.Clear();
        string? heading = "TRON";
        Console.CursorLeft = Console.BufferWidth / 2 - heading.Length / 2;
        Console.WriteLine(heading);
        Thread.Sleep(500);
        string? body = "Tron adalah sebuah game dimana 2 orang pemain akan dikumpulkan dalam satu arena";
        Console.CursorLeft = Console.BufferWidth / 4 - heading.Length / 4;
        Console.WriteLine(body);
        Thread.Sleep(500);
        string? aturan = "Aturannya cukup sederhana, siapa yang menabrak duluan akan kalah dan yang bertahan untuk tidak menabrak apapun dia menang";
        Console.WriteLine(aturan);
        Thread.Sleep(500);
        string? pesan = "Selamat berjuang !!!";
        Console.CursorLeft = Console.BufferWidth / 2 - heading.Length / 2;
        Console.WriteLine(pesan);
        Thread.Sleep(500);

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("");
        Console.WriteLine("Kontrol untuk pemain 1 : ");
        Console.WriteLine("W -> atas");
        Console.WriteLine("A -> kiri");
        Console.WriteLine("D -> kanan");
        Console.WriteLine("S -> bawah");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Kontrol untuk pemain 2 : ");
        Console.WriteLine("Panah Atas -> atas");
        Console.WriteLine("Panah Kiri -> kiri");
        Console.WriteLine("Panah Kanan -> kanan");
        Console.WriteLine("Panah Bawah -> bawah");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("Klik Terminal lalu Tekan Enter untuk melanjutkan");

        Console.ReadKey();
        Console.Clear();
    }
}
