using Compositions.Entities.Enums;
using System.Collections.Generic;


namespace Compositions.Entities
{
    class Worker
    {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BasySalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double basySalary, Department department)
        {
            Name = name;
            Level = level;
            BasySalary = basySalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BasySalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }

            }
            return sum;


        }
        
    }
    
}
