namespace UTS_NO_3;

/*Nama : Rehandra
Nim : 2307113322
Prodi : S1 Teknik Informatika
Kelas : A
Matkul : Dasar pemograman
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("SELAMAT DATANG PEJUANG!!!");
        Console.WriteLine("Simpel saja, tidak boleh ada tikus yang tersisa");
        Console.WriteLine("Silahkan masukkan koordinat anda pak : ");
        int ukuranArea = 5;
        char tikus = 'T';
        char tanah = '~';
        char tertangkap = 'X';
        char salah = 'O';
        char mati = 'x';
        int jumlahTikus = 3;

        char[,] arena = BuatArena(ukuranArea, tanah, tikus, jumlahTikus);

        TampilkanArena(arena, tanah, tikus, mati);

        int tikusTertangkap = jumlahTikus;

        while (tikusTertangkap > 0)
        {
            try
            {
                int[] tebakanKoordinat = DapatkanKoordinatPengguna(ukuranArea);
                char perbaruiTampilan = VerifikasiTebakanDanSasaran(tebakanKoordinat, arena, tikus, tanah, tertangkap, salah, mati);

                if (perbaruiTampilan == tertangkap)
                {
                    tikusTertangkap--;
                }
                arena = PerbaruiArena(arena, tebakanKoordinat, perbaruiTampilan);
                Console.WriteLine("Tikus tersisa: " + tikusTertangkap);
                TampilkanArena(arena, tanah, tikus, mati);

                if (tikusTertangkap == 0)
                {
                    Console.WriteLine("Selamat, Anda berhasil menangkap semua tikus itu pak!");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Anda hanya bisa memasukkan angka.");
                continue;
            }
            catch (Exception)
            {
                Console.WriteLine("Maaf, ada kesalahan.");
                continue;
            }

        }
    }


    private static int[] DapatkanKoordinatPengguna(int ukuranArea)
    {
        int baris;
        int kolom;

        do
        {
            Console.WriteLine(" ");
            Console.Write("Koordinat Baris (1-" + ukuranArea + "): ");
            baris = Convert.ToInt32(Console.ReadLine()) - 1;
        } while (baris < 0 || baris >= ukuranArea);

        do
        {
            Console.Write("Koordinat Kolom (1-" + ukuranArea + "): ");
            kolom = Convert.ToInt32(Console.ReadLine()) - 1;
        } while (kolom < 0 || kolom >= ukuranArea);

        return new[] { baris, kolom };
    }

    private static char VerifikasiTebakanDanSasaran(int[] tebakanKoordinat, char[,] arena, char tikus, char tanah, char tertangkap, char salah, char mati)
    {
        int baris = tebakanKoordinat[0];
        int kolom = tebakanKoordinat[1];
        char sasaran = arena[baris, kolom];
        Console.Clear();

        if (sasaran == tikus)
        {
            Console.WriteLine("Instingmu bagus sekali pak!!");
            sasaran = tertangkap;
        }
        else if (sasaran == tanah)
        {
            Console.WriteLine("Tempat ini kosong pak!!");
            sasaran = salah;
        }
        else if (sasaran == tertangkap)
        {
            Console.WriteLine("Kerja Bagus!!");
            sasaran = mati;
        }
        else if (arena[baris, kolom] != ' ')
        {
            Console.WriteLine("Tempat itu sudah ditebak!!");
        }
        else
        {
            Console.WriteLine(" ");
        }
        Console.WriteLine();
        return sasaran;
    }

    private static char[,] PerbaruiArena(char[,] arena, int[] tebakanKoordinat, char perbaruiTampilan)
    {
        int baris = tebakanKoordinat[0];
        int kolom = tebakanKoordinat[1];
        arena[baris, kolom] = perbaruiTampilan;
        return arena;
    }

    private static char[,] BuatArena(int ukuranArea, char tanah, char tikus, int jumlahTikus)
    {
        char[,] arena = new char[ukuranArea, ukuranArea];
        for (int baris = 0; baris < ukuranArea; baris++)
        {
            for (int kolom = 0; kolom < ukuranArea; kolom++)
            {
                arena[baris, kolom] = tanah;
            }
        }
        return TempatkanTikus(arena, jumlahTikus, tanah, tikus);
    }

    private static char[,] TempatkanTikus(char[,] arena, int jumlahTikus, char tanah, char tikus)
    {
        int tikusDitempatkan = 0;
        int ukuranArea = 5;

        while (tikusDitempatkan < jumlahTikus)
        {
            int[] LokasiTikus = GenerateKoordinatTikus(ukuranArea);
            char posisiOK = arena[LokasiTikus[0], LokasiTikus[1]];

            if (posisiOK == tanah)
            {
                arena[LokasiTikus[0], LokasiTikus[1]] = tikus;
                tikusDitempatkan++;
            }
        }
        return arena;
    }

    private static int[] GenerateKoordinatTikus(int ukuranArea)
    {
        Random rnd = new Random();
        int[] koordinat = new int[2];
        for (int i = 0; i < koordinat.Length; i++)
        {
            koordinat[i] = rnd.Next(ukuranArea);
        }
        return koordinat;
    }

    private static void TampilkanArena(char[,] arena, char tanah, char tikus, char mati)
    {
        Console.Write("  ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(i + 1 + " ");
        }
        Console.WriteLine();
        for (int baris = 0; baris < 5; baris++)
        {
            Console.Write(baris + 1 + " ");
            for (int kolom = 0; kolom < 5; kolom++)
            {
                char posisi = arena[baris, kolom];
                if (posisi == tikus)
                {
                    Console.Write(tanah + " ");
                }
                else
                {
                    Console.Write(posisi + " ");
                }
            }
            Console.WriteLine();
        }
    }
}


