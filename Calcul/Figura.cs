namespace AreaCalcLib
{
    abstract class Figura
    {
        protected double Perimetr { get; set; }
        protected double Resultat { get; set; }
        protected abstract double GetPlace();
        public abstract void InputValue();
    }
}
