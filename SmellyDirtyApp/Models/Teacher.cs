using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class Teacher : IPerson<Teacher> 
    {
        public string FirstName { get ; set; }
        public string LastName { get; set; }
        public string BirthCertificate { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Code { get; set; }


        public void EditProfile(Teacher model)
        {
            GenericRepository<Teacher> dbContext = new GenericRepository<Teacher>();
            dbContext.Update(model);
        }

        
    }
}
