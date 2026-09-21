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
            int mageSeekerhp = 100;
            int mageSeekermp = 100;
            int heroAtk = 50;
            int skill1Atk = 100;
            int skill2Heal = 50;
            int useItem = 100;



            Console.WriteLine("GAME TITLE:LORD OF ADEN");
            Console.WriteLine("HERO LUKE ENCOUNTER A MAGESEEKER");
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: USE SKILL 1 FIREBLADE SLASH");
            Console.WriteLine("ACTION 3: USE SKILL 2 HEAL");
            Console.WriteLine("ACTION 4: USE ITEM TOTEM OF ANTI MAGIC");

        }
    }
}
