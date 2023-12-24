class Program {
    public static void Main(string[] args) {
         int i = 0;
         Console.WriteLine("Введите a, b, e");
         string[] str = Console.ReadLine().Split();
         double a = Convert.ToDouble(str[0]);
         double b = Convert.ToDouble(str[1]);
         double e = Convert.ToDouble(str[2]);
         double x = 0;
         double d = 0;
         while (true) {
             double c = (a + b) / 2;
             if (Math.Sin(a * 2) - Math.Log(Math.E, a)
                 * (Math.Sin(c * 2) - Math.Log(Math.E, c)) < 0)
                 b = c;
             else
                 a = c;
             if (b - a < e) {
                 x = (a + b) / 2;
                 d = (b - a) / 2;
             }
             i++;
             Console.WriteLine($"N: {i}  x:{x},b:{d}");
             Console.ReadLine();
         }
    }
}

