using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
//Упражнение 2.1 Написать программу, которая спрашивает имя
//пользователя, и затем приветствует пользователя по имени. (Создать
//консольное приложение.)
Console.WriteLine("Упражнение 2.1");
Console.WriteLine("Здравствуйте, как вас зовут?");
string nameValue = Console.ReadLine();
Console.WriteLine("Добрый день, {0}!", nameValue);
//Упражнение 2.2 Написать программу, которой на вход подается два
//целых числа, на выходе – результат деления одного числа на другое.
//Предусмотреть обработку исключительной ситуации, возникающей при
//делении числа на ноль.
Console.WriteLine("Упражнение 2.2");
int numValue1, numValue2;
string inputValue1 = Console.ReadLine(), inputValue2 = Console.ReadLine();
if (inputValue2 != "0" && int.TryParse(inputValue1, out numValue1) && int.TryParse(inputValue2, out numValue2))
{
    Console.WriteLine(numValue1 / numValue2);
}
else
    Console.WriteLine("Извините, произошла ошибка");
//Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать
//следующую за ней букву в алфавитном порядке.
Console.WriteLine("Домашнее задание 2.1");
char charValue = Console.ReadLine()[0];
int standardCode = (int)charValue;
if (standardCode == 1071)
{
    Console.WriteLine((char)1040);
}
else if (standardCode == 1103)
{
    Console.WriteLine((char)1072);
}
else if (standardCode == 122)
{
    Console.WriteLine((char)97);
}
else if (standardCode == 90)
{
    Console.WriteLine((char)65);
}
else if (charValue == 'Ё')
{
    Console.WriteLine('Ж');
}
else if (charValue == 'Е')
{
    Console.WriteLine('Ё');
}
else if (charValue == 'ё')
{
    Console.WriteLine('ж');
}
else if (charValue == 'е')
{
    Console.WriteLine('ё');
}
else if ((standardCode < 1071 && standardCode >= 1040) || (standardCode < 1103 && standardCode >= 1072)
    || (standardCode < 122 && standardCode >= 97) || (standardCode < 90 && standardCode >= 65))
{
    Console.WriteLine((char)(standardCode + 1));
}
//Домашнее задание 2.2 Написать программу, которая решает квадратное
//уравнение. Входные данные – коэффициенты уравнения, выходные –
//найденные корни. a b c
Console.WriteLine("Домашнее задание 2.2");
double aCoef, bCoef, cCoef;
string aValue = Console.ReadLine(), bValue = Console.ReadLine(), cValue = Console.ReadLine();

if (aValue == "0")
{
    Console.WriteLine("Извините, это не квадратное уравнение");
}
else if (double.TryParse(aValue, out aCoef) && double.TryParse(bValue, out bCoef) && double.TryParse(cValue, out cCoef))
{
    double dCoef = bCoef * bCoef - 4 * cCoef * aCoef;
    if (dCoef == 0)
    {
        if (bCoef == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(-bCoef / 2 / aCoef);
        }
    }
    else if (dCoef > 0)
    {
        Console.WriteLine((-bCoef - Math.Sqrt(dCoef)) / 2 / aCoef);
        Console.WriteLine((-bCoef + Math.Sqrt(dCoef)) / 2 / aCoef);
    }
    else
    {
        Console.WriteLine("Уравнение не имеет корней");
    }
}
else
{
    Console.WriteLine("Извините, но вы указали некорректные коэффициенты");
}