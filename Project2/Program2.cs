using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

void StartTask(int n)
{
    Console.WriteLine("Задание {0}", n);
}


//1.Вывести на экран число e (основание натурального логарифма) с точностью до
//десятых.
StartTask(1);
Console.WriteLine(Math.Round(Math.Exp(1), 1));


//2. Вывести на экран числа 50 и 10 одно под другим
StartTask(2);
Console.WriteLine("50\n10");


////3.Составить программу вывода на экран «столбиком» четырех любых чисел.
StartTask(3);
Random secondTask = new Random();
double secondInt1 = secondTask.Next(1000), secondInt2 = secondTask.Next(1000), secondInt3 = secondTask.Next(1000), secondInt4 = secondTask.Next(1000);
string secondString1 = secondInt1.ToString().PadLeft(10);
string secondString2 = secondInt2.ToString().PadLeft(10);
string secondString3 = secondInt3.ToString().PadLeft(10);
string secondString4 = secondInt4.ToString().PadLeft(10);
Console.WriteLine("{0}  {1}", secondString1, secondString2);
Console.WriteLine("{0}  {1}", secondString3, secondString4);


//4.Пользователь вводит число. Выведите на экран число, которое больше введенного
//на 10.
StartTask(4);
Console.WriteLine("Напишите пожалуйста число");
string fourthTaskstr = Console.ReadLine();
double fourthTaskdouble;
if (double.TryParse(fourthTaskstr, out fourthTaskdouble))
    Console.WriteLine(fourthTaskdouble + 10);
else
    Console.WriteLine("Извините, вы указали некорректное число");


//5.Дана сторона квадрата. Найти его периметр.
StartTask(5);
Console.WriteLine("Введите пожалуйста сторону квадрата");
double fifthDouble;
string fifthString = Console.ReadLine();
if (double.TryParse(fifthString, out fifthDouble))
    Console.WriteLine(fifthDouble * 4);
else
    Console.WriteLine("Извините, вы указали некорректное число");

//6.Дан радиус окружности. Найти длину окружности и площадь круга.
StartTask(6);
Console.WriteLine("Напишите пожалуйста радиус окружности");
double sixthDouble;
string sixthString = Console.ReadLine();
if (double.TryParse(sixthString, out sixthDouble))
    Console.WriteLine("Длина окружности:{0}\nПлощадь круга:{1}", sixthDouble * 2 * Math.PI, sixthDouble * sixthDouble * Math.PI);
else
    Console.WriteLine("Извините, вы указали некорректное число");

//7. Найти значение y=cos(x)
StartTask(7);
Console.WriteLine("Напишите пожалуйста значение x");
double n7Double;
string n7String = Console.ReadLine();
if (double.TryParse(n7String, out n7Double))
    Console.WriteLine(Math.Cos(n7Double));
else
    Console.WriteLine("Извините, вы указали некорректное число");

//8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
StartTask(8);
Console.WriteLine("Введите пожалуйста значения оснований и высоты равнобедренной трапеции\nв соответственном порядке");
double n8Doublebase1, n8Doubleheight, n8Doublebase2;
string n8Stringbase1 = Console.ReadLine(), n8Stringbase2 = Console.ReadLine(), n8Stringheight = Console.ReadLine();
if (double.TryParse(n8Stringbase1, out n8Doublebase1) && double.TryParse(n8Stringheight, out n8Doubleheight)
    && double.TryParse(n8Stringbase2,out n8Doublebase2))
{
    Console.WriteLine("Периметр равен {0}", Math.Sqrt(Math.Abs(n8Doublebase2 - n8Doublebase1) * Math.Abs(n8Doublebase2 - n8Doublebase1) / 4
        + n8Doubleheight * n8Doubleheight) * 2 + n8Doublebase1 + n8Doublebase2);
}
else
    Console.WriteLine("Извините, вы указали некорректное число");


//9.Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
//если купили x кг конфет, у кг печенья и z кг яблок.
Console.WriteLine("Введите пожалуйста стоимость 1 кг конфет, печенья и яблок, а также значение x,y,z");
double n9Dcnd, n9Dcke, n9Dapp, n9Dx, n9Dy, n9Dz;
string n9Scnd = Console.ReadLine(), n9Scke = Console.ReadLine(), n9Sapp = Console.ReadLine(), n9Sx = Console.ReadLine(), n9Sy = Console.ReadLine(), n9Sz = Console.ReadLine();
if (double.TryParse(n9Scnd, out n9Dcnd) && double.TryParse(n9Scke, out n9Dcke) && double.TryParse(n9Sapp, out n9Dapp)
    && double.TryParse(n9Sx, out n9Dx) && double.TryParse(n9Sy, out n9Dy) && double.TryParse(n9Sz, out n9Dz))
    Console.WriteLine("Стоимость всей покупки: {0}", n9Dcnd * n9Dx + n9Dcke * n9Dy + n9Dapp * n9Dz);
else
    Console.WriteLine("Извините, вы указали некорректное число");


//10.Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
//(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
//Мир Труд Май
//Затем так:
//Мир
//Труд
//Май
StartTask(10);
string Peace = "Мир", Labor = "Труд", May = "Май";
Console.WriteLine("{0} {1} {2}", Peace, Labor, May);
Console.WriteLine(Peace.PadRight(20));
Console.WriteLine(Labor.PadLeft(10));
Console.WriteLine(May.PadLeft(20));


//11.Программа просит пользователя ввести 2 числовые переменные. А после она
//меняет их местами и выводит результат на экран. Но, так как пользователь может
//ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
//например, букву или строку, а так же учесть, что число может быть дробным, и для
//выделения её дробной части одни используют точку, другие – запятую.
Console.WriteLine("Пожалуйста введите две числовые переменные в формате \"Название_Переменной=Десятичная_дробь\"");
string n11Firstoutput = Console.ReadLine();
string n11Secondoutput = Console.ReadLine();
string n11Firstdes = null, n11Firstvar = null;
string n11Seconddes = null, n11Secondvar = null;
int firstIndex = 0;
while (n11Firstoutput[firstIndex] != '=')
{
    n11Firstdes += n11Firstoutput[firstIndex];
    firstIndex++;
}
firstIndex++;
while (firstIndex != n11Firstoutput.Length)
{
    n11Firstvar += n11Firstoutput[firstIndex];
    firstIndex++;
}
int secondIndex = 0;
while (n11Secondoutput[secondIndex] != '=')
{
    n11Seconddes += n11Secondoutput[secondIndex];
    secondIndex++;
}
secondIndex++;
while (secondIndex != n11Secondoutput.Length)
{
    n11Secondvar += n11Secondoutput[secondIndex];
    secondIndex++;
}
Console.WriteLine("{0}={1}", n11Seconddes, n11Firstvar);
Console.WriteLine("{0}={1}", n11Firstdes, n11Secondvar);


//12.Программа для подсчета периметра и площади фигур (треугольник,
//четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
//будет считать – площадь или периметр. Задаётся все необходимые значения, а на
//основе полученных результатов, программа должна подсчитать, какими могли бы
//быть периметры или площади остальных фигур.
StartTask(12);
Console.WriteLine("Пожалуйства выберите фигуру (треугольник,четырехугольник, круг)");
string shapeVar = Console.ReadLine();
Console.WriteLine("Пожалуйства выберите что измерить (площадь, периметр)");
Console.WriteLine("Пожалуйста укажите значение сторон/радиуса. Если\n информации меньше чем должно быть, сначала введите известную информацию\nзатем нажимайте ENTER");
Console.WriteLine("Если четырехугольник не вписанный и нужна площадь, то стороны должны быть указаны по порядку смежности");
string choiseVar = Console.ReadLine();
if ((choiseVar == "площадь" || choiseVar == "периметр") && (shapeVar == "треугольник" || shapeVar == "четырехугольник" || shapeVar == "круг"))
{
    double shapeDouble1, shapeDouble2, shapeDouble3, shapeDouble4;
    if (shapeVar == "треугольник")
    {
        string triangleString1, triangleString2, triangleString3;
        triangleString1 = Console.ReadLine();
        triangleString2 = Console.ReadLine();
        if (string.IsNullOrEmpty(triangleString2))
        {
            if (double.TryParse(triangleString1, out shapeDouble1))
            {
                if (choiseVar == "площадь")
                    Console.WriteLine("Возможная площадь:{0}", shapeDouble1 * shapeDouble1 / 2);
                else
                    Console.WriteLine("Возможный периметр:{0}", shapeDouble1 * 3);
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }
        else
        {
            triangleString3 = Console.ReadLine();
            if (string.IsNullOrEmpty(triangleString3))
            {
                if (double.TryParse(triangleString1, out shapeDouble1) && double.TryParse(triangleString2, out shapeDouble2))
                {
                    if (choiseVar == "площадь")
                        Console.WriteLine("Возможная площадь:{0}", shapeDouble1 * shapeDouble2 / 2);
                    else
                        Console.WriteLine("Возможный периметр:{0}", shapeDouble1 + shapeDouble2 + Math.Sqrt(shapeDouble1 * shapeDouble1 + shapeDouble2 * shapeDouble2));
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так");
                }

            }
            else
            {
                if (double.TryParse(triangleString1, out shapeDouble1) && double.TryParse(triangleString2, out shapeDouble2)
                    && double.TryParse(triangleString3, out shapeDouble3))
                {
                    if (choiseVar == "площадь")
                    {
                        double semiPer = (shapeDouble1 + shapeDouble2 + shapeDouble3) / 2;
                        Console.WriteLine("Возможная площадь:{0}", Math.Sqrt(semiPer * (semiPer - shapeDouble1) * (semiPer - shapeDouble2) * (semiPer - shapeDouble3)));
                    }
                    else
                        Console.WriteLine("Возможный периметр:{0}", shapeDouble1 + shapeDouble2 + shapeDouble3);
                }
                else
                    Console.WriteLine("Что-то пошло не так");
            }
        }
    }
    else if (shapeVar == "круг")
    {
        Console.WriteLine("Укажите радиус");
        string radiusString;
        radiusString = Console.ReadLine();
        if (double.TryParse(radiusString, out shapeDouble1))
        {
            if (choiseVar == "площадь")
                Console.WriteLine("Возможная площадь:{0}", Math.PI * shapeDouble1 * shapeDouble1);
            else
                Console.WriteLine("Возможный периметр:{0}", 2 * Math.PI * shapeDouble1);
        }
        else
        {
            Console.WriteLine("Что-то пошло не так");
        }
    }
    else
    {
        string tetraString1, tetraString2, tetraString3, tetraString4;
        tetraString1 = Console.ReadLine();
        tetraString2 = Console.ReadLine();
        if (string.IsNullOrEmpty(tetraString2))
        {
            if (double.TryParse(tetraString1, out shapeDouble1))
            {
                if (choiseVar == "площадь")
                    Console.WriteLine("Возможная площадь:{0}", shapeDouble1 * shapeDouble1);
                else
                    Console.WriteLine("Возможный периметр:{0}", shapeDouble1 * 4);
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }
        else
        {
            tetraString3 = Console.ReadLine();
            if (string.IsNullOrEmpty(tetraString3))
            {
                if (double.TryParse(tetraString1, out shapeDouble1) && double.TryParse(tetraString2, out shapeDouble2))
                {
                    if (choiseVar == "площадь")
                        Console.WriteLine("Возможная площадь:{0}", shapeDouble1 * shapeDouble2);
                    else
                        Console.WriteLine("Возможный периметр:{0}", shapeDouble1 * 2 + shapeDouble2 * 2);
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так");
                }
            }
            else
            {
                tetraString4 = Console.ReadLine();
                if (string.IsNullOrEmpty(tetraString4))
                {
                    if (double.TryParse(tetraString1, out shapeDouble1) && double.TryParse(tetraString2, out shapeDouble2)
                   && double.TryParse(tetraString3, out shapeDouble3))
                    {
                        double[] tetraThr = new double[] { shapeDouble1, shapeDouble2, shapeDouble3 };
                        Array.Sort(tetraThr);
                        if (choiseVar == "площадь")
                        {
                            Console.WriteLine("Возможная площадь:{0}", (tetraThr[2] - tetraThr[1]) * tetraThr[0] / 2 + tetraThr[0] * tetraThr[1]);
                        }
                        else
                            Console.WriteLine("Возможный периметр:{0}", tetraThr[1] + tetraThr[2] + tetraThr[0] +
                                Math.Sqrt((tetraThr[2] - tetraThr[1]) * (tetraThr[2] - tetraThr[1]) + tetraThr[0] * tetraThr[0]));
                    }

                }
                else
                {
                    if (double.TryParse(tetraString1, out shapeDouble1) && double.TryParse(tetraString2, out shapeDouble2)
                        && double.TryParse(tetraString3, out shapeDouble3) && double.TryParse(tetraString4, out shapeDouble4))
                    {
                        if (choiseVar == "площадь")
                        {
                            Console.WriteLine("Укажите это вписанный четырехугольник? (Y/n)");
                            string isIns = Console.ReadLine();
                            if (isIns == "Y")
                            {
                                double semiPer = (shapeDouble1 + shapeDouble2 + shapeDouble3 + shapeDouble4) / 2;
                                Console.WriteLine("Возможная площадь:{0}", Math.Sqrt((semiPer - shapeDouble4) * (semiPer - shapeDouble1) * (semiPer - shapeDouble2) *
                                    (semiPer - shapeDouble3)));
                            }
                            else
                            {
                                Console.WriteLine("Укажите длины диагоналей");
                                string firstDiastring = Console.ReadLine(), secondDiastring = Console.ReadLine();
                                double firstDiadouble, secondDiadouble;
                                if (double.TryParse(firstDiastring, out firstDiadouble) && double.TryParse(secondDiastring, out secondDiadouble))
                                {
                                    double semiPer = (shapeDouble1 + shapeDouble2 + shapeDouble3 + shapeDouble4) / 2;
                                    Console.WriteLine("Возможная площадь:{0}", Math.Sqrt((semiPer - shapeDouble4) * (semiPer - shapeDouble1) * (semiPer - shapeDouble2) *
                                    (semiPer - shapeDouble3) - 0.25 * (shapeDouble1 * shapeDouble3 + shapeDouble2 * shapeDouble4 - firstDiadouble * secondDiadouble)
                                    * (shapeDouble1 * shapeDouble3 + shapeDouble2 * shapeDouble4 + firstDiadouble * secondDiadouble)));
                                }
                                else
                                {
                                    Console.WriteLine("Что-то пошло не так");
                                }
                            }
                        }
                        else
                            Console.WriteLine(shapeDouble1 + shapeDouble2 + shapeDouble3 + shapeDouble4);
                    }
                    else
                    {
                        Console.WriteLine("Что-то пошло не так");
                    }
                }
            }
        }
    }
}
else
    Console.WriteLine("Что-то пошло не так");

//13.Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
//числу должно предшествовать сообщение «Вы ввели число».
StartTask(13);
Console.WriteLine("Введите число");
string n13Str = Console.ReadLine();
double n13Dbl;
if (double.TryParse(n13Str, out n13Dbl))
    Console.WriteLine("Вы ввели число {0}", n13Dbl);
else
    Console.WriteLine("Что-то пошло не так");

//14.Составить программу вывода на экран следующей информации:
//2 кг
//13 17
StartTask(14);
Console.WriteLine("2 кг\n13 17");


//15.Составить программу вывода на экран «столбиком» четырех случайных чисел.
StartTask(15);

Random n15Rand = new Random();


double n15RandDouble()
{
    return n15Rand.Next(1000) + n15Rand.NextDouble();
}

double n15Dbl1 = Math.Round(n15RandDouble(), 7), n15Dbl2 = Math.Round(n15RandDouble(), 7),
    n15Dbl3 = Math.Round(n15RandDouble(), 7), n15Dbl4 = Math.Round(n15RandDouble(), 7);
Console.WriteLine("{0} {1}", n15Dbl1.ToString().PadLeft(15), n15Dbl2.ToString().PadLeft(15));
Console.WriteLine("{0} {1}", n15Dbl3.ToString().PadLeft(15), n15Dbl4.ToString().PadLeft(15));


//16.Найти корни квадратного уравнения(коэффициента задаются пользователем с
//клавиатуры)
StartTask(16);
Console.WriteLine("Пожалуйста укажите коэффициенты уравнения");
double aCoef, bCoef, cCoef;
string aValue = Console.ReadLine(), bValue = Console.ReadLine(), cValue = Console.ReadLine();


if (double.TryParse(aValue, out aCoef) && double.TryParse(bValue, out bCoef) && double.TryParse(cValue, out cCoef))
{
    double dCoef = bCoef * bCoef - 4 * cCoef * aCoef;
    if (aCoef == 0)
    {
        Console.WriteLine("Извините, это не квадратное уравнение");
    }
    else if (dCoef == 0)
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


//17.Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
//геометрическое.
StartTask(17);
Console.WriteLine("Укажите два целых числа");
double n17Dbl1, n17Dbl2;
string n17Str1 = Console.ReadLine(), n17Str2 = Console.ReadLine();
if (double.TryParse(n17Str1, out n17Dbl1) && double.TryParse(n17Str2, out n17Dbl2))
    Console.WriteLine("Среднее арифметическое:{0}\nСреднее геометрическое:{1}",
        (n17Dbl1 + n17Dbl2) / 2, Math.Sqrt(n17Dbl1 * n17Dbl2));


//18.Известны координаты на плоскости двух точек. Составить программу вычисления
//расстояния между ними.
StartTask(18);
Console.WriteLine("Укажите координаты двух точек на плоскости в порядке:x1,x2,y1,y2");
double n18X1, n18X2, n18Y1, n18Y2;
string n18Strx1 = Console.ReadLine(), n18Strx2 = Console.ReadLine(),
    n18Stry1 = Console.ReadLine(), n18Stry2 = Console.ReadLine();
if (double.TryParse(n18Strx1, out n18X1) && double.TryParse(n18Strx2, out n18X2)
    && double.TryParse(n18Stry1, out n18Y1) && double.TryParse(n18Stry2, out n18Y2))
    Console.WriteLine("Расстояние между точками:{0}",
        Math.Sqrt(Math.Pow(Math.Abs(n18Y2 - n18Y1), 2) + Math.Pow(Math.Abs(n18X2 - n18X1), 2)));
else
    Console.WriteLine("Что-то пошло не так");


//19.Составить программу обмена значениями трех переменных величин а, b, c по
//следующим двум схемам:
//а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
//б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
StartTask(19);
Console.WriteLine("Укажите числовые значения a, b, c");
string n19Stra = Console.ReadLine(), n19Strb = Console.ReadLine(), n19Strc = Console.ReadLine();
double n19Dbla, n19Dblb, n19Dblc;
if (double.TryParse(n19Stra, out n19Dbla) && double.TryParse(n19Strb, out n19Dblb)
    && double.TryParse(n19Strc, out n19Dblc))
{
    //a=a b=b c=c
    (n19Dblb, n19Dblc) = (n19Dblc, n19Dblb);
    //a=a b=c c=b
    (n19Dblc, n19Dbla) = (n19Dbla, n19Dblc);
    //a=b b=c c=a
    Console.WriteLine("a) a = {0}, b = {1}, c = {2}", n19Dbla, n19Dblb, n19Dblc);
    //a=b b=c c=a
    (n19Dblc, n19Dblb) = (n19Dblb, n19Dblc);
    //a=b b=a c=c
    (n19Dbla, n19Dblc) = (n19Dblc, n19Dbla);
    //a=c b=a c=b
    Console.WriteLine("б) a = {0}, b = {1}, c = {2}", n19Dbla, n19Dblb, n19Dblc);
}
else
    Console.WriteLine("Что-то пошло не так");


//20.С начала суток прошло n секунд. Определить:
//а) сколько полных часов прошло с начала суток;
//б) сколько полных минут прошло с начала очередного часа;
//в) сколько полных секунд прошло с начала очередной минуты.
StartTask(20);
int n20pastSec;
string n20Output = Console.ReadLine();
if (int.TryParse(n20Output, out n20pastSec))
    Console.WriteLine("a) {0}\nб) {1}\nв) {2}", n20pastSec / 60 / 60, n20pastSec / 60 % 60, n20pastSec % 60);

//21.Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
//мм можно отрезать от него?
int n21width = 543, n21ans = 0;
while (n21width >= 130)
{
    n21ans++;
    n21width -= 130;
}
Console.WriteLine(n21ans);


//22.Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
//ее в начале. Найти полученное число.
StartTask(22);
Console.WriteLine("Укажите трехзначное число");
string n22Var = Console.ReadLine();
Console.WriteLine("{0}{1}{2}", n22Var[2], n22Var[0], n22Var[1]);


//23.Дано натуральное число n (n > 999). Найти:
//а) число сотен в нем;
//б) число тысяч в нем.
Console.WriteLine("Укажите натуральное число большее чем 999");
string n23Str = Console.ReadLine();
int n23Int;
if (int.TryParse(n23Str, out n23Int) && n23Int > 999)
{
    Console.WriteLine("a){0}\nб){1}", n23Int % 1000 / 100, n23Int / 1000 % 1000);
}
else
{
    Console.WriteLine("Что-то пошло не так");
}


//24.Дано четырехзначное число. Найти:
//а) число, полученное при прочтении его цифр справа налево;
//б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
//заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
//в) число, образуемое при перестановке второй и третьей цифр заданного числа.
//Например, из числа 5084 получить 5804;
//г) число, образуемое при перестановке двух первых и двух последних цифр
//заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.
StartTask(24);
Console.WriteLine("Укажите четырехзначное число");
string n24Var = Console.ReadLine();
if (n24Var.Length >= 4)
{
    char[] n24Vara = { n24Var[3], n24Var[2], n24Var[1], n24Var[0] };
    int n24Inta, n24Intb, n24Intc, n24Intd;
    if (int.TryParse(n24Vara, out n24Inta))
    {
        Console.WriteLine("a){0}", n24Inta);
        char[] n24Varb = { n24Var[1], n24Var[0], n24Var[3], n24Var[2] };
        int.TryParse(n24Varb, out n24Intb);
        Console.WriteLine("б){0}", n24Intb);
        char[] n24Varс = { n24Var[0], n24Var[2], n24Var[1], n24Var[3] };
        int.TryParse(n24Varс, out n24Intc);
        Console.WriteLine("в){0}", n24Intc);
        char[] n24Vard = { n24Var[2], n24Var[3], n24Var[0], n24Var[1] };
        int.TryParse(n24Vard, out n24Intd);
        Console.WriteLine("г){0}", n24Intd);
    }
    else
    {
        Console.WriteLine("Что-то пошло не так");
    }
}
else
    Console.WriteLine("Что-то пошло не так");


//25.Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили
//на 10, а к частному слева приписали последнюю цифру числа x, то получилось
//число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
//число десятков в n не равно нулю
StartTask(25);
int n25Int;
string n25Str = Console.ReadLine();
if (int.TryParse(n25Str, out n25Int))
    Console.WriteLine("{0}", n25Int / 100 + n25Int % 100 * 10);
else
    Console.WriteLine("Что-то пошло не так.");


//26.Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
//времени: «h часов, m минут, s секунд». Определить угол (в градусах) между
//положением часовой стрелки в начале суток и в указанный момент времени
StartTask(26);
string n26Strh = Console.ReadLine(), n26Strm = Console.ReadLine(), n26Strs = Console.ReadLine();
double n26Dh, n26Dm, n26Ds;
if (double.TryParse(n26Strh, out n26Dh) && double.TryParse(n26Strm, out n26Dm)
    && double.TryParse(n26Strs, out n26Ds))
    Console.WriteLine(Math.Min(360.0 - 360.0 / 12 * n26Dh - 360.0 / 12 / 60 * n26Dm - 360.0 / 12 / 3600 * n26Ds,
        360.0 / 12 * n26Dh + 360.0 / 12 / 60 * n26Dm + 360.0 / 12 / 3600 * n26Ds));
else
    Console.WriteLine("Что-то пошло не так");


//27.Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
//соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2 . Определить значение угла для
//минутной стрелки, а также количество полных часов и полных минут
StartTask(27);
string n27Stry = Console.ReadLine();
double n27Dbly;
if (double.TryParse(n27Stry, out n27Dbly) && n27Dbly <= 2.0 && n27Dbly >= 0.0)
    Console.WriteLine("Угол минутной стрелки:{0}\nПолных часов:{1}\nПолных минут:{2}"
        , 2.0 / 60 * ((n27Dbly % (2.0 / 12)) / (2.0 / 12 / 60)), (int)(n27Dbly / (2.0 / 12)), (int)((n27Dbly % (2.0 / 12)) / (2.0 / 12 / 60)));
else
    Console.WriteLine("Что-то пошло не так");


//28.Создать программу, которая будет выводить на экран меньшее по модулю из трёх
//введённых пользователем вещественных чисел
StartTask(28);
Console.WriteLine("Введите три вещественных числа");
string n28Str1 = Console.ReadLine(), n28Str2 = Console.ReadLine(), n28Str3 = Console.ReadLine();
double n28Dbl1, n28Dbl2, n28Dbl3;
if (double.TryParse(n28Str1, out n28Dbl1) && double.TryParse(n28Str2, out n28Dbl2)
    && double.TryParse(n28Str3, out n28Dbl3))
{
    if (Math.Abs(n28Dbl1) <= Math.Abs(n28Dbl2) && Math.Abs(n28Dbl1) <= Math.Abs(n28Dbl3))
        Console.WriteLine(n28Dbl1);
    else if (Math.Abs(n28Dbl2) <= Math.Abs(n28Dbl1) && Math.Abs(n28Dbl2) <= Math.Abs(n28Dbl3))
        Console.WriteLine(n28Dbl2);
    else
        Console.WriteLine(n28Dbl3);
}
else
    Console.WriteLine("Что-то пошло не так");


//29.Найти сумму большего и меньшего из трёх заданных чисел
StartTask(29);
Console.WriteLine("Введите три вещественных числа");
string n29Str1 = Console.ReadLine(), n29Str2 = Console.ReadLine(), n29Str3 = Console.ReadLine();
double n29Dbl1, n29Dbl2, n29Dbl3;
if (double.TryParse(n29Str1, out n29Dbl1) && double.TryParse(n29Str2, out n29Dbl2)
    && double.TryParse(n29Str3, out n29Dbl3))
{
    if (n29Dbl1 <= n29Dbl2 && n29Dbl1 <= n29Dbl3)
        Console.WriteLine(n29Dbl1 + Math.Max(n29Dbl2, n29Dbl3));
    else if (n29Dbl2 <= n29Dbl1 && n29Dbl2 <= n29Dbl3)
        Console.WriteLine(n29Dbl2 + Math.Max(n29Dbl1, n29Dbl3));
    else
        Console.WriteLine(n29Dbl3 + Math.Max(n29Dbl2, n29Dbl1));
}
else
    Console.WriteLine("Что-то пошло не так");


//30.Подсчитать общее количество делителей натурального числа
StartTask(30);
Console.WriteLine("Введите натуральное число");
int n30Int;
string n30Str = Console.ReadLine();
if (int.TryParse(n30Str, out n30Int))
{
    if (n30Int == 1)
        Console.WriteLine(1);
    else
    {
        int n30Div = 2, n30Count = 2;
        while (n30Div * n30Div < n30Int)
        {
            if (n30Int % n30Div == 0)
                n30Count += 2;
            n30Div++;
        }
        if (n30Div * n30Div == n30Int)
            n30Count++;
        Console.WriteLine(n30Count);
    }
}
else
    Console.WriteLine("Что-то пошло не так");


//31. Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
//вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
//уравнений вида A*X3 + B*X2 + C*X + D = 0. На факультативе по математике Васе
//задали решить около ста уравнений как раз такого вида. Но, к сожалению, Вася
//забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
//корни уравнений – целые числа и находятся на отрезке [-100, 100]. Поэтому у Васи
//есть шанс найти их методом перебора, но для этого ему придется затратить уйму
//времени, т.к. возможно необходимо будет осуществить перебор нескольких тысяч
//значений. Помогите Васе написать программу, которая поможет ему найти корни
//кубических уравнений!
StartTask(31);
Console.WriteLine("Укажите целые коэффиценты a,b,c,d");
string n31Stra = Console.ReadLine(), n31Strb = Console.ReadLine(),
    n31Strc = Console.ReadLine(), n31Strd = Console.ReadLine();


bool n31CheckNum(int x, int a, int b, int c, int d)
{
    return x * x * x * a + b * x * x + c * x + d == 0;
}


int n31Inta, n31Intb, n31Intc, n31Intd;
if (int.TryParse(n31Stra, out n31Inta) && int.TryParse(n31Strb, out n31Intb)
    && int.TryParse(n31Strc, out n31Intc) && int.TryParse(n31Strd, out n31Intd))
{
    bool anyRoot = false;
    int n31Intx = -100;
    while (n31Intx <= 100)
    {
        if (n31CheckNum(n31Intx, n31Inta, n31Intb, n31Intc, n31Intd))
        {
            anyRoot = true;
            Console.WriteLine(n31Intx);
        }
        n31Intx++;
    }
    if (!anyRoot)
        Console.WriteLine("Нет целых корней на данном отрезке");
}
else
    Console.WriteLine("Что-то пошло не так");


//32.Заданы первый и второй элементы арифметической прогрессии. Требуется
//написать программу, которая вычислит элемент прогрессии по ее номеру.
StartTask(32);
Console.WriteLine("Укажите первой, второй элементы арифметической прогресс,\n а также номер элемента");
double n32First, n32Second, n32Num;
if (double.TryParse(Console.ReadLine(), out n32First) &&
    double.TryParse(Console.ReadLine(), out n32Second) &&
    double.TryParse(Console.ReadLine(), out n32Num))
    Console.WriteLine(n32First + (n32Num - 1) * (n32Second - n32First));
else
    Console.WriteLine("Что-то пошло не так");


//33.Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
//трудоустроен не получаю кредит. Ну а если я, и пенсионер и
//студент,(трудоустройство тут не имеет значения) то не должен получить.
//Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
//или кто-то ещё. Вывести информацию: дадут кредит или нет.
StartTask(33);
Console.WriteLine("Пенсионер?(Y/n)");
string n33Ispen = Console.ReadLine();
Console.WriteLine("Студент?(Y/n)");
string n33Isstud = Console.ReadLine();
Console.WriteLine("Трудоустроен?(Y/n)");
string n33Isemp = Console.ReadLine();
if (n33Ispen == "Y" || n33Isstud == "Y" && n33Isemp != "Y")
{
    Console.WriteLine("Получаете кредит");
}
else
{
    Console.WriteLine("Не получаете кредит");
}


//34.Составить программу, которая:
//а) запрашивает имя человека и повторяет его на экране;
//б) запрашивает имя человека и повторяет его на экране с приветствием.
StartTask(34);
Console.WriteLine("а)Как вас зовут");
Console.WriteLine(Console.ReadLine());
Console.WriteLine("b)Как вас зовут");
Console.WriteLine("Hello, {0}", Console.ReadLine());


//35.Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с
//консолью. Консоль спрашивает, как зовут пользователя. Пользователь называет
//имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь
//спрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да».
//После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
//«Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
//цвет на любой случайный цвет.
StartTask(35);
Console.ReadLine();
Console.WriteLine("Как тебя зовут?");
string n35Name = Console.ReadLine();
Console.WriteLine($"Привет, {n35Name}");
Console.ReadLine();
Console.WriteLine("Да");
Console.ReadLine();
Console.WriteLine("Нет");
Thread.Sleep(5000);
Console.WriteLine("Но могу показать");
Console.BackgroundColor = ConsoleColor.Red;


//36.Вычислить контрольную цифру штрихкода(EAN13).
//a. 12 цифр определяются случайным образом.
//b. 12 цифр вводит пользователь
Random n36Rand = new Random();
StartTask(36);
Console.Write("a. ");
int[] intArrrand = new int[12];
for (int i = 0; i < 12; i++)
{
    intArrrand[i] = n36Rand.Next(10);
    Console.Write(intArrrand[i]);
}
Console.Write(" ");
int justSumrand = 0;
for (int i = 0; i < 12; i++)
{
    if ((i + 1) % 2 == 0)
    {
        justSumrand += intArrrand[i] * 3;
    }
}
for (int i = 0; i < 12; i++)
{
    if ((i + 1) % 2 == 1)
    {
        justSumrand += intArrrand[i];
    }
}
Console.WriteLine((10 - justSumrand % 10) % 10);
Console.Write("b. ");
bool isMis = false;
int[] intArrgen = new int[12];
string genVar = Console.ReadLine();
for (int i = 0; i < 12; i++)
{
    if ((int)genVar[i] <= 57 && (int)genVar[i] >= 48)
        intArrgen[i] = (int)genVar[i] - 48;
}
int justSumgen = 0;
for (int i = 0; i < 12; i++)
{
    if ((i + 1) % 2 == 0)
        justSumgen += intArrgen[i] * 3;
}
for (int i = 0; i < 12; i++)
{
    if ((i + 1) % 2 == 1)
        justSumgen += intArrgen[i];
}
Console.WriteLine((10 - justSumgen % 10) % 10);