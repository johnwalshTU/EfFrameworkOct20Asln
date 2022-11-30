using DatabaseLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib.Repository
{
    public class MockDB : ICollegeRepository
    {
        static List<Lecturer> lecturers = new List<Lecturer>();
        static List<Module> Modules = new List<Module>();


        public void AddLecturer(Lecturer lecturer)
        {
            lecturers.Add(lecturer);
        }

        public void AddModule(Module module)
        {
            Modules.Add(module);
        }

        public List<Module> DoModuleQuery()
        {
            var modules = Modules.OrderBy(module => module.Name).ToList();       // load
            return modules;
        }
    }
}
