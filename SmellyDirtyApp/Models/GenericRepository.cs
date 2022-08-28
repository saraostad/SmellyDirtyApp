using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmellyDirtyApp.Models
{
    public class GenericRepository<T>
    {
        T model1;

        public GenericRepository(){
            //Detect What Entity Generated
        }

            

        public void Add(T model)
        {
            //Add To DB
            //return 1;
        }

        public void Update(T model)
        {
            //Add To DB
            //return 1;
        }

        public void Delete(T model)
        {
            //Delete From DB And Return Id Deleted
            //return 1;
        }

        public void SelelctWithID(int code)
        {
            //Find code From DB And Return Model T
            //return T;
        }

        public void SelelctAll()
        {
            //Add To DB
            //return T;
        }
    }
}
