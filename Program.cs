//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы. 
//Пример  M = 1; N = 5 -> "1, 2, 3, 4, 5" 
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string argument)  
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}
string NumbersRec1(int m, int n)
{
    if (m < n + 1) return $"{m} " + NumbersRec1(m + 1, n);
    else return String.Empty;
}
int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");
System.Console.WriteLine(NumbersRec1(m, n));

   

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. ПРИМЕР: m = 2, n = 3 -> A(m,n) = 29

//static uint Akk(uint m, uint n)
//{
//    if (m == 0)
//    {
//        return n + 1;
//    }
//    else if (n == 0)
//    {
//        return Akk(m - 1, 1);
//    }
//    else
//   {
//        return Akk(m - 1, Akk(m, n - 1));
//    }
//}
 
//Console.WriteLine(Akk(3, 2)); 
//Console.ReadKey();


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы
//пример:[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

//void OutpetElementsInReverseOrder(int[] array, int i = 0)
//{
//    if (i < array.Length)
//    {
//        OutpetElementsInReverseOrder(array, i + 1);
//        Console.Write(array[i] + " ");
//    }
//}
//int[] array = { 1, 2, 5, 0, 10, 34 };
//OutpetElementsInReverseOrder(array);





