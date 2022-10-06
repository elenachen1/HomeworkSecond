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

            Console.WriteLine("Задача 1. Данная задача на вход принимает трехзначное число и выводит вторую цифру этого числа");
            Console.WriteLine("Введите трехзначное число");
            int ThreeDigitNumber = int.Parse(Console.ReadLine());

            int digits = (int) Math.Log10(Math.Abs(ThreeDigitNumber)) + 1;

            if (digits == 3)
            {
                Console.WriteLine((ThreeDigitNumber%100)/10);
            }

            else{
                Console.WriteLine("Число не является трехзначным");
            }
            break;

        case 2:
            break;
        case 3:
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



