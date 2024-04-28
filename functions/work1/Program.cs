// Функции состоят из трех частей 1) Тип значения 2) Имя 3) параметры
// Если функция ничего не возвращает, фкнция называется VOID

// Функция может не иметь параметров и взвращаемых данных
//Функция может ничего не принимать но возвращать что-то

// Если функция влияет на среду, это побочный эффект


double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denuminator = c + d;
    double result = numenator / denuminator;
    return result;
}
double result1 = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result1);


































