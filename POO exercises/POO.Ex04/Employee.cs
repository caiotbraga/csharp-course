using System;
using System.Globalization;
namespace POO_Ex04 {
    internal class Employee {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary() {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage) {
            GrossSalary += (GrossSalary * percentage/100);
        }

        public override string ToString() {
            return "Employee: "+Name+", %"+NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
