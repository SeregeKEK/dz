void Задание1()
{//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
  
    Console.WriteLine("Введите число а:");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число b:");
    int b = Convert.ToInt32(Console.ReadLine());
    string result;
    if (a > b)
    {
    result = $"{a}";
    }

    else
    {
        if (a == b)
        {
            result = "Числа равны";
        }
        else
        {
        result = $"{b}";
        }
    }
    Console.WriteLine(result);}

void Задание2()
{//Задача 4: Напишите программу, которая принимает на вход три числа
 //и выдаёт максимальное из этих чисел.
   
    Console.WriteLine("Введите число a:");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число b:");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число c:");
    int c = Convert.ToInt32(Console.ReadLine());
    int max = a;
    string result = $"Максимальное число {max}";

    if (max < b)
    {
        max = b;
        result = $"Максимальное число {max}";
    }
    if (max < c)
    {
        max = c;
        result = $"Максимальное число {max}";
    }
    Console.WriteLine(result);
}

void Задание3()
{//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 //является ли число чётным (делится ли оно на два без остатка).
    Console.WriteLine("Введите число :");
    int a = Convert.ToInt32(Console.ReadLine());
    string result = "Нечётное число";

    if(a % 2 == 0)
    {
        result = "Чётное число";
    }

    Console.WriteLine(result);
}

void Задание4()
{//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число :");
int a = Convert.ToInt32(Console.ReadLine());
int startnumber = 1;

while(startnumber != (a + 1))
{
    if(startnumber % 2 == 0)
    {
        Console.Write(startnumber + ",");
    }
    startnumber += 1;
}

Console.Write("\b ");
}


//Задание1();
//Задание2();
//Задание3();
Задание4();