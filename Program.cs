using System;

namespace PrintSimvol
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Выберите имя для вывода");
            string userName = Console.ReadLine();
            Console.WriteLine("Выберите символ");
            char userChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int addingSymvol = 2;
            int rectangleHeight = 3;
            Console.Write("\n");

                for(int i=0;i<rectangleHeight;i++)
                {
                    
                    if (i == 0)
                    {
                    for(int u=0;u<userName.Length+addingSymvol;u++)
                    {
                        Console.Write(userChar);
                    }
                    Console.Write("\n");
                    }

                   if (i == 1) 
                    {
                    Console.Write(userChar + userName + userChar);
                    Console.Write("\n"); 
                    }
                    
                   if (i == 2) 
                   {
                    for (int u = 0; u < userName.Length + addingSymvol; u++)
                    {
                        Console.Write(userChar);
                    }
                    Console.Write("\n");
                    }
                }
            Console.ReadLine();
        }
    }
}
