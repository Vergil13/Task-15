
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("введите номер дня недели");
int x=Convert.ToInt32(Console.ReadLine());
if (x<0)
Console.Write("Вы ввели некорректное число");
else if (x>7)
Console.Write("Вы ввели некорректное число");
else if (x<6)
Console.Write("Ваш день буднечный");
else 
Console.WriteLine("ваш день выходной");

    


