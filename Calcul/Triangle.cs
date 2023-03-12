using System;

namespace AreaCalcLib
{
    internal class Triangle : Figura
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        protected override double GetPlace()
        {
            Perimetr = (A + B + C) / 2;


            Resultat = Math.Sqrt(Perimetr * (Perimetr - A) * (Perimetr - B) * (Perimetr - C));
            return Resultat;

        }

        public override void InputValue()
        {
            Console.WriteLine("Введите первую сторону");
            A = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введите вторую сторону");
            B = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Ввведите третью сторону");
            C = Convert.ToDouble(Console.ReadLine());

            if ((A * A) == (B * B) + (C * C)) Console.WriteLine($"Площадь прямоугольного треугольника: {GetPlace()}");
            if ((B * B) == (C * C) + (A * A)) Console.WriteLine($"Площадь прямоугольного треугольника: {GetPlace()}");
            if ((C * C) == (B * B) + (A * A)) Console.WriteLine($"Площадь прямоугольного треугольника: {GetPlace()}");

            else Console.WriteLine($"Площадь треугольника: {GetPlace()}");
        }





    }
}
