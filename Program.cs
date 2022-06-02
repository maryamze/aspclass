using System;
using System.Collections.Generic;
namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
             List<employee> employees = new List<employee>();
            //employee employee;
            for (int i = 1; i <=5; i++)
            {
                employee employee= new employee();
                Console.Write("Name  : ");
                employee.Name = Console.ReadLine();
                Console.Write("Haghzahmeh : ");
                employee.payment = Convert.ToInt32(Console.ReadLine());
                Console.Write("saatKArDarroz : ");
                employee.hours = Convert.ToInt32(Console.ReadLine());
                employees.Add(employee);
                //Console.Write($"daramad mahiuane : {salary.paycalc(h, s)}");
            }
            foreach (employee item in employees)
            {
                Console.WriteLine($"Name  : {item.Name}");
                Console.WriteLine($"Haghzahmeh : {item.payment}");
                Console.WriteLine($"saatKArDarroz : {item.hours}");
                Console.WriteLine($"daramad mahiuane : {item.paycalc(item.hours,item.payment)}");
            }
            Console.ReadKey();
        }
    }
    public class employee
    {
        public string Name { get; set; }
        public int hours { get; set; }
        public int payment { get; set; }
        public int paycalc(int hours, int basePayment)
        {
            return hours * basePayment * 24;
        }
    }
}
