/*
 * Student ID : 1690703622
 * Name       : Pattaradanai Boonreang
 * Section    : 129B
 * No.        : NA
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{


    internal class Program

    {

        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} /  {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percentage: {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} /  {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");


            // ===== Character 1 =====
            string name1 = "Nergigante";
            int hp1 = 240;
            float attack1 = 42.5f;
            double crit1 = 1.75;
            char rank1 = 'S';

            Console.WriteLine("===== CHARACTER 1 =====");
            Console.WriteLine($"Name: {name1}");
            Console.WriteLine($"HP: {hp1}");
            Console.WriteLine($"Attack Power: {attack1}");
            Console.WriteLine($"Critical Multiplier: {crit1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine();

            // ===== Character 2 =====
            string name2 = "Teostra";
            int hp2 = 220;
            float attack2 = 45.5f;
            double crit2 = 1.80;
            bool isWyvern = false;

            Console.WriteLine("===== CHARACTER 2 =====");
            Console.WriteLine($"Name: {name2}");
            Console.WriteLine($"HP: {hp2}");
            Console.WriteLine($"Attack Power: {attack2}");
            Console.WriteLine($"Critical Multiplier: {crit2}");
            Console.WriteLine($"Is Wyvern: {isWyvern}");
            Console.WriteLine();

            // ===== Character 3 =====
            string name3 = "Vaal Hazak";
            int hp3 = 260;
            float attack3 = 38.5f;
            double crit3 = 1.65;
            bool isElderDragon = true;

            Console.WriteLine("===== CHARACTER 3 =====");
            Console.WriteLine($"Name: {name3}");
            Console.WriteLine($"HP: {hp3}");
            Console.WriteLine($"Attack Power: {attack3}");
            Console.WriteLine($"Critical Multiplier: {crit3}");
            Console.WriteLine($"Is Elder Dragon: {isElderDragon}");
            Console.WriteLine();

            // ===== Character 4 =====
            string name4 = "Xeno'jiiva";
            int hp4 = 300;
            float attack4 = 50.5f;
            char rank4 = 'S';
            bool isFinalBoss = true;

            Console.WriteLine("===== CHARACTER 4 =====");
            Console.WriteLine($"Name: {name4}");
            Console.WriteLine($"HP: {hp4}");
            Console.WriteLine($"Attack Power: {attack4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"Is Final Boss: {isFinalBoss}");

        }
    }

}
    
