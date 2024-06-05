using System;

namespace UTS_05;
    class Novice : Player
    {
        public Novice()
        {
            Health = 100;
            AttackPower = 5;
            SkillSlot = 4;
        }
        public override void Skill(Enemy enemy)
        {
            if(SkillSlot<=4 && mana>=30)
            {
            Console.WriteLine("spesial skill : Heavy Attack ");
            AttackPower += 10;
            SkillSlot--;
            mana-=30;
            }
            else if ( enemy.isStuned || mana < 30 || SkillSlot == 0 )
            {
                Console.WriteLine("Kekutan tidak bisa digunakan");
            }
        }
        public override void Rest()
        {
            base.Rest();
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
