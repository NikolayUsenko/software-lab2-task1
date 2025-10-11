class Par
{
    private double a, b, c;
    private Par() { }
    public Par(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public double GetV() => a * b * c;
    public double GetS() => 2 * (a * b + b * c + a * c);
    public void Info()
    {
        String str =
            "\n*******************************\n" +
            "*                             *\n" +
            "*       Параллелепипед        *\n" +
            "*                             *\n" +
            "*******************************\n";
        Console.WriteLine(str);
        Console.WriteLine(string.Format("Значения сторон параллелепипеда:\nA = {0:0.00};\nB = {1:0.00};\nC = {2:0.00}.", a, b, c));
        Console.WriteLine(string.Format("Объём и площадь поверхности параллелепипеда:\nV = {0:0.00}\nS = {1:0.00}", GetV(), GetS()));
    }
    public void Info(ConsoleColor fg, ConsoleColor bgc)
    {
        Console.ForegroundColor = fg;
        Console.BackgroundColor = bgc;
        Console.Clear();
        Info();
    }
    public void Load()
    {
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
    }
    public static Par CreateParFromFile()
    {
        double A = Convert.ToDouble(Console.ReadLine());
        double B = Convert.ToDouble(Console.ReadLine());
        double C = Convert.ToDouble(Console.ReadLine());
        return new Par(A, B, C);
    }
}