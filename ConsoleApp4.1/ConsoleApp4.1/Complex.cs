namespace Complex
{
    /// <summary>
    /// Class for complex numbers
    /// </summary>
    public struct Complex
    {
        public double a;
        public double b;
        private double abs;
        private double fi;
        /// <summary>
        /// Конструктор для Complex
        /// </summary>
        /// <param name="a">вещественная часть</param>
        /// <param name="b">Мнимая часть</param>
        public Complex(double a, double b)
        {
            this.a = a; this.b = b;
            abs = Math.Sqrt(a * a + b * b);
            fi = Math.Atan2(b, a);
        }
        /// <summary>
        /// getter for abs
        /// </summary>
        public double Abs
        {
            get { return abs; }
            set { throw new ArgumentException("Cant change abs of complex number, use AbsCalculate"); }
        }
        /// <summary>
        /// Convert Complex to String
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() => $"{this.a}{(this.b >= 0 ? "+" : "")}{this.b}i";
        /// <summary>
        /// Перевод в экспоненту
        /// </summary>
        /// <param name="a">Число а</param>
        /// <returns></returns>
        public static (double, double) ToExp(Complex a) => (a.abs, a.fi);
        /// <summary>
        /// Перевод в нормальное число
        /// </summary>
        /// <param name="abs">Модуль числа </param>
        /// <param name="fi">Угол фи</param>
        /// <returns>Возвращает комплексное число в обычной записи</returns>
        public static Complex FromExp(double abs, double fi) => new Complex(abs * Math.Cos(fi), abs * Math.Sin(fi));
        /// <summary>
        /// Sum of Complex numbers
        /// </summary>
        /// <param name="a">First complex number</param>
        /// <param name="b">Second complex number</param>
        /// <returns>Sum of complex numbers</returns>
        public static Complex operator +(Complex a, Complex b) => new Complex(a.a + b.a, a.b + b.b);
        /// <summary>
        /// Sub of Complex numbers
        /// </summary>
        /// <param name="a">First complex number</param>
        /// <param name="b">Second complex number</param>
        /// <returns>Sub of complex numbers</returns>
        public static Complex operator -(Complex a, Complex b) => new Complex(a.a - b.a, a.b - b.b);
        /// <summary>
        /// Multiply of Complex numbers
        /// </summary>
        /// <param name="a">First complex number</param>
        /// <param name="b">Second complex number</param>
        /// <returns>Multiply of complex numbers</returns>
        public static Complex operator *(Complex a, Complex b) => new Complex(a.a * b.a - a.b * b.b, a.b * b.a + a.a * b.b);
        /// <summary>
        /// Division of Complex numbers
        /// </summary>
        /// <param name="a">First complex number</param>
        /// <param name="b">Second complex number</param>
        /// <returns>Division of complex numbers</returns>
        public static Complex operator /(Complex a, Complex b) => new Complex((a.a * b.a + a.b * b.b) / (b.a * b.a + b.b * b.b), (a.b * b.a - a.a * b.b) / (b.a * b.a + b.b * b.b));
        /// <summary>
        /// Operator of ==
        /// </summary>
        /// <param name="a">First complex number</param>
        /// <param name="b">Second complex number</param>
        /// <returns></returns>
        public static bool operator ==(Complex a, Complex b) => a.a == b.a && a.b == b.b;
        /// <summary>
        /// Operator of !=
        /// </summary>
        /// <param name="a">First complex number</param>
        /// <param name="b">Second complex number</param>
        /// <returns></returns>
        public static bool operator !=(Complex a, Complex b) => !(a == b);
        /// <summary>
        /// Is equal?
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true pr false</returns>
        public override bool Equals(object? obj)
        {
            if (obj is Complex other)
            {
                return this == other;
            }
            return false;
        }
        /// <summary>
        /// GetHashCodeFunction
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => (a, b).GetHashCode();
    }
}