// ЗАДАЧА 68_____________________________________________________________

Console.Write("Введите M: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);

if (n>=0 && m>= 0){
    Console.WriteLine($"A({m}, {n}) = {GetAkkerman(m, n)}");
}
else{
    Console.WriteLine("Ошибка!");
}

if (!isM || !isN ){
    Console.WriteLine("Введите число.");
    return;
}

int GetAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return GetAkkerman(m - 1, 1);
    else
        return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}
