using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.CalcSalaryVisitor
{
    public interface IElement
    {
        int WorkingHour { get; set; }
        int WorkingDay { get; set; }
        int Accept(IElementVisitor visitor);
    }
}
