namespace dependences
{
    class Vector
    {
        private int n;
        public double[] values;
        //Конструктор, якщо ми вказуємо розмірність вектора
        public Vector(int n)
        {
            this.n = n;
            this.values = new double[n];
        }
        //Конструктор, якщо ми вказуємо дані вектора
        public Vector(double[] values)
        {
            this.n = values.Length;
            this.values = values;
        }
        //Модуль вектора
        public double Magnitude()
        {
            double sumOfSquares = 0;
            for (int i = 0; i < n; i++)
            {
                sumOfSquares += values[i] * values[i];
            }
            return Math.Sqrt(sumOfSquares);
        }
        //Перевантажений оператор додавання для скалярного добутку
        public static Vector operator +(Vector v1, Vector v2)
        {
            double[] arr = new double[v1.n];
            for (int i = 0; i < v1.n; i++)
            {
                arr[i] = v1.values[i] + v2.values[i];
            }
            return new Vector(arr);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Створення двома способами об'єктів класу Vector
            Vector v1 = new Vector(3);
            double[] arr = {2,5,-2};
            Vector v2 = new Vector(arr);

            //введення данних для v1
            Console.WriteLine("Введіть данні вектора:");
            for(int i = 0; i < v1.values.Length; i++)
            {
                v1.values[i] = Convert.ToDouble(Console.ReadLine());
            }

            //Виведення модулю двох векторів
            Console.WriteLine($"Модуль двох векторів такий: (1) {v1.Magnitude()} (2) {v2.Magnitude()}");

            //Виведення скалярного добутку двох векторів
            Vector v3 = v1 + v2;
            Console.Write($"Скалярний добуток двох векторів має значення: (");
            Console.Write(v3.values[0]);
            for (int i = 1; i < v3.values.Length; i++) {
                Console.Write(" "+v3.values[i]);
            }
            Console.Write(")\n");
        }
    }
}
