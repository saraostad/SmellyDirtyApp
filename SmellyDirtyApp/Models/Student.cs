using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class Student : IPerson<Student>
    {
        public string FirstName { get  ; set  ; }
        public string LastName { get  ; set  ; }
        public string BirthCertificate { get  ; set  ; }
        public string NationalCode { get  ; set  ; }
        public string Mobile { get  ; set  ; }
        public string Code { get  ; set  ; }

        public void EditProfile(Student Model)
        {
            GenericRepository<Student> dbContext = new GenericRepository<Student>();
            dbContext.Update(Model);
        }
    }
}
