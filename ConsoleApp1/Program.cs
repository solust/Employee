using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee("Попов", "Сергей", "Моисеевич", "Кочегар", "Бухгалтерия", 35000);
            employee1.GetInfo();
            employee1 = employee2;
            employee1.GetInfo();
            Point t1 = new Point();
            Point t2 = new Point(1, 2, 2);
            Console.WriteLine("t1 + t2 = " + Point.LengthPoints(t1, t2));
        }
    }
}
