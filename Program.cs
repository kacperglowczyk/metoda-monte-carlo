using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę losowych punktów:");
        int n = int.Parse(Console.ReadLine());

        int pointsInsideCircle = 0;
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            // Generujemy losowe współrzędne x i y w przedziale [0, 1]
            double x = random.NextDouble();
            double y = random.NextDouble();

            // Sprawdzamy, czy punkt (x, y) znajduje się wewnątrz ćwiartki koła
            if (x * x + y * y <= 1)
            {
                pointsInsideCircle++;
            }
        }

        // Obliczamy przybliżoną wartość π
        double piEstimate = (4.0 * pointsInsideCircle) / n;

        Console.WriteLine($"Przybliżona wartość liczby π wynosi: {piEstimate}");
    }
}