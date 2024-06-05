using System;
using System.Diagnostics.Contracts;

namespace UTS_05;
    class Bapheus : Enemy
    {
        public Bapheus()
        {
            health = 100;
            Nama = "Bapheus";
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
