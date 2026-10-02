
// Student ID :1690703622
// Name       :Pattaradnai Boonreang
// Section    :129B
// No.        :37
// Course     : GI113 Computer Programming (GI)

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0;

            //if (lives == 0)
            //{
            //    Console.WriteLine("Game Over!"); 
            //}
            //else
            //{
            //    Console.WriteLine("Continue to play!");    
            //}
            //เมื่อเงื่อนไขทำงานสำเร็จแล้ว หรือ เงื่อนไขไม่ตรงเลยโค้ดทำงานต่อ
            //Console.WriteLine(" Continue to run");

            //bool hasKey = true; 
            //Console.Write("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);

            //if (!ok || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid level.");
            //}
            //else if (level >= 10 && hasKey )
            //{
            //    Console.WriteLine("The door opens.");
            //}
            //else if (level >= 5)
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else
            //{
            //   Console.WriteLine("The door stays shut.");
            //}


            int heroLukeHp = 100;
            int heroLukeMp = 100;
            int mageSeekerHp = 100;
            int mageSeekerMp = 100;
            int heroLukeAtk = 50;
            int skill1Atk = 100;
            int skill1MpCost = 40;
            int skill2Heal = 50;
            int skill2MpCost = 50;
            int useItem = 100;


            Console.WriteLine("=============================");
            Console.WriteLine("   GAME TITLE:LORD OF ADEN   ");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("HERO LUKE ENCOUNTER A MAGESEEKER!!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: USE SKILL 1 FIREBLADE SLASH");
            Console.WriteLine("ACTION 3: USE SKILL 2 HEAL");
            Console.WriteLine("ACTION 4: USE ITEM TOTEM OF ANTI MAGIC");
            Console.WriteLine();

            Console.WriteLine("CHOOSE YOUR ACTION (1-4): ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isInputValid == false || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid Input, Please enter action between 1 and 4");
            }
            else if (choice == 1)
            {
                mageSeekerHp -= heroLukeAtk;
                Console.WriteLine($"Hero Luke attacked the mageseeker!!! with {heroLukeAtk} DMG, Mageseeker now have {mageSeekerHp} HP left!");
            }
            else if (choice == 2)
            {
                mageSeekerHp -= skill1Atk;
                heroLukeMp -= skill1MpCost;
                if (mageSeekerHp  <=0)
                {
                    Console.WriteLine($"Hero Luke used skill fireblade slash to mageseeker!!! with {skill1Atk} DMG, Mageseeker is defeated!!");
                    Console.WriteLine($"Hero Luke has {heroLukeMp} MP left");
                }
                else
                {
                    Console.WriteLine($"Hero Luke used skill fireblade slash to mageseeker!!! with {skill1Atk} DMG, Mageseeker now have {mageSeekerHp} HP left!");
                    Console.WriteLine($"Hero Luke has {heroLukeMp} MP left");
                }
            }
            else if (choice == 3)
            {
                heroLukeHp +=skill2Heal;
                heroLukeMp -= skill1MpCost;

                Console.WriteLine($"Hero Luke used skill heal, Hero Luke HP is now {heroLukeHp} Points");
                Console.WriteLine($"Hero Luke has {heroLukeMp} MP left");

            }
            else if (choice == 4)
            {
                mageSeekerMp -= useItem;
               Console.WriteLine($"Hero Luke used Totem of anti magic to the mageseeker! with -{useItem} MP, Mageseeker now have {mageSeekerMp} MP left!");

            }
            Console.WriteLine();

            if (mageSeekerMp > 0)
            {
                Console.WriteLine("End turn");
            }
            else
            {
            }
            


        }
    }
}
