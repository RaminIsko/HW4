Console.WriteLine("ЗАДАЧА, выводащая a в степени b");
int term (int num1,int num2){
    int result = Convert.ToInt32(Math.Pow(num1, num2));
    return result;
}
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Первое число в степени второго числа: {term(num1, num2)}");
