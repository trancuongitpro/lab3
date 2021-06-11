using System;

namespace Exercise_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("tran", "cuong", "Aptech", 10, 1000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee.CalculateTheBonus(2));
        }
    }
}