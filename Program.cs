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
            Console.Write("\n");
            string middleLine = "";

            for (int i = 0; i < userName.Length + addingSymvol; i++)
            {
                middleLine = middleLine + userChar;
            }
            Console.Write(middleLine+"\n");
            Console.Write(userChar+ userName+userChar+"\n");
            Console.Write(middleLine+"\n");
            Console.ReadLine();
        }
    }
}
