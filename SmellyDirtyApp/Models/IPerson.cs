using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public interface IPerson<T>
    {
        string FirstName { get; set; }
        string  LastName { get; set; }
        string BirthCertificate { get; set; }
        string NationalCode { get; set; }
        string Mobile { get; set; }
        string Code { get; set; }
        void EditProfile(T model);
    }
}
