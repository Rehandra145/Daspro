using System.Diagnostics.Contracts;
using System.Net;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Resources;
using System.Runtime.InteropServices.Marshalling;
using System.Security;

namespace UTS_4;

class Program
{
    static void Main(string[] args)
    {   Console.Clear();
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
        if (siap =="y")
        {
           Console.Clear();
                Console.WriteLine("Anda berjalan menelusuri hutan yang sangatlah aneh tersebut");
                Console.WriteLine("Anda melihat disekeliling anda terdapat banyak sekali serangga serangga aneh");
                Console.WriteLine("Ketika anda sedang sibuk melihat ke sekeliling anda");
                Console.WriteLine("Tiba tiba ada sebuah makhluk yang mempu nyai tubuh seperti manusia namun berkepala buaya datanng menghadang anda");
                Enemy enemy1 = new Enemy();
                enemy1.Nama = "Bapheus";
                Console.WriteLine($"Anda sedang menghadapi {enemy1.Nama}!!!");
                Console.WriteLine("Pilih aksi anda: ");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Special Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");

                
            
                while (!pemain.isDead && !enemy1.isDead)
                {
                    string? playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Anda melakukan single attack");
                            pemain.attack(pemain.AttackPower);
                            enemy1.GetHit(pemain.AttackPower);
                            pemain.EXP += 2;
                            enemy1.attack(enemy1.AttackPower);
                            pemain.GetHit(enemy1.AttackPower);
                            Console.WriteLine("Nyawa Pemain : " + pemain.Health + " | Nyawa musuh : " + enemy1.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "2":
                            Console.Clear();
                            pemain.Swing();
                            pemain.EXP += 2;
                            enemy1.GetHit(pemain.AttackPower);
                            pemain.GetHit(enemy1.AttackPower);
                            Console.WriteLine("Nyawa pemain : " + pemain.Health + " | Nyawa musuh: " + enemy1.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "3":
                            Console.Clear();
                            pemain.Rest();
                            Console.WriteLine("Anda memulihkan diri sehingga mana dan health anda bertambah...");
                            enemy1.attack(enemy1.AttackPower);
                            pemain.GetHit(enemy1.AttackPower);
                            Console.WriteLine("Nyawa pemain: " + pemain.Health + " | Nyawa musuh : " + enemy1.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Anda melarikan diri dari pertarungan");
                            Console.WriteLine("Ingat, dengan melarikan diri anda tidak akan menyelesaikan apapun");
                            return;
                            
                    }
                } 
                Console.WriteLine("(Tekan enter untuk melanjutkan)");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Setelah berhasil mengalahkan Bapheus anda kembali melanjutkan perjalanan");
                Console.WriteLine("Mata anda tertuju pada sebuah pancaran cahaya yang berada lumayan jauh dari anda");
                Console.WriteLine("Anda memutuskan untuk mendekat ke sumber cahaya tersebut");
                Console.WriteLine("selang beberapa langkah, tanah yang anda pijak tiba tiba bergetar");
                Console.WriteLine("dari dalam tanah tersebut kemudian muncul monster yang berbentuk seperti cacing namun memiliki kepala seperti bebek");
                Enemy enemy2 = new Enemy();
                enemy2.Nama = "Gordoa";
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Monster tersebut adalah {enemy2.Nama}");
                Console.WriteLine("Pilih aksi anda: ");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Special Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");

                while (!pemain.isDead && !enemy2.isDead)
                {
                    string? playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Anda melakukan single attack");
                            pemain.attack(pemain.AttackPower);
                            enemy2.GetHit(pemain.AttackPower);
                            pemain.EXP += 2;
                            enemy2.attack(enemy2.AttackPower);
                            pemain.GetHit(enemy2.AttackPower);
                            Console.WriteLine("Nyawa Pemain : " + pemain.Health + " | Nyawa musuh : " + enemy2.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "2":
                            Console.Clear();
                            pemain.Swing();
                            pemain.EXP += 2;
                            enemy2.GetHit(pemain.AttackPower);
                            pemain.GetHit(enemy2.AttackPower);
                            Console.WriteLine("Nyawa pemain : " + pemain.Health + " | Nyawa musuh: " + enemy2.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "3":
                            Console.Clear();
                            pemain.Rest();
                            Console.WriteLine("Anda memulihkan diri sehingga mana dan health anda bertambah...");
                            enemy2.attack(enemy2.AttackPower);
                            pemain.GetHit(enemy2.AttackPower);
                            Console.WriteLine("Nyawa pemain: " + pemain.Health + " | Nyawa musuh : " + enemy2.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Anda melarikan diri dari pertarungan");
                            Console.WriteLine("Ingat, dengan melarikan diri anda tidak akan menyelesaikan apapun");
                            return;
                    }
                    if (pemain.EXP >= 100 && pemain.Role != "Mage")
                        {
                            pemain.Role = "Mage";
                            Console.WriteLine("Anda telah naik tingkat dan menjadi seorang penyihir!");
                        }

                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Satu pertarungan lagi telah anda selesaikan");
                Console.WriteLine("Namun jalan keluar keluar masih belum terlihat");
                Console.WriteLine("Anda terus berjalan munuju arah sumber cahaya tersebut");
                Console.WriteLine("Anda terus berjalan...");
                Console.ReadLine();
                Console.WriteLine("Berjalan.....");
                Console.ReadLine();
                Console.WriteLine("Dan berjalan.......");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Sumber cahaya sudah semakin dekat");
                Console.WriteLine("Ternyata sumber cahaya tersebut berasal dari dalam tanah yang terhimpit sebuah batu yang sangat besar");
                Console.WriteLine("Ketika anda berjalan mendekati batu tersebut, tiba tiba batu tersebut berubah menjadi sebuah laba laba raksasa yang siap memakanmu");
                Enemy enemy3 = new Enemy();
                enemy3.Nama = "Liraeth";
                Console.WriteLine($"Monster tersebut adalah {enemy3.Nama} ");
                Console.WriteLine("Pilih aksi anda: ");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Special Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");
                if(pemain.EXP>=100)
                {
                        pemain.Role = "Mage";
                }
                while (!pemain.isDead && !enemy3.isDead)
                {
                    string? playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Anda melakukan single attack");
                            pemain.attack(pemain.AttackPower);
                            enemy3.GetHit(pemain.AttackPower);
                            pemain.EXP += 2;
                            enemy3.attack(enemy3.AttackPower);
                            pemain.GetHit(enemy3.AttackPower);
                            Console.WriteLine("Nyawa Pemain : " + pemain.Health + " | Nyawa musuh : " + enemy3.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "2":
                            Console.Clear();
                            pemain.Swing();
                            pemain.EXP += 2;
                            enemy3.GetHit(pemain.AttackPower);
                            pemain.GetHit(enemy3.AttackPower);
                            Console.WriteLine("Nyawa pemain : " + pemain.Health + " | Nyawa musuh: " + enemy3.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "3":
                            Console.Clear();
                            pemain.Rest();
                            Console.WriteLine("Anda memulihkan diri sehingga mana dan health anda bertambah...");
                            enemy3.attack(enemy3.AttackPower);
                            pemain.GetHit(enemy3.AttackPower);
                            Console.WriteLine("Nyawa pemain: " + pemain.Health + " | Nyawa musuh : " + enemy3.health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Anda melarikan diri dari pertarungan");
                            Console.WriteLine("Ingat, dengan melarikan diri anda tidak akan menyelesaikan apapun");
                            return;
                    }
                    if (pemain.EXP >= 100 && pemain.Role != "Mage")
                        {
                            pemain.Role = "Mage";
                            Console.WriteLine("Anda telah naik tingkat dan menjadi seorang penyihir!");
                        }
                    
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Anda mengira bahwa ini sudah selesai");    
                Console.WriteLine($"Ketika anda melangkah menuju sumber cahaya, bangkai dari {enemy3.Nama} yang sudah anda kalahkan tadi tiba tiba bergerak ");    
                Console.WriteLine($"Semua energi gelap yang ada dihutan tersebut dihisap oleh {enemy3.Nama} dan merubahnya menjadi seekor kalajengking raksasa yang mengerikan");
                BossEnemy boss = new BossEnemy(pemain);
                boss.Nama = "Liraeth V2";
                Console.WriteLine("Anda sudah tidak bisa lari");
                Console.WriteLine($"Ayo kita kalahkan {boss.Nama}!!! ");
                Console.WriteLine("Pilih aksi anda: ");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Special Attack");
                Console.WriteLine("3. Defend");
                while (!pemain.isDead && !boss.isDead)
                {
                    string? playerAction = Console.ReadLine();
                    switch (playerAction)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Anda melakukan single attack");
                            pemain.attack(pemain.AttackPower);
                            boss.GetHit(pemain.AttackPower);
                            pemain.EXP += 2;
                            boss.attack(pemain);
                            pemain.GetHit(boss.AttackPower);
                            Console.WriteLine("Nyawa Pemain : " + pemain.Health + " | Nyawa musuh : " + boss.Health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "2":
                            Console.Clear();
                            pemain.Swing();
                            pemain.EXP += 2;
                            boss.GetHit(pemain.AttackPower);
                            pemain.GetHit(boss.AttackPower);
                            Console.WriteLine("Nyawa pemain : " + pemain.Health + " | Nyawa musuh: " + boss.Health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                        case "3":
                            Console.Clear();
                            pemain.Rest();
                            Console.WriteLine("Anda memulihkan diri sehingga mana dan health anda bertambah...");
                            boss.attack(pemain);
                            pemain.GetHit(boss.AttackPower);
                            Console.WriteLine("Nyawa pemain: " + pemain.Health + " | Nyawa musuh : " + boss.Health);
                            Console.WriteLine($"Exp Anda : {pemain.EXP}   ||  Mana Anda : {pemain.mana}");
                            break;
                    }     
                }while (!pemain.isDead && boss.isDead)
                {
                    Console.WriteLine($"Anda berhasil mengalahkan {boss.Nama}");
                    Console.WriteLine("Kemudian anda melangkah menuju cahaya");
                    Console.WriteLine("Tanpa pikir panjang, anda langsung melompat ke dalam cahaya tersebut");
                    Console.WriteLine("Mata anda terpejam karena silaunya cahaya");
                    Console.WriteLine("Ketika anda membuka mata anda, ternyata anda sekarang berada di atas tempat tidur");
                    Console.WriteLine("Semua hal yang anda lalui tadi ternyata hanyalah mimpi");
                    Console.WriteLine("SELESAI");
                    Console.WriteLine("TERIMAKASIH TELAH BERMAIN");
                    return;
                }
        }
        else 
        {
            Console.WriteLine("Baiklah. Selamat tinggal pecundang, semoga mayatmu membusuk disini");
            return;
        }
    }            
}
            
        

                
    

class Novice
{
    public int Health;
    public string? Nama;
    public int AttackPower;
    public int SkillSlot;
    public bool isDead;
    public int mana;
    public int EXP;
    public string Role;
    Random rng = new Random();

    public Novice()
    {
        Health = 100;
        isDead = false;
        AttackPower = 5;
        mana = 50;
        SkillSlot = 3;
        EXP = 0;
        Role = "Novice";
    }

    public void Swing()
        {
            if (SkillSlot > 0 && mana > 30)
            {
                Console.WriteLine("Anda mengeluarkan seluruh kemampuan anda");
                AttackPower = AttackPower + rng.Next(3, 11);
                SkillSlot--;
                mana-=30;
            }
            else if (SkillSlot == 0 || mana < 30)
            {
                AttackPower = 0;
                Console.WriteLine("energimu belum cukup");
        
            }  
        }
    public void attack (int damage)
    {
        AttackPower = 5;
    }
    public void GetHit(int damage)
        {
            Console.WriteLine("Anda terkena damage : " + damage);
            Health = Health - damage;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Rest()
        {
            if(Health < 100)
            {
            SkillSlot = 3;
            mana += 50;
            EXP += 10;
            Health = Health  + rng.Next(10, 20);
            }
            else if (Health == 100)
            {
                Console.WriteLine("Anda masih baik baik saja");
            }
        }

        public void Die()
        {
            Console.WriteLine(Nama+ " You are dead (innalillahi)");
            isDead = true;
        }

}
class Mage
{
    public int health;
    public string? Nama;
    public int AttackPower;
    public bool isDead;
    public int mana;
    public int SkillSlot;
    public int EXP;
    public string Role;
    Random rng = new Random();
    
    public Mage()
    {
        health = 150;
        isDead = false;
        AttackPower = 8;
        mana = 60;
        SkillSlot = 5;
        EXP = 0;
        Role = "Mage";
    }
    public void Skill()
        {
            if (SkillSlot > 0 && mana > 35)
            {
                Console.WriteLine("REDUCTO ( anda menggunakan mantra yang dapat mengeluarkan petir)");
                AttackPower = AttackPower + rng.Next(10, 25);
                SkillSlot--;
                mana-=35;
            }
            else if (SkillSlot == 0 || mana < 35)
            {
                AttackPower = 0;
                Console.WriteLine("Manamu tidak cukup");
        
            } 
        }
    public void attack (int damage)
    {
        AttackPower = 5;
    }
    public void GetHit(int damage)
        {
            Console.WriteLine("Anda terkena damage : " + damage);
            health = health - damage;

            if (health <= 0)
            {
                health = 0;
                Die();
            }
        }

        public void Rest()
        {
            if(health < 100)
            {
            SkillSlot = 3;
            mana += 50;
            EXP += 10;
            health = health  + rng.Next(10, 20);
            }
            else if (health == 100)
            {
                Console.WriteLine("Anda masih baik baik saja");
            }
        }

        public void Die()
        {
            Console.WriteLine(Nama+ " You are dead (innalillahi)");
            isDead = true;
        }
    
}

class Enemy
{
    public int health;
    public string? Nama;
    public int AttackPower;
    public bool isDead;
    Random rng = new Random();

    public Enemy()
    {
        health = 200;
        isDead = false;
    }
    public void attack(int damage)
    {
        AttackPower = rng.Next(1, 10);
    }
    public void GetHit(int damage)
        {
            Console.WriteLine("Musuh terkena serangan " + damage);
            health = health - damage;

            if (health <= 0)
            {
                health = 0;
                Die();
            }
        }
    public void Die()
    {
        Console.WriteLine("Musuh telah berhasil dimusnahkan");
        isDead = true;
    }
}
class BossEnemy
{
    public int Health;
    public string Nama;
    public int AttackPower;
    public double SpecialSkillDamage;
    public double InstantDeathChance;
    public bool isDead { get; set; }
    Random rng = new Random();

    public BossEnemy(Novice pemain)
    {
        Health = 1000;
        Nama = "Bos Musuh";
        isDead = false;
        AttackPower = rng.Next(15, 20); //attack power dari novice adalah 5, sehingga ketika dikali 3 hasil attack power boss musuh adalah 15  
        SpecialSkillDamage = pemain.Health * 0.33;
        InstantDeathChance = 0.05; 
    }

    public void attack(Novice pemain)
    {
        double damage = AttackPower;

        if(Health <=600 && rng.NextDouble() < SpecialSkillDamage)
        {

        if (rng.NextDouble() < InstantDeathChance)
        {
            Console.WriteLine("Bos Musuh menggunakan serangan instant death!");
            pemain.Die();
        }
        else if (rng.NextDouble() < SpecialSkillDamage)
        {
            Console.WriteLine("Bos Musuh menggunakan special skill dan memberikan kerusakan besar!");
            pemain.GetHit((int)(Health * SpecialSkillDamage));
        }
        else
        {
            Console.WriteLine($"Bos Musuh menyerang dengan kekuatan {damage}");
            pemain.GetHit((int)damage);
        }
        } else {
            AttackPower = 20;
        }
    }
public void GetHit(int damage)
        {
            Console.WriteLine("Musuh terkena serangan " + damage);
            this.Health = Health - damage;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }
    public void Die()
    {
        Console.WriteLine("Musuh telah berhasil dimusnahkan");
        isDead = true;
    }
}


