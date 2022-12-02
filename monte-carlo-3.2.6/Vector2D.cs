using System;

namespace monte_carlo
{
    public struct Vector2D
    {
        public double X, Y;

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector2D Zero => new Vector2D(0, 0);

        public static Vector2D One => new Vector2D(1, 1);

        public double Magnitude(Vector2D vec) => Math.Sqrt((vec.X - X) * (vec.X - X) + (vec.Y - Y) * (vec.Y - Y));

        public double Magnitude() => Math.Sqrt(SquaredMagnitude());

        public static double Magnitude(Vector2D vec1, Vector2D vec2) =>
            Math.Sqrt((vec2.X - vec1.X) * (vec2.X - vec1.X) + (vec2.Y - vec1.Y) * (vec2.Y - vec1.Y));

        public double SquaredMagnitude() => X * X + Y * Y;

        public double SquaredMagnitude(Vector2D vec) => (vec.X - X) * (vec.X - X) + (vec.Y - Y) * (vec.Y - Y);

        public static double SquaredMagnitude(Vector2D vec1, Vector2D vec2) =>
            (vec2.X - vec1.X) * (vec2.X - vec1.X) + (vec2.Y - vec1.Y) * (vec2.Y - vec1.Y);

        public double GetMax() => Math.Max(X, Y);

        public double GetMin() => Math.Min(X, Y);

        public static Vector2D operator +(Vector2D vec1, Vector2D vec2) => new Vector2D(vec1.X + vec2.X, vec1.Y + vec2.Y);

        public static Vector2D operator +(Vector2D vec, double value) => new Vector2D(vec.X + value, vec.Y + value);

        public static Vector2D operator +(Vector2D vec, int value) => new Vector2D(vec.X + value, vec.Y + value);

        public static Vector2D operator -(Vector2D vec1, Vector2D vec2) => new Vector2D(vec1.X - vec2.X, vec1.Y - vec2.Y);

        public static Vector2D operator -(Vector2D vec, double value) => new Vector2D(vec.X - value, vec.Y - value);

        public static Vector2D operator *(Vector2D vec1, Vector2D vec2) => new Vector2D(vec1.X * vec2.X, vec1.Y * vec2.Y);

        public static Vector2D operator *(Vector2D vec, double num) => new Vector2D(vec.X * num, vec.Y * num);

        public static Vector2D operator *(Vector2D vec, int num) => new Vector2D(vec.X * num, vec.Y * num);

        public static Vector2D operator *(double num, Vector2D vec) => new Vector2D(vec.X * num, vec.Y * num);

        public static Vector2D operator *(int num, Vector2D vec) => new Vector2D(vec.X * num, vec.Y * num);

        public static Vector2D operator /(Vector2D vec1, Vector2D vec2) => new Vector2D(vec1.X / vec2.X, vec1.Y / vec2.Y);

        public static Vector2D operator /(Vector2D vec, double num) => new Vector2D(vec.X / num, vec.Y / num);

        public static Vector2D operator /(Vector2D vec, int num) => new Vector2D(vec.X / num, vec.Y / num);
    }
}