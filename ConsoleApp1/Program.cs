using System;

namespace ConsoleApp1
{
    class Employee
    {
        string lastName;
        string firstName;
        string middleName;
        string position;
        string department;
        int salary;

        public Employee()
        {
            this.lastName = "Неизвестно";
            this.firstName = "Неизвестно";
            this.middleName = "Неизвестно";
            this.position = "Неизвестно";
            this.department = "Неизвестно";
            this.salary = 0;
        }
        public Employee(string last, string first, string middle, string position, string department, int salar)
        {
            this.lastName = last;
            this.firstName = first;
            this.middleName = middle;
            this.position = position;
            this.department = department;
            this.salary = salar;
        }
        public void GetInfo()
        {
            Console.WriteLine("Фамилия: " + this.lastName);
            Console.WriteLine("Имя: " + this.firstName);
            Console.WriteLine("Отчество: " + this.middleName);
            Console.WriteLine("Должность: " + this.position);
            Console.WriteLine("Отдел: " + this.department);
            Console.WriteLine("Оклад: " + this.salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee("Попов", "Сергей", "Моисеевич", "Кочегар", "Бухгалтерия", 35000);
            employee1.GetInfo();
            employee1 = employee2;
            employee1.GetInfo();
        }
    }
}
