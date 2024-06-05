using System;

namespace UTS_05;
    class Gordoa : Enemy
    {
        public Gordoa()
        {
            health = 150;
            AttackDamage = 10;
            Nama = "Gordoa";
        }
        public override void attack(int damage)
        {
            base.attack(damage);
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
