using System;
using System.Collections.Generic;
using System.Text;
using ComposicaoDeObjetos.Entities.Enum;

namespace ComposicaoDeObjetos.Entities
{
    class Workers
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set;  }
        public Departament Departament { get; set; }//associação das classes
        public List<HourCrontact> Contracts { get; set; } = new List<HourCrontact>();

        public Workers()
        {
        }

        public Workers(string name, WorkerLevel leve, double salary, Departament departament)
        {
            Name = name;
            Level = Level;
            BaseSalary = salary;
            Departament = departament;
        }

        public void AddContract(HourCrontact contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContracat(HourCrontact contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int yars, int month)//calcula o quanto o trabalhador ganhou no mês
        {
            var sum = BaseSalary;
            foreach(HourCrontact contract in Contracts)
            {
                if(contract.Date.Year == contract.Date.Month)
                {
                    sum += contract.TotalValue(); 
                }
            }
            return sum;

        }



    }
}
