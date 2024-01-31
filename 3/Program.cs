using System;
using System.Collections.Generic;
using static пз3.GroupFunction;

namespace пз3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Учитывайте область определения обратных гиперболических функций: ");
            Console.WriteLine($"Ареасинус (-беск;+беск)");
            Console.WriteLine($"Ареакосинус [1;беск)");
            Console.WriteLine($"Ареатангенс (-1;0) или (0;1) ");
            Console.WriteLine($"Ареакотангенс (-беск;-1) или (1;+беск)");
            Console.WriteLine($"Ареасеканс (0;1] ");
            Console.WriteLine($"Ареакосеканс (-беск;0) или (0;беск) ");
            Console.WriteLine();

            var a = new Variable("a");
            var b = new Variable("b");
            var c = new Variable("c");

            var expr0 = new Division(new Multiplication(new Constant(2), a), new Arsh(b));
            var expr1 = (2 * a) / Arsh(b);
            var expr2 = (2 * a) / Arsh(-3);

            Console.WriteLine(expr0.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = - 3 }));
            Console.WriteLine(expr1.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = - 3 }));
            Console.WriteLine(expr2.Compute(new Dictionary<string, double> { ["a"] = 5}));

            double a1, b1;
            Console.Write($"Введите первое число: ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите второе число: ");
            b1 = Convert.ToDouble(Console.ReadLine());
            Dictionary<string, double> Tasks = new Dictionary<string, double> { ["a"] = a1, ["b"] = b1 };

            Console.WriteLine();
            Console.WriteLine($"Унарные операции: ");
            Console.WriteLine($"Плюс: +{a.Compute(Tasks)} = {(new UnaryPlus(a)).Compute(Tasks)}");
            Console.WriteLine($"Минус: -{a.Compute(Tasks)} = {(new UnaryMinus(a)).Compute(Tasks)}");
            Console.WriteLine();
            Console.WriteLine($"Плюс: +{b.Compute(Tasks)} = {(new UnaryPlus(b)).Compute(Tasks)}");
            Console.WriteLine($"Минус: -{b.Compute(Tasks)} = {(new UnaryMinus(b)).Compute(Tasks)}");
            Console.WriteLine();
            Console.WriteLine($"Бинарные операции: ");
            Console.WriteLine();
            Console.WriteLine($"Сложение: {a.Compute(Tasks)} + {b.Compute(Tasks)} = {(new Addition(a, b)).Compute(Tasks)}");
            Console.WriteLine($"Вычитание: {a.Compute(Tasks)} - {b.Compute(Tasks)} = {(new Subtraction(a, b)).Compute(Tasks)}");
            Console.WriteLine($"Умножение: {a.Compute(Tasks)} * {b.Compute(Tasks)} = {(new Multiplication(a, b)).Compute(Tasks)}");
            Console.WriteLine($"Деление:{a.Compute(Tasks)} / {b.Compute(Tasks)} = {(new Division(a, b)).Compute(Tasks)}");
            Console.WriteLine($"Целая часть деления: {a.Compute(Tasks)} / {b.Compute(Tasks)} = {(int)(new Division(a, b)).Compute(Tasks)}");
            Console.WriteLine($"Остаток: {a.Compute(Tasks)} % {b.Compute(Tasks)} = {(new Remainder_of_division(a, b)).Compute(Tasks)}");
            Console.WriteLine();
            Console.WriteLine($"Обратные гиперболические операции: ");
            Console.WriteLine();
            Console.WriteLine($"ареасинус: Arsh({a.Compute(Tasks)}) = {(new Arsh(a)).Compute(Tasks)}");
            Console.WriteLine($"ареакосинус: Arch({a.Compute(Tasks)}) = {(new Arch(a)).Compute(Tasks)}");
            Console.WriteLine($"ареатангенс: Arth({a.Compute(Tasks)}) = {(new Arth(a)).Compute(Tasks)}");
            Console.WriteLine($"ареакотангенс: Arcth({a.Compute(Tasks)}) = {(new Arcth(a)).Compute(Tasks)}");
            Console.WriteLine($"ареасеканс: Arsch({a.Compute(Tasks)}) = {(new Arsch(a)).Compute(Tasks)}");
            Console.WriteLine($"ареакосеканс: Arcsch({a.Compute(Tasks)}) = {(new Arcsch(a)).Compute(Tasks)}");
            Console.WriteLine();
            Console.WriteLine($"ареасинус: Arsh({b.Compute(Tasks)}) = {(new Arsh(b)).Compute(Tasks)}");
            Console.WriteLine($"ареакосинус: Arch({b.Compute(Tasks)}) = {(new Arch(b)).Compute(Tasks)}");
            Console.WriteLine($"ареатангенс: Arth({b.Compute(Tasks)}) = {(new Arth(b)).Compute(Tasks)}");
            Console.WriteLine($"ареакотангенс: Arcth({b.Compute(Tasks)}) = {(new Arcth(b)).Compute(Tasks)}");
            Console.WriteLine($"ареасеканс: Arsch({b.Compute(Tasks)}) = {(new Arsch(b)).Compute(Tasks)}");
            Console.WriteLine($"ареакосеканс: Arcsch({b.Compute(Tasks)}) = {(new Arcsch(b)).Compute(Tasks)}");
            Console.WriteLine(new Multiplication(a.Compute(Tasks), new UnaryMinus(b.Compute(Tasks))).ToString());
            Console.WriteLine(Diff(new Arsh(new Multiplication(c, a))).ToString());
            Console.WriteLine(Diff(new Constant(2)));
            var expr5 = new Arth(a);
        }
    }
}
