Console.WriteLine("ЗАДАЧА, выводащая a в степени b");
int term(int num1, int num2)
{
    int result = Convert.ToInt32(Math.Pow(num1, num2));
    return result;
}
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Первое число в степени второго числа: {term(num1, num2)}");

Console.WriteLine("ЗАДАЧА, выводащая сумму цифр в числе");
int SumOfDigits(int num)
{
    int sum = 0;
    for (; num > 0;)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = SumOfDigits(number);
Console.WriteLine($"Сумма цифр числа {number} : {result}");

Console.WriteLine("ЗАДАЧА, выводащая массив пользовательских чисел");
int[] CreateArray (int length){
    int[] arr = new int[length];
    for(int i = 0; i < length; i++){
        arr[i] = new Random().Next(0, 8 + 1);
    }
    return arr;
}
int length = 8;
int[] lst = CreateArray(length);
Console.Write($"[{String.Join(" ", lst)}]");






