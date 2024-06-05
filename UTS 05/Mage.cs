using System;
using System.Diagnostics.Contracts;
namespace UTS_05;

    class Mage : Player
    {
        public Mage()
        {
            Health = 250;
            AttackPower = 10;
            SkillSlot = 4;
        }
        public override void Skill(Enemy enemy)
        {
            if(SkillSlot != 0 || mana>=30)
            {
                Console.WriteLine("Skill : Lightning bolt !!!!");
                enemy.GetHit(AttackPower + 75);
                mana-=30;
                SkillSlot--;
            }
            else 
            {
                Console.WriteLine("Kekutan tidak bisa digunakan");
            } 
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
