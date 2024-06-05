using System;

namespace UTS_05;

    class Player
{
    public int Health;
    public string ?Nama;
    public int AttackPower;
    public int SkillSlot;
    public bool isDead;
    public int mana;
    public int EXP;
    public string Role;
    Random rng = new Random();

    public Player()
    {
        Health = 100;
        isDead = false;
        AttackPower = 5;
        mana = 50;
        SkillSlot = 3;
        EXP = 0;
        Role = "Novice";
    }

    public virtual void Skill(Enemy enemy)
        {
            if (SkillSlot > 0 && mana > 30)
            {
                Console.WriteLine("Anda mengeluarkan seluruh kemampuan anda");
                AttackPower = AttackPower + rng.Next(3, 11);
                SkillSlot--;
                mana-=30;
            }
            else if (SkillSlot == 0 || mana < 30)
            {
                AttackPower = 0;
                Console.WriteLine("energimu belum cukup");
        
            }  
        }
    public  virtual void attack (int damage)
    {
        AttackPower = 5;
    }
    public virtual void GetHit(int damage)
        {
            Console.WriteLine("Anda terkena damage : " + damage);
            Health = Health - damage;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public virtual void Rest()
        {
            if(Health < 100 || SkillSlot <3)
            {
            SkillSlot = 3;
            mana += 50;
            EXP += 10;
            Health = Health  + rng.Next(10, 20);
            }
            else if (Health == 100 && SkillSlot == 0)
            {
                Console.WriteLine("Belum bisa dipakai");
            }
        }

        public virtual void Die()
        {
            Console.WriteLine(Nama+ " You are dead (innalillahi)");
            isDead = true;
        }

        internal void GetHit(Action<Player> attackPower)
        {
            throw new NotImplementedException();
        }
    }