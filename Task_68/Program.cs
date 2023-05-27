// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int AckermannFormula (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFormula(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFormula(numberM - 1, AckermannFormula(numberM, numberN - 1));
    return AckermannFormula(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFormula(numberM, numberN)}");