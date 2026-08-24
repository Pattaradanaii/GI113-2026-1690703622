/*
 * Student ID : 1690703622
 * Name       : Pattaradanai Boonreang
 * Section    : 129B
 * No.        : NA
 * Course     : GI113 Computer Programming (GI)
 */
namespace Demo1
{

    interface class Program
    {

        static void Main(string[] args)
        {
            string bossName = "Kirin"; //string เก็บข้อมูลเปป็นชุดตัวอักษร หรือ ที่เรียกว่าข้อความ
            char rank = 's';    //char เก็บข้อมูลได้ตัวอักษรอันเดียว
            int maxHp = 240;    //int เป็น Integer เก็บขอมูลจำนวนเต็มบวก,เต็มลบ, 0
            int currentHp = 175;
            float attackPower = 42.5f; //float ใส่ทศนิยมได้แต่ต้องเติม f ลงท้าย
            double critMultipier = 1.75; //double ใส่ทศนิยมได้หลายตัวกว่า float และไม่ต้องเติม f
            bool isBoss = true;         //ใส่ได้แค่สองค่า True/False
            Console.WriteLine("Hello,World");
        }
    }