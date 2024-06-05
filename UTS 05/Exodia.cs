using System;

namespace UTS_05;
    class Exodia : Enemy
    {
        public int Health;
        public int AttackPower;
        Random rng = new Random();

        public Exodia()
        {
            Health = 1000;
            Nama = "Devil Liraeth";
        }
        public override void bossSkill(Player pemain)
        {
            base.bossSkill(pemain);
        }
        public override void attack(int damage)
        {
            AttackPower = rng.Next(15, 20);
        }
        public override void GetHit(int damage)
        {
            base.GetHit(damage);
        }
        public override void Die()
        {
            base.Die();
        }


    }
