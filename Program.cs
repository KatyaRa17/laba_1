using System;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        Console.Write("Введите номер задания: Методы(1), Условия(2), Циклы(3), Массивы(4): ");
    Input: //метка идентификатора, каждый раз, при ошибке, будем сюда возвращаться
        int num = Convert.ToInt32(Console.ReadLine());
        if ((num > 4) || (num <= 0))
        {
            Console.WriteLine("Такого номера задания не существует");
            Console.Write("Попробуйте ввести другое значение: ");
            goto Input;
        }
        else
        {
            switch (num)
            {
                case 1:
                    Console.Write("Введите номер задания 2, 4, 6, 8, 10: ");
                Vvod:
                    int n = Convert.ToInt32(Console.ReadLine());
                    if ((n < 10) && (n % 2 != 0))
                    {
                        Console.WriteLine("Такого номера задания не существует");
                        Console.Write("Попробуйте ввести другое значение: ");
                        goto Vvod;
                    }
                    else
                    {
                        switch (n)
                        {
                            case 2:
                                Console.Write("Введите значение х: ");
                                int x = Convert.ToInt32(Console.ReadLine());
                                int A = program.sumLastNums(x);
                                Console.Write(A);
                                return;
                            case 4:
                                Console.Write("Введите значение х: ");
                                int y = Convert.ToInt32(Console.ReadLine());
                                if (y == 0)
                                {
                                    Console.Write("x == 0 не является положительным или отицательным ");
                                    return;
                                }
                                else
                                {
                                    bool B = program.isPositive(y);
                                    Console.Write(B);
                                    return;
                                }
                            case 6:
                            Char:
                                Console.WriteLine("Введите значение х: ");
                                char sim = Console.ReadKey().KeyChar;
                                if (Char.IsLetter(sim))
                                {
                                    bool c = program.isUpperCase(sim);
                                    Console.WriteLine(" " + c);
                                    return;
                                }
                                else 
                                {
                                    Console.WriteLine(" Введена не буква. ");
                                    goto Char;
                                }
                            case 8:
                                Console.Write("Введите значение A и В: ");
                                int a = Convert.ToInt32(Console.ReadLine());
                                int b = Convert.ToInt32(Console.ReadLine());
                                bool t_f = program.isDivisor(a, b);
                                Console.Write(t_f);
                                return;
                            case 10:
                                Console.Write("Введите значение A и В: ");
                                int a1 = Convert.ToInt32(Console.ReadLine());
                                if (a1 <  0) a1 = Math.Abs(a1);
                                for (int i = 1; i < 5; i++)
                                {
                                    Console.Write("Введите следующее число (B): "); 
                                    int b1 = Convert.ToInt32(Console.ReadLine());
                                    if (b1 < 0) b1 = Math.Abs(b1);
                                    int sum = program.lastNumSum(a1, b1);
                                    Console.Write(sum);
                                    a1 = sum;
                                }
                                return;
                            default:
                                return;
                        }
                    }
                case 2:
                    Console.WriteLine("Введите номер задания 2, 4, 6, 8, 10: ");
                noun:
                    int n_2 = Convert.ToInt32(Console.ReadLine());
                    if ((n_2 < 10) && (n_2 % 2 != 0))
                    {
                        Console.WriteLine("Такого номера задания не существует");
                        Console.Write("Попробуйте ввести другое значение: ");
                        goto noun;
                    }
                    else
                    {
                        switch (n_2)
                        {
                            case 2:
                                Console.Write("Введите значение x и y: ");
                                int a2 = Convert.ToInt32(Console.ReadLine());
                                int b2 = Convert.ToInt32(Console.ReadLine());
                                double d = program.safeDiv(a2, b2);
                                Console.Write(d);
                                return;
                            case 4:
                                Console.Write("Введите значение x и y: ");
                                int a3 = Convert.ToInt32(Console.ReadLine());
                                int b3 = Convert.ToInt32(Console.ReadLine());
                                string s = program.makeDecision(a3, b3);
                                Console.Write(s);
                                return;
                            case 6:
                                Console.Write("Введите значение x, y и z: ");
                                int x1 = Convert.ToInt32(Console.ReadLine());
                                int y1 = Convert.ToInt32(Console.ReadLine());
                                int z1 = Convert.ToInt32(Console.ReadLine());
                                bool chis = program.sum3(x1, y1, z1);
                                Console.Write(chis);
                                return;
                            case 8:
                                Console.Write("Введите значение x: ");
                                int x2 = Convert.ToInt32(Console.ReadLine());
                                string a1 = program.age(x2);
                                Console.Write(x2 + a1);
                                return;
                            case 10:
                                Console.Write("Введите день недели: ");
                                string day = Console.ReadLine();
                                program.printDays(day);
                                return;
                            default:
                                return;
                        }
                    }
                case 3:
                    Console.WriteLine("Введите номер задания 1, 2, 4, 6, 8, 10: ");
                nouns:
                    int n_3 = Convert.ToInt32(Console.ReadLine());
                    if ((n_3 < 10) && ((n_3 % 2 != 0) && (n_3 != 1)))
                    {
                        Console.WriteLine("Такого номера задания не существует");
                        Console.Write("Попробуйте ввести другое значение: ");
                        goto nouns;
                    }
                    else
                    {
                        switch (n_3)
                        {
                            case 1:
                                Console.Write("Введите значение x: ");
                                int x = Convert.ToInt32(Console.ReadLine());
                                string s = program.listNums(x);
                                Console.Write(s);
                                return;
                            case 2:
                                Console.Write("Введите значение x: ");
                            str:
                                int x_n = Convert.ToInt32(Console.ReadLine());
                                if (x_n < 0)
                                {
                                    Console.WriteLine("Введено отрицательное значение x. Введите х >= 0 ");
                                    goto str;
                                }
                                string s_n = program.reverseListNums(x_n);
                                Console.Write(s_n);
                                return;
                            case 4:
                                Console.Write("Введите значение x и y: ");
                                int x4 = Convert.ToInt32(Console.ReadLine());
                                int y4 = Convert.ToInt32(Console.ReadLine());
                                int pow_x = program.pow(x4, y4);
                                if (y4 >= 0) Console.Write(pow_x);
                                else Console.Write("1/" + pow_x + " = " + (double)1 / pow_x);
                                return;
                            case 6:
                                Console.Write("Введите значение x: ");
                                int ch = Convert.ToInt32(Console.ReadLine());
                                bool z = program.equalNum(ch);
                                Console.Write(z);
                                return;
                            case 8:
                            sim:
                                Console.Write("Введите количество символов в высоту: ");
                                int sim = Convert.ToInt32(Console.ReadLine());
                                if (sim <= 0)
                                {
                                    Console.WriteLine("Введено некорректное число ");
                                    goto sim;
                                }
                                program.leftTriangle(sim);
                                return;
                            case 10:
                                program.guessGame();
                                return;
                            default:
                                return;

                        }
                    }
                case 4:
                    Console.WriteLine("Введите номер задания 2, 4, 6, 8, 10: ");
                n_mass:
                    int n_mass = Convert.ToInt32(Console.ReadLine());
                    if ((n_mass < 10) && (n_mass % 2 != 0))
                    {
                        Console.WriteLine("Такого номера задания не существует");
                        Console.Write("Попробуйте ввести другое значение: ");
                        goto n_mass;
                    }
                    else
                    {
                        switch (n_mass)
                        {
                            case 2:
                                Console.Write("Введите элементы массива через пробел: ");
                                int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                                Console.Write("Введите значение x: ");
                                int x = Convert.ToInt32(Console.ReadLine());
                                int m = program.findLast(arr, x);
                                Console.Write(m);
                                return;
                            case 4:
                                Console.Write("Введите элементы массива через пробел: ");
                                int[] arr4 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                                Console.Write("Введите значение x: ");
                                int xp = Convert.ToInt32(Console.ReadLine());
                            mass_vvod:
                                Console.Write("Введите номер позицию для вставляемого элемента (х): ");
                                int pos = Convert.ToInt32(Console.ReadLine());
                                if (pos > arr4.Length || pos < 0)
                                {
                                    Console.Write("Такой позиции нет в массиве ");
                                    goto mass_vvod;
                                }
                                int[] ma = program.add(arr4, xp, pos);
                                for (int i = 0; i < ma.Length; i++) Console.Write(ma[i] + " ");
                                return;
                            case 6:
                                Console.Write("Введите элементы массива через пробел: ");
                                int[] rra = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                                program.reverse(rra);
                                return;
                            case 8:
                                Console.Write("Введите элементы первого массива через пробел: ");
                                int[] arr1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                                Console.Write("Введите элементы второго массива через пробел: ");
                                int[] arr2 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                                int[] sl = program.concat(arr1, arr2);
                                for (int i = 0; i < sl.Length; i++) Console.Write(sl[i] + " ");
                                return;
                            case 10:
                                Console.Write("Введите элементы массива через пробел: ");
                                int[] arr8 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                                int[] d = program.deleteNegative(arr8);
                                for (int i = 0; i < d.Length; i++) Console.Write(d[i] + " ");
                                return;
                            default:
                                return;
                        }
                    }
            }
   
        }

    }
    public int sumLastNums(int x)
    {
        if (x < 0) x = Math.Abs(x);
        int mod = x % 10;
        int div = (x / 10) % 10;
        x = mod + div;
        return x;
    }
    public bool isPositive(int x)
    {
        if (x < 0)  return false;
        else return true;
    }
    public bool isUpperCase(char sim)
    {
        if (char.IsUpper(sim)) return true;
        else return false;
    }
    public bool isDivisor(int a, int b)
    {
        if ((a % b == 0) || (b % a == 0)) return true;
        else return false;
    }
    public int lastNumSum(int a, int b)
    {
        int sum = 0;
        sum = a%10 + b%10;
        Console.WriteLine($"{a} + {b} = { sum}");
        return sum;
    }
    public double safeDiv(int x, int y)
    {
        if (y==0) return 0;
        else return  (double)x / y;
    }
    public String makeDecision(int x, int y)
    {
        if (x > y) return x + " > " + y;
        if (x < y) return x + " < " + y;
        else return x + " = " + y; // числа тоже возвращать
    }
    public bool sum3(int x, int y, int z)
    {
        if (x + y == z || x + z == y || y + z == x) return true;
        else return false;
    }
    public String age(int x)
    {
        if (x % 10 == 1 && x != 11) return " год";
        if (((x % 10) == 2 ^ x % 10 == 3 ^ x % 10 == 4) && (x != 12 ^ x != 13 ^ x != 14)) return " года";
        else return " лет";
    }
    public void printDays(String x)
    {
        switch(x)
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                goto case "вторник";
            case "вторник":
                Console.WriteLine("вторник");
                goto case "среда";
            case "среда":
                Console.WriteLine("среда");
                goto case "четверг";
            case "четверг":
                Console.WriteLine("четверг");
                goto case "пятница";
            case "пятница":
                Console.WriteLine("пятница");
                goto case "суббота";
            case "суббота":
                Console.WriteLine("суббота");
                goto case "воскресенье";
            case "воскресенье":
                Console.WriteLine("воскресенье");
                return;
            default:
                Console.WriteLine("Это не день недели");
                return;
        } 
    }
    public String listNums(int x)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i <= x; i++)
        {
            sb.Append(i.ToString());
            sb.Append(' ');
        }
        return sb.ToString();
    }
    public String reverseListNums(int x)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = x; i >= 0; i--)
        {
            sb.Append(i.ToString());
            sb.Append(' ');
        }
        return sb.ToString();
    }
    public int pow(int x, int y)
    {
        int p = 1;
        if (y<0)
        {
            for (int i = 1; i <= Math.Abs(y); i++)
            {
                p *= x;
            }
            return p;
        }
        if (y == 0) return 1;
        else
        {
            for (int i = 1; i <= y; i++)
            {
                p *= x;
            }
            return p;
        }
    }
    public bool equalNum(int x)
    {
        int div = 0;
        int mod = 0;
        while (x > 0)
        {
            if (div == mod)
            {
                mod = x % 10;
                x = x / 10;
                div = x % 10;
            }
            else return false;
        }
        return true;
    }
    public void leftTriangle(int x)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i<=x; i++)
        {
            sb.Append('*'.ToString());
            sb.Append(' ');
            Console.WriteLine(sb.ToString());
        }
    }
    public void guessGame()
    {
        bool t = false;
        Random rand = new Random();
        int randNum = rand.Next(0, 10);
        int n = 1;
        while (t != true)
        {
            Console.Write("Введите число от 0 до 9: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch > 9 || ch < 0)
            {
                Console.Write("Введено число выходяшее за данный предел. ");
                t = false;
            }
            else
            {
                if (ch == randNum)
                {
                    Console.WriteLine("Вы отгадали число!" + "Вы отгадали число за " + n + " попыток");
                    t = true;
                }
                else
                {
                    Console.WriteLine("Вы не угадали число!");
                    t = false;
                }
            }
            n++;
        }
    }
    public int findLast(int[] arr, int x)
    {
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                j = i;
            }
            if (j == 0) j = -1;
        }
        return j;
    }
    public int[] add(int[] arr, int x, int pos)
    {
        int[] newarr = new int[arr.Length + 1];
        for (int b = 0; b < newarr.Length; b++)
        {
            if (b < pos)
                newarr[b] = arr[b];
            else if (b == pos)
                newarr[b] = x;
            else
                newarr[b] = arr[b - 1];
        }
        return newarr;
    }
    public void reverse(int[] arr)
    {
        Array.Reverse(arr);
        Console.Write("Перевёрнутый массив: ");
        for (int i = 0; i < arr.Length; ++i)
        {
            Console.Write(arr[i] + " ");
        }
    }
    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] newarr = new int[arr1.Length + arr2.Length];
        newarr = arr1.Concat(arr2).ToArray();
        return newarr;
    }
    public int[] deleteNegative(int[] arr)
    {
        int[] mas_del = Array.FindAll(arr, (val) => val >= 0);
        return mas_del;
    }
}
