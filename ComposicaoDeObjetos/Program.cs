using System;
using System.Globalization;
using ComposicaoDeObjetos.Entities;
using ComposicaoDeObjetos.Entities.Enum;

namespace ComposicaoDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departments name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter works data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/Midlevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Departament dept = new Departament(deptName);
            Workers worker = new Workers(name, level, salary, dept);

            Console.Write("How Many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i  = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract date: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("Durations(hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourCrontact contract = new HourCrontact(date, valueHour, duration);
                worker.AddContract(contract);

                
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));//recorta da posição 0 duas acasa para frente
            int years = int.Parse(monthYear.Substring(3)); //recorta da posição 3 em diante
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: "+worker.Departament.Name);
            Console.WriteLine("Income for: "+monthYear+": "+worker.Income(years, month).ToString("F2", CultureInfo.InstalledUICulture));


        }
    }
}
