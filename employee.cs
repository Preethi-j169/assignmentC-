using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_Csharp
{
    class employee
    {
        public static void Main()
        {
            Double Basic_Salary, HRA, Travel_Allowance;

            Console.Write("Enter Basic Salary : ");
            Basic_Salary = Convert.ToInt32(Console.ReadLine());

           
            HRA = (Basic_Salary * 20) / 100;
            Travel_Allowance = Basic_Salary  + HRA;

           
            Console.Write("\nHR ALLOWANCE : " + HRA);
            Console.Write("\nTRAVEL ALLOWANCE : " + Travel_Allowance);
        }
    }
}
