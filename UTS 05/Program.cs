using System;

namespace UTS_05;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Novice();
        Console.Clear();
        Console.WriteLine("SELAMAT DATANG PEJUANG");
        Console.WriteLine("Anda terbangun di hutan yang terlihat sangat aneh ini");
        Console.WriteLine("Anda tidak tau kenapa anda bisa ada di hutan yang bahkan tidak pernah anda ketahui keberadaanya ini ");
        Console.WriteLine("Anda berusaha untuk keluar dari hutan ini...");
        Console.WriteLine("(Tekan enter untuk melanjutkan)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Untuk keluar dari hutan ini, anda harus siap melawan semua monster yang menghalangi anda");
        Console.WriteLine("Sebelum kita mulai mencari jalan keluar, masukkan nama anda terlebih dahulu");
        Novice pemain = new Novice();
        pemain.Nama = Console.ReadLine();
        Console.WriteLine($"Baiklah {pemain.Nama}, apakah kamu siap (y/n)");
        string? siap = Console.ReadLine();
        if (siap == "y" || siap == "Y")
        {
            Console.Clear();
            Console.WriteLine("Anda berjalan menelusuri hutan yang sangatlah aneh tersebut");
            Console.WriteLine("Anda melihat disekeliling anda terdapat banyak sekali serangga serangga aneh");
            Console.WriteLine("Ketika anda sedang sibuk melihat ke sekeliling anda");
            Console.WriteLine("Tiba tiba ada sebuah makhluk yang mempu nyai tubuh seperti manusia namun berkepala buaya datanng menghadang anda");
            Enemy enemy = new Bapheus();
            Encounter encounter = new Encounter(player, enemy);

            Console.WriteLine("(Tekan enter untuk melanjutkan)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Setelah berhasil mengalahkan Bapheus anda kembali melanjutkan perjalanan");
            Console.WriteLine("Mata anda tertuju pada sebuah pancaran cahaya yang berada lumayan jauh dari anda");
            Console.WriteLine("Anda memutuskan untuk mendekat ke sumber cahaya tersebut");
            Console.WriteLine("selang beberapa langkah, tanah yang anda pijak tiba tiba bergetar");
            Console.WriteLine("dari dalam tanah tersebut kemudian muncul monster yang berbentuk seperti cacing namun memiliki kepala seperti bebek");
            Enemy enemy1 = new Gordoa();
            Encounter encounter1 = new Encounter(player, enemy1);
            
            if (pemain.EXP >= 100 && pemain.Role != "Mage")
            {
                pemain.Role = "Mage";
                Console.WriteLine("Anda telah naik tingkat dan menjadi seorang penyihir!");
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Satu pertarungan lagi telah anda selesaikan");
            Console.WriteLine("Namun jalan keluar keluar masih belum terlihat");
            Console.WriteLine("Anda terus berjalan munuju arah sumber cahaya tersebut");
            Console.WriteLine("Anda terus berjalan...");
            Thread.Sleep(1000);
            Console.WriteLine("Berjalan.....");
            Thread.Sleep(1000);
            Console.WriteLine("Dan berjalan.......");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Sumber cahaya sudah semakin dekat");
            Console.WriteLine("Ternyata sumber cahaya tersebut berasal dari dalam tanah yang terhimpit sebuah batu yang sangat besar");
            Console.WriteLine("Ketika anda berjalan mendekati batu tersebut, tiba tiba batu tersebut berubah menjadi sebuah laba laba raksasa yang siap memakanmu");
            Enemy Pembaik = new Liraeth();
            Encounter encounter2 = new Encounter(player, Pembaik);
            if (pemain.EXP >= 100 && pemain.Role != "Mage")
            {
                pemain.Role = "Mage";
                Console.WriteLine("Anda telah naik tingkat dan menjadi seorang penyihir!");
            }
            Enemy penjahat = new Exodia();
            Encounter encounter3 = new Encounter(player, enemy);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Anda mengira bahwa ini sudah selesai");
            Console.WriteLine($"Ketika anda melangkah menuju sumber cahaya, bangkai dari Exodia yang sudah anda kalahkan tadi tiba tiba bergerak ");
            Console.WriteLine($"Semua energi gelap yang ada dihutan tersebut dihisap oleh Exodia dan merubahnya menjadi seekor kalajengking raksasa yang mengerikan");
            Enemy musuh= new Exodia();
            Encounter encounter4 = new Encounter(player, musuh);
            Console.WriteLine($"Anda berhasil mengalahkan Exodia");
            Console.WriteLine("Kemudian anda melangkah menuju cahaya");
            Console.WriteLine("Tanpa pikir panjang, anda langsung melompat ke dalam cahaya tersebut");
            Console.WriteLine("Mata anda terpejam karena silaunya cahaya");
            Console.WriteLine("Ketika anda membuka mata anda, ternyata anda sekarang berada di atas tempat tidur");
            Console.WriteLine("Semua hal yang anda lalui tadi ternyata hanyalah mimpi");
            Console.WriteLine("SELESAI");
            Console.WriteLine("TERIMAKASIH TELAH BERMAIN");
            return;
        }
        else if (siap == "n" || siap == "N")
        {
            Console.WriteLine("Good Bye");
        }
    }
}
