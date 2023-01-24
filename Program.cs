using System;

namespace ConceptoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conceptos POO");
            Console.WriteLine("=============");
             
           Employee employee1 = new CommissionEmployee()
           {
            Id = 2020,
            FirstName = "Patricia",
            LastName = "Lopez",
            BirthDate = new Date(1995, 5, 23),
            HiringDate = new Date(2022, 2, 5),
            IsActive = true,
            Sales = 320000000M,
            CommissionPercentaje = 0.03F
           };
          // Console.WriteLine(employee1);

            Employee employee2 = new SalaryEmployee()
           {
            Id = 1010,
            FirstName = "Sandra",
            LastName = "Morales",
            BirthDate = new Date(1990, 5, 23),
            HiringDate = new Date(2022, 1, 15),
            IsActive = true,
            Salary = 1815453.45M
           };
           //Console.WriteLine(employee2);

            Employee employee3 = new HourlyEmployee()
           {
            Id = 3030,
            FirstName = "Andres",
            LastName = "Gomez",
            BirthDate = new Date(1994, 5, 29),
            HiringDate = new Date(2020, 1, 25),
            IsActive = true,
            HourValue = 12356.56M,
            Hours = 123.5F
           };
          // Console.WriteLine(employee3);

            Employee employee4 = new BaseCommissionEmployee()
           {
            Id = 4040,
            FirstName = "Juan",
            LastName = "Lucero",
            BirthDate = new Date(1997, 11, 3),
            HiringDate = new Date(2022, 10, 1),
            IsActive = true,
            Base = 860678.45M,
            Sales = 58000000M,
            CommissionPercentaje = 0.015F
           };
          // Console.WriteLine(employee4);

          ICollection<Employee> employees = new List<Employee>()
            {
                employee1, employee2, employee3, employee4
            };
            decimal payroll = 0;
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                payroll += employee.GetValueToPay();
            }
            Console.WriteLine("             =============");
            Console.WriteLine($"TOTAL       {$"{payroll:C2}", 15}");

            Invoice invoice1 = new Invoice()
            {
                Description = "iPhone 13",
                Id = 1,
                Price = 530000M,
                Quantity = 6
            };

            Invoice invoice2 = new Invoice()
            {
                Description = "Posta Premium",
                Id = 2,
                Price = 32000M,
                Quantity = 17.5F
            };
            Console.WriteLine(invoice1);
            Console.WriteLine(invoice2);
        }
    }
}
