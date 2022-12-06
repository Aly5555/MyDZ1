/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
/*
Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);
if (num1 < num2)
{   
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}  
else if (num1 == num2)
{
    Console.WriteLine($"Число {num1} равно числу {num2}");
} 
else 
{
     Console.WriteLine($"Число {num1} больше числа {num2}");
}

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/*
Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);

Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);

Console.WriteLine("Введите третье число");
string number3 = Console.ReadLine();
int num3 = Convert.ToInt32(number3);

int max = num1;

if (num1 > max) max=num1;
if (num2 > max) max=num2;
if (num3 > max) max=num3;

{
Console.WriteLine($"Максимальное число это {max} ");
}
*/



/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */
/*
Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);

if (num1 % 2 == 0)

    Console.WriteLine($"Число {num1} четное ");
else
{
    Console.WriteLine($"Число {num1} нечетное");
}

*/
/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


/*



Console.WriteLine("Введите число N");
string number1 = Console.ReadLine();
int N = Convert.ToInt32(number1);
int num = 2;
for (int i=2; i<=N; i=i+2)
{
    if (i<=N)
    Console.WriteLine("четное " + num);
    num = (-(~num)); num = (-(~num));
}
*/

Console.WriteLine("Введите N");
string number1 = Console.ReadLine();
int N = Convert.ToInt32(number1);  
  byte num = 2;
            while (num <= N)
            {
                int result = num % 2;
                if (result != 1)
                {
                    Console.WriteLine("четное " + num);
                    num++;
                }
                else
                {
                    num++;
                }
            }
