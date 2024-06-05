using System;

namespace UTS_05;

    class Rogue : Player
    {
        public Rogue()
        {
            Health = 250;
            AttackPower = 10;
            SkillSlot = 4;
        }
        public override void Skill(Enemy enemy)
        {
            if(SkillSlot <= 4 && mana >= 30)
            Console.WriteLine("Skill : Raging Blow!!!!!");
            AttackPower += AttackPower *3;
            SkillSlot--;
            mana-=30;
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
