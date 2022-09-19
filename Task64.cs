// ЗАДАЧА 64_____________________________________________________________

Console.Write("Введите M: ");
bool isM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите N: ");
bool isN = int.TryParse(Console.ReadLine(), out int n);

if (n>=1 && m>= 1 && n>m){
    Console.WriteLine(NaturalNumber(n, m));
}
else{
    Console.WriteLine("Ошибка!");
}

if (!isM || !isN ){
    Console.WriteLine("Введите число.");
    return;
}

int NaturalNumber(int n, int m)
{
    if (m == n)
        return m;
    else
        Console.Write($"{NaturalNumber(n-1, m)}, ");
    return n;
}
