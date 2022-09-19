// ЗАДАЧА 66_____________________________________________________________

Console.Write("Введите M: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);

if (n>=1 && m>= 1 && n>m){
    Console.WriteLine($"Сумма элементов от {m} до {n} = {GetSum(m, n)}");
}
else{
    Console.WriteLine("Ошибка!");
}

if (!isM || !isN ){
    Console.WriteLine("Введите число.");
    return;
}

int GetSum(int m, int n)
{
    if (m == n)
        return n;
    return n + GetSum(m, n - 1);
}
