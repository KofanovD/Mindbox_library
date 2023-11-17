using System;
using System.Collections.Generic;
using Mindbox_library;


namespace MIndbox_ShapeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            int shapeCount = 0;

            while (true)
            {
                Console.WriteLine("Сколько фигур вы хотите создать?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out shapeCount))
                {
                    break; // Выход из цикла, если ввод корректен
                }

                Console.WriteLine("Ошибка ввода! Пожалуйста, введите целое число.");
            }

            for (int i = 0; i < shapeCount; i++)
            {
                try
                {
                    Console.WriteLine($"Фигура {i + 1}: Выберите тип фигуры. circle - c/triangle - t:");
                    string shapeType = Console.ReadLine().ToLower();

                    switch (shapeType)
                    {
                        case "C":
                        case "c":
                            Console.WriteLine("Введите радиус круга:");
                            double radius = double.Parse(Console.ReadLine());
                            shapes.Add(new Circle(radius));
                            break;

                        case "T":
                        case "t":
                            Console.WriteLine("Введите сторону A треугольника:");
                            double sideA = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите сторону B треугольника:");
                            double sideB = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите сторону C треугольника:");
                            double sideC = double.Parse(Console.ReadLine());
                            shapes.Add(new Triangle(sideA, sideB, sideC));
                            break;

                        default:
                            Console.WriteLine("Неверный тип фигуры. Попробуйте снова.");
                            i--; // Повторить текущую итерацию
                            break;
                    }
                }
                catch (Exception ex)
                {
                    i--;
                    Console.WriteLine($"Ошибка при создании фигуры. {ex.Message}");
                }
            }

            foreach (var shape in shapes)
            { 
                Console.WriteLine($"Площадь фигуры({shape.GetType()}): {shape.GetArea().ToString()}");
            }
        }
    }

}