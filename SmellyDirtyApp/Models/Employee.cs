using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmellyDirtyApp.CalcSalaryVisitor;

namespace SmellyDirtyApp.Models
{
    public class Employee : IPerson<Employee>, IElement
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthCertificate { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Code { get; set; }
        
        public int WorkingHour { get ; set; }
        public int WorkingDay { get; set ; }

        public int Accept(IElementVisitor visitor)
        {
            return visitor.Visit(this);
        }
        

        public void EditProfile(Employee model)
        {
            GenericRepository<Employee> dbContext = new GenericRepository<Employee>();
            dbContext.Update(model);
        }
    }
}
