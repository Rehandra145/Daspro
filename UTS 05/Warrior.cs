using System;

namespace UTS_05;

    class Warrior : Player
    {
        public bool isStuned{get; set;}
        public int stunDuration{get; set;}
        public Warrior()
        {
            Health = 250;
            AttackPower = 10;
            SkillSlot = 4;
        }
        public override void Skill(Enemy enemy)
        {
            if(!enemy.isStuned && SkillSlot<=4 && mana>=30)
            {
            Console.WriteLine("spesial skill : emuach!!!! (musuh ter stun selama 2 turn)");
            enemy.isStuned = true;
            stunDuration = 2;
            SkillSlot--;
            mana-=30;
            }
            else if ( enemy.isStuned || mana < 30 || SkillSlot == 0 )
            {
                Console.WriteLine("Kekutan tidak bisa digunakan");
            }else if (enemy.isStuned)
            {
                stunDuration--;
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
