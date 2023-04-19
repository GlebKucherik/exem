using System;

namespace ConsoleApp8
{
    class Program
    {
       public static void Main(string[] args)
        {
            
            string[] AS; 
            int count; 
            string s;
           
            
           
            
            //строки
            Console.WriteLine("Введите кол-во строк (для заполнения одного продукта нужно ввести 3 строки) ");
            count = Int32.Parse(Console.ReadLine());

            
            AS = new string[count];

            
            Console.WriteLine("Заполение:");
            //ввод
            for (int i = 0; i < AS.Length; i++)
            {

            
                Console.Write("Введите [{0}] = ", i);
                 AS[i] = Console.ReadLine();
            }

            // Сортировка
            for (int i = 0; i < AS.Length - 1; i++)
                for (int j = i; j >= 0; j--)
                    if (String.Compare(AS[j], AS[j + 1]) > 0) 
                    {
                        
                        s = AS[j];
                        AS[j] = AS[j + 1];
                        AS[j + 1] = s;
                    }

          
            Console.WriteLine("Сортировка массива:");
            for (int i = 0; i < AS.Length; i++)
                Console.WriteLine("вывод[{0}] = {1}", i, AS[i]);

            Console.ReadKey();
        }
    }
}