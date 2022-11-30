using DatabaseLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib.Repository
{
    //This represents the Databse Functions
    public interface ICollegeRepository
    {
        //Write fucntiosn
        void AddLecturer(Lecturer lecturer);
        void AddModule(Module module);

        //Read fucntion
        List<Module> DoModuleQuery();
    }
}
