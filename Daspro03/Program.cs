using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Selamat datang di permainan Dadu!");
        Console.WriteLine("Anda akan bermain melawan komputer dalam 10 ronde.");

        int userWins = 0;
        int computerWins = 0;
        Random random = new Random();
        

        //loop
        for (int round = 1; round <= 10; round++)
        {
            Console.WriteLine($"\nRonde {round}:");

            int dadu_pemain = RollDice(random);
            int dadu_komputer = RollDice(random);
            

          for (int ronde = 1; ronde <= 10; ronde++)
        {
            Console.WriteLine("Ronde {ronde}");
            dadu_komputer = RollDice(random);
            Console.WriteLine("Nilai komputer : {dadu_komputer}");
            Console.Write("Lembar dadu anda...");
            Console.ReadLine();
            dadu_pemain = RollDice(random);
            Console.WriteLine("Nilai anda : {dadu_pemain}");

            int userTotal = dadu_pemain;
            int computerTotal = dadu_komputer;

            if (userTotal > computerTotal)
            {
                Console.WriteLine("Anda memenangkan ronde ini!");
                userWins++;
            }
            else if (computerTotal > userTotal)
            {
                Console.WriteLine("Komputer memenangkan ronde ini.");
                computerWins++;
            }
            else
            {
                Console.WriteLine("Ronde ini seri.");
            }
        }

        Console.WriteLine("\nHasil Akhir:");
        Console.WriteLine($"Anda memenangkan {userWins} dari 10 ronde.");
        Console.WriteLine($"Komputer memenangkan {computerWins} dari 10 ronde.");

        if (userWins > computerWins)
        {
            Console.WriteLine("Anda memenangkan permainan!");
        }
        else if (computerWins > userWins)
        {
            Console.WriteLine("Komputer memenangkan permainan.");
        }
        else
        {
            Console.WriteLine("Permainan berakhir seri.");
        }
    }

    static int RollDice(Random random)
    {
        return random.Next(1, 7); // Menghasilkan angka acak antara 1 dan 6 (dadu 6 sisi)
    }
}
}