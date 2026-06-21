namespace NNCustomManager
{
    class NumericalDiff
    {
        // Function f(x)
        static double F(double x) => Math.Pow(x, 2) + 3 * x;

        // Analytic derivative
        static double FAnalytic(double x) => 2 * x + 3;

        // Numerical derivative via central difference
        static double FNumerical(double x, double h = 1e-5) => (F(x + h) - F(x - h)) / (2 * h);

        static void Main()
        {
            double[] testPoints = { -2.0, 0.0, 1.5, 3.0 };
            foreach (var x in testPoints)
            {
                // output: x, analytic, numerical, |difference|
                var(analytic, numerical) = (FAnalytic(x), FNumerical(x));
                var difference = Math.Abs(analytic - numerical);
                Console.WriteLine($"output:{x}, {analytic}, {numerical}, {difference}");
            }
        }
    }
}