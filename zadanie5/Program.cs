//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0){
    Console.WriteLine($"Вы ввели четное число - {a}"); 
}
else {
    Console.WriteLine($"Вы ввели нечетное число - {a}");
}