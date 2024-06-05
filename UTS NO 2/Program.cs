using System;

enum ProdiFakultasTeknik
{
    Informatika,
    Elektro,
    Mesin,
    Kimia,
    Arsitektur,
    Sipil,
    Lingkungan,
}

class Program
{
    static void Main(string[] args)
    {
        string[] prodiFakultasTeknik = Enum.GetNames(typeof(ProdiFakultasTeknik));
        Random random = new Random();
        string kataRahasia = prodiFakultasTeknik[random.Next(prodiFakultasTeknik.Length)].ToLower();
        int kesempatan = 10;
        char[] hurufVocal = { 'a', 'i', 'u', 'e', 'o' };
        char[] hurufTebakan = new char[kataRahasia.Length];
        for (int i = 0; i < kataRahasia.Length; i++)
        {
            hurufTebakan[i] = '_';
        }

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Selamat datang di permainan Hangman");
        Console.WriteLine("Tebaklah, kata rahasia dari permainan Hangman ini");
        Console.WriteLine("Petunjuk kata rahasianya adalah nama nama prodi di Fakultas Teknik di Universitas Riau ");
        Console.WriteLine("Jika kesempatan kamu habis, pria itu akan gantung diri");
        Console.WriteLine("Kamu memiliki kesempatan sebanyak 10 untuk menebak");
        Console.WriteLine("Tebak kata rahasia: " + string.Join(" ", hurufTebakan));

        while (kesempatan > 0)
        {
            try
            {
                Console.WriteLine("Masukkan huruf tebakan:");
                char tebakan = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (!char.IsLetter(tebakan))
                {
                    Console.WriteLine("Anda harus memasukkan huruf.");
                    continue;
                }

                bool hurufBenar = false;

                for (int i = 0; i < kataRahasia.Length; i++)
                {
                    if (kataRahasia[i] == tebakan)
                    {
                        hurufTebakan[i] = tebakan;
                        hurufBenar = true;
                    }
                }

                if (Array.Exists(hurufVocal, v => v == tebakan))
                {   kesempatan--;
                    if (!hurufBenar)
                    {
                        kesempatan--;
                        kesempatan++;
                    }
                }
                if (!hurufBenar){
                    kesempatan--;
                }

                TampilkanHangman(10- kesempatan);

                Console.WriteLine("Kesempatan tersisa: " + kesempatan);
                Console.WriteLine("Tebak kata rahasia: " + string.Join(" ", hurufTebakan));

                if (string.Join("", hurufTebakan) == kataRahasia)
                {
                    Console.WriteLine("Selamat, anda berhasil menebak kata rahasia");
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Tebak kata rahasia: " + e.Message);
            }

            if (kesempatan == 0)
            {
                Console.WriteLine("Anda kalah! kata rahasia adalah: " + kataRahasia);
            }
        }
    }

    private static void TampilkanHangman(int kesempatan)
    {
        Console.WriteLine(kesempatan);
        switch (kesempatan)
        {
            case 1:
                Console.WriteLine("------------");
                Console.WriteLine("   | /");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 2:
                Console.WriteLine("------------");
                Console.WriteLine("   | /");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 3:
                Console.WriteLine("------------");
                Console.WriteLine("   | /");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 4:
                Console.WriteLine("------------");
                Console.WriteLine("   | /");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 5:
                Console.WriteLine("------------");
                Console.WriteLine("   | /");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 6:
                Console.WriteLine("------------");
                Console.WriteLine("   | /    |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 7:
                Console.WriteLine("------------");
                Console.WriteLine("   | /    |");
                Console.WriteLine("   |     (_)");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 8:
                Console.WriteLine("------------");
                Console.WriteLine("   | /    |");
                Console.WriteLine("   |     (_)");
                Console.WriteLine("   |     /|\\");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 9:
                Console.WriteLine("------------");
                Console.WriteLine("   | /    |");
                Console.WriteLine("   |     (_)");
                Console.WriteLine("   |     /|\\");
                Console.WriteLine("   |      |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
            case 10:
                Console.WriteLine("------------");
                Console.WriteLine("   | /    |");
                Console.WriteLine("   |     (_)");
                Console.WriteLine("   |     /|\\");
                Console.WriteLine("   |      |");
                Console.WriteLine("   |     / \\");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("-----");
                break;
        }
    }
}

                
        
