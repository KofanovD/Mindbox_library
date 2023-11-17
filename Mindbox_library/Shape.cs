using System.Security.Cryptography.X509Certificates;

namespace Mindbox_library
{

    /* 
    ТЗ:
    Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
        + Юнит-тесты - Есть
        + Легкость добавления других фигур - Новая фигура должна быть наследником Shape и реализовывать 2 метода
        + Вычисление площади фигуры без знания типа фигуры в compile-time - пример полиморфизма в Program.cs
        + Проверку на то, является ли треугольник прямоугольным
    */
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract string GetType();
    }

    
}