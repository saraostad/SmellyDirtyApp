using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmellyDirtyApp.CalcSalaryVisitor;

namespace SmellyDirtyApp.Models
{
    public class Teacher : IPerson<Teacher> , IElement
    {
        public string FirstName { get ; set; }
        public string LastName { get; set; }
        public string BirthCertificate { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Code { get; set; }

        public int WorkingHour { get ; set ; }
        public int WorkingDay { get ; set ; }

        public int Accept(IElementVisitor visitor)
        {
            return visitor.Visit(this);
        }


        public void EditProfile(Teacher model)
        {
            GenericRepository<Teacher> dbContext = new GenericRepository<Teacher>();
            dbContext.Update(model);
        }

        
    }
}
