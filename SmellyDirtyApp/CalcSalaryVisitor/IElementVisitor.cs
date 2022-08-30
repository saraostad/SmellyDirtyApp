using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmellyDirtyApp.Models;

namespace SmellyDirtyApp.CalcSalaryVisitor
{
    public interface IElementVisitor
    {
        int Visit(Teacher teacher);
        int Visit(Employee employee);
        //int Visit(Manager manager);
    }
}
