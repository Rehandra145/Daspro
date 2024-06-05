using System;

namespace UTS_05;
    class Liraeth : Enemy
    {
        public Liraeth()
        {
            health = 300;
            Nama = "Liraeth";
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
