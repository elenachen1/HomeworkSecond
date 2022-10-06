Console.WriteLine("Введите номер задачи от 1 до 4 включительно ");
Console.WriteLine("Если вы хотите завершить выполнение программы, то отправте значение 0 ");

int caseNumber = int.Parse(Console.ReadLine());

while ( caseNumber != 0 ){
   switch(caseNumber)
    {
        case 1:
            /* 
            Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            456 -> 5
            782 -> 8
            918 -> 1
            */

            Console.WriteLine("Задача 1. Данная задача на вход принимает трехзначное число и выводит вторую цифру этого числа.");
            Console.WriteLine("Введите трехзначное число:");
            int ThreeDigitNumber = int.Parse(Console.ReadLine());

            int digits = (int) Math.Log10(Math.Abs(ThreeDigitNumber)) + 1;

            if (digits == 3)
            {
                Console.WriteLine((ThreeDigitNumber%100)/10);
            }

            else
            {
                Console.WriteLine("Число не является трехзначным.");
            }
            break;

        case 2:
            /*
            Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            645 -> 5
            78 -> третьей цифры нет
            32679 -> 6
            */

            Console.WriteLine("Задача 2. Данная задача на вход принимает  число и выводит третью цифру этого числа или выводи, что ее нет.");
            Console.WriteLine("Введите число:");

            int number = int.Parse(Console.ReadLine());
            int lenght;
            

            if(number == 0)
            {
                lenght = 1;
            }
            else
            {
                lenght = (int) Math.Log10(Math.Abs(number)) + 1;
            }
             
            if (lenght >= 3)
            {
                
                int item = lenght - 3;
                int count = 1;
                while(count <= item )
                {
                    number = number / 10;
                    count++;
                }


                Console.WriteLine((number%10));
            }

            else
            {
                Console.WriteLine("Третьей цифры нет.");
            }

            break;

        case 3:

            /*
            Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            6 -> да
            7 -> да
            1 -> нет
            */
            Console.WriteLine("Задача 3. Данная задача на вход принимает число, обозначающее день недели, и выводит является ли число выходным или нет.");
            Console.WriteLine("Введите число:");

            int day = int.Parse(Console.ReadLine());

            if (day == 6 || day == 7)
            {
                Console.WriteLine("Да, выходной.");
            }

            else
            {
                Console.WriteLine("Нет, будний день.");
            }
        
            break;
        case 4:
            break;
        default:
            break;

    }
    Console.WriteLine("Введите номер задачи от 1 до 4 включительно ");
    Console.WriteLine("Если вы хотите завершить выполнение программы, то отправте значение 0 ");
    caseNumber = int.Parse(Console.ReadLine()); 
}



