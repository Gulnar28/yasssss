using System;

namespace yasss
{
    class Program
    {
        private static object age;

        static void Main(string[] args)
        {
            int yas, il1, il2, ay1, ay2, gun1, gun2;



            Console.Write("yasi daxil et:");
            yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("gun1 ededini daxil et:");
            gun1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("gun2 ededini daxil et:");
            gun2 = Convert.ToInt32(Console.ReadLine());
            if (gun1 > gun2)
            {
                Console.WriteLine($"{age}-1");
            }


            Console.Write("ay1 ededini daxil et:");
            ay1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ay2 ededini daxil et:");
            ay2 = Convert.ToInt32(Console.ReadLine());
            if (ay1 > ay2)
            {
                Console.WriteLine($"{age}-1");
            }


            Console.Write("il1 ededini daxil et:");
            il1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("il2 ededini daxil et:");
            il2 = Convert.ToInt32(Console.ReadLine());
            int age1 = il2 - il1;
            Console.WriteLine($"{il2}-{il1}={age1}");


            if (age1 > 1)
            {
                Console.WriteLine("yasi tamamdir");
            }
            else
            {
                Console.WriteLine("yasi tamam deyil");
            }
        }
    }
}












        
    


