using System;

namespace UTS_05;
    class Enemy
    {
        public int health;
        public string? Nama;
        public int AttackDamage;
        public bool isDead;
        public double SpecialSkillDamage;
        public double InstantDeathChance;
        public bool isStuned;
        Random rng = new Random();

        public Enemy()
        {
            health = 200;
            isDead = false;
            isStuned = false;
        }
        public virtual void attack(int damage)
        {
            AttackDamage = 10;
        }
        public virtual void GetHit(int damage)
        {
            Console.WriteLine("Musuh terkena serangan " + damage);
            health = health - damage;

            if (health <= 0)
            {
                health = 0;
                Die();
            }
        }
        public virtual void Die()
        {
            Console.WriteLine("Musuh telah berhasil dimusnahkan");
            isDead = true;
        }
        public virtual void bossSkill(Player pemain)
        {
            double damage = AttackDamage;

            if (health <= 600 && rng.NextDouble() < SpecialSkillDamage)
            {

                if (rng.NextDouble() < InstantDeathChance)
                {
                    Console.WriteLine("Bos Musuh menggunakan serangan instant death!");
                    pemain.Die();
                }
                else if (rng.NextDouble() < SpecialSkillDamage)
                {
                    Console.WriteLine("Bos Musuh menggunakan special skill dan memberikan kerusakan besar!");
                    pemain.GetHit((int)(health * SpecialSkillDamage));
                }
                else
                {
                    Console.WriteLine($"Bos Musuh menyerang dengan kekuatan {damage}");
                    pemain.GetHit((int)damage);
                }
            }
            else
            {

            }
        }
    }




