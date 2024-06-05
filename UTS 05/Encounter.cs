using System;

namespace UTS_05;
class Encounter
{
    public int AttackPower = 10;
    public Encounter(Player pemain, Enemy enemy)
    {
        while (!enemy.isDead && !pemain.isDead)
        {

            Console.WriteLine("Tentukan Pilihanmu");
            Console.WriteLine(" 1) Basic Attack");
            Console.WriteLine(" 2) Special Spesial");
            Console.WriteLine(" 3) Defend");
            Console.WriteLine(" 4) Run");

            string? aksiPetualang = Console.ReadLine();
            Random rnd = new Random();
            switch (aksiPetualang)
            {
                case "1":
                    Console.WriteLine("kamu menggunakan Basic Attack");
                    enemy.GetHit(pemain.AttackPower);
                    pemain.GetHit(AttackPower);
                    pemain.EXP += 10;
                    Console.WriteLine("Nyawa mu : " + pemain.Health + " | Nyawa Musuh : " + enemy.health);
                    Console.WriteLine("EXP      : " + pemain.EXP);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "2":
                    pemain.Skill(enemy);
                    pemain.EXP += 15;
                    Console.WriteLine("Nyawa mu : " + pemain.Health + " | Nyawa Musuh : " + enemy.health);
                    Console.WriteLine("EXP      : " + pemain.EXP);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "3":
                    pemain.Rest();
                    pemain.EXP += 25;
                    Console.WriteLine("Nyawa mu : " + pemain.Health + " | Nyawa Musuh : " + enemy.health);
                    Console.WriteLine("EXP      : " + pemain.EXP);
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "4":
                    Console.WriteLine("Kamu telah memilih untuk Lari, Semoga kau mati dijalan pecundang!!");
                    return;
            }
        }
    }
}