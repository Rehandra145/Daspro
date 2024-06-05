using System;

namespace UTS_05;
    class Acolyte : Player
    {
        public Acolyte()
        {
            Health = 250;
            AttackPower = 10;
            SkillSlot = 4;
        }
        public override void Skill(Enemy enemy)
        {
            if(Health < 100 ||  SkillSlot <=4 )
            {
            Health += Health/2;
            mana -= 30;
            Console.WriteLine("Anda menggunakan kekuatan untuk memulihkan diri!!");
            }
            else if (Health == 100 || SkillSlot == 0 )
            {
                Console.WriteLine("Kekutan tidak bisa digunakan");
            }else if (Health >= 100 && SkillSlot > 4)
            {
                Console.WriteLine("Skill tidak bisa digunakan\nkarna anda masih baik baik saja Anda masih baik baik saja");
            }
        }
        public override void Rest()
        {
            if(Health < 100 || SkillSlot <3)
            {
            SkillSlot = 3;
            mana += 50;
            EXP += 10;
            }
            else if (Health == 100 && SkillSlot == 0)
            {
                Console.WriteLine("Belum bisa dipakai");
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
