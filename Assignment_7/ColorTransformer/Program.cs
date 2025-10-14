using System;

namespace ColorTransformer
{
    class Program
    {
        public delegate Tuple<int, int, int> ColorTransformation(int r, int g, int b);

        public static Tuple<int, int, int> Brighten(int r, int g, int b)
        {
            int newR = Clamp(r + 30);
            int newG = Clamp(g + 30);
            int newB = Clamp(b + 30);
            return Tuple.Create(newR, newG, newB);
        }

        public static Tuple<int, int, int> Darken(int r, int g, int b)
        {
            int newR = Clamp(r - 30);
            int newG = Clamp(g - 30);
            int newB = Clamp(b - 30);
            return Tuple.Create(newR, newG, newB);
        }

        public static Tuple<int, int, int> Invert(int r, int g, int b)
        {
            int newR = 255 - r;
            int newG = 255 - g;
            int newB = 255 - b;
            return Tuple.Create(newR, newG, newB);
        }

        public static Tuple<int, int, int> ApplyTransformation(int r, int g, int b, ColorTransformation transformation)
        {
            // Apply the provided transformation
            return transformation(r, g, b);
        }

        private static int Clamp(int value) // Ensure value is within 0-255 range
        {
            if (value < 0) return 0;
            if (value > 255) return 255;
            return value;
        }

        static void Main(string[] args)
        {
            int r = 100, g = 150, b = 200; // Original color (100, 150, 200) 

            var brightened = ApplyTransformation(r, g, b, Brighten);
            var darkened = ApplyTransformation(r, g, b, Darken);
            var inverted = ApplyTransformation(r, g, b, Invert);
            Console.WriteLine($"Original: ({r}, {g}, {b})");
            Console.WriteLine($"Brightened: ({brightened.Item1}, {brightened.Item2}, {brightened.Item3})");
            Console.WriteLine($"Darkened: ({darkened.Item1}, {darkened.Item2}, {darkened.Item3})");
            Console.WriteLine($"Inverted: ({inverted.Item1}, {inverted.Item2}, {inverted.Item3})");

        }
    }
}