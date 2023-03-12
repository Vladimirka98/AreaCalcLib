using System;

namespace AreaCalcLib
{
    internal class Circle : Figura
    {

        double Radius { get; set; }

        protected override double GetPlace() => (Radius * Radius) * 3.14;

        public override void InputValue()
        {
            Console.WriteLine("Введите радиус");

            Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Площадь окружности равна: {GetPlace()}");



        }



    }
}
