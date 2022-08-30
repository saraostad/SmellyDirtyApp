using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmellyDirtyApp.Models;

namespace SmellyDirtyApp.CalcSalaryVisitor
{
    public class SalaryCalculator : IElementVisitor
    {

        public int Visit(Teacher teacher)
        {            
            return CalcByHoure(teacher);

        }

        public int Visit(Employee employee)
        {
            return CalcByDay(employee);
        }

        //public int Visit(Manager manager)
        //{
        //    return NewMethod(Manager, 6000, 5000, 2000, 7000);

        //}

        private static int CalcByHoure(IElement element)
        {
            var salary = element.WorkingHour * 1000;
            Console.WriteLine($"{element.GetType().Name}'s Salary is " + salary);
            return salary;
        }

        private static int CalcByDay(IElement element)
        {
            var salary = element.WorkingHour * 2000;
            Console.WriteLine($"{element.GetType().Name}'s Salary is " + salary);
            return salary;
        }

    }
}
