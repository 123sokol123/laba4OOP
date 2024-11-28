namespace Vector
{
    /// <summary>
    /// Структура вектора
    /// </summary>
    public struct Vector3D
    {
        public double x = 0;
        public double y = 0;
        public double z = 0;
        /// <summary>
        /// Конструктор
        /// </summary>
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// 
        /// </summary>
        public readonly double abs { get { return Math.Sqrt(x * x + y * y + z * z); } }
        /// <summary>
        /// Sum two vectors
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <returns>result of sum two vectors</returns>
        public static Vector3D operator +(Vector3D a, Vector3D b) => new Vector3D(a.x + b.x, a.y + b.y, a.z + b.z);
        /// <summary>
        /// Sub two vectors
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <returns>result of sub two vectors</returns>
        public static Vector3D operator -(Vector3D a, Vector3D b) => new Vector3D(a.x - b.x, a.y - b.y, a.z - b.z);
        /// <summary>
        /// Multiply two vectors
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <returns>result of multiply two vectors</returns>
        public static Vector3D operator *(Vector3D a, Vector3D b) => new Vector3D(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
        /// <summary>
        /// Умножает скаляр k на вектор b
        /// </summary>
        /// <param name="k">скаляр</param>
        /// <param name="b">вектор</param>
        /// <returns></returns>
        public static Vector3D operator *(double k, Vector3D b) => new Vector3D(b.x * k, k * b.y, k * b.z);
        /// <summary>
        /// Умножает скаляр k на вектор b
        /// </summary>
        /// <param name="k">скаляр</param>
        /// <param name="b">вектор</param>
        /// <returns></returns>
        public static Vector3D operator *(Vector3D b, double k) => k * b;
        /// <summary>
        /// Переводит все в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Vector3D({this.x}, {this.y}, {this.z})";
        /// <summary>
        /// == of two vectors
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <returns>result of == two vectors</returns>
        public static bool operator ==(Vector3D a, Vector3D b) => a.x == b.x && a.y == b.y && a.z == b.z;
        /// <summary>
        /// != of two vectors
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <returns>result of != two vectors</returns>
        public static bool operator !=(Vector3D a, Vector3D b) => !(a == b);
        /// <summary>
        ///  Is equal?
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj) => obj is Vector3D other && this == other;
        /// <summary>
        /// hashcode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => HashCode.Combine(x, y, z);
    }
}