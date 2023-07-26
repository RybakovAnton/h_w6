// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите колличество чисел");
int m = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < m; i++)
{
    System.Console.WriteLine($"Введите число {i + 1}: ");
    int num = int.Parse(Console.ReadLine());
    
    if (num>0)
    {
        count++;
    }
}
System.Console.WriteLine($"Кол-во чисел больше нуля: "+ count);

