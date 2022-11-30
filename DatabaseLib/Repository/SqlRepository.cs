using DatabaseLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib.Repository
{
    public class SqlRepository : ICollegeRepository
    {
        public void AddLecturer(Lecturer lecturer)
        {
            using (CollegeContext db = new CollegeContext())
            {
                try
                {
                    // add and save
                    db.Lecturers.Add(lecturer);
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void AddModule(Module module)
        {
            using (CollegeContext db = new CollegeContext())
            {
                try
                {
                    // add and save
                    db.Modules.Add(module);
                    db.SaveChanges();
                    // navigation properties updated on both sides
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

       

        public List<Module> DoModuleQuery()
        {
            List <Module> modules = null;

            using (CollegeContext db = new CollegeContext())
            {
                // select all modules, ordered by module name
                modules = db.Modules.OrderBy(module => module.Name).ToList();         // load

                Console.WriteLine("\nModules:");
                foreach (var module in modules)
                {
                    Console.WriteLine("id: " + module.ID + " name: " + module.Name + " ");

                    if (module.Lecturer != null)
                    {
                        // Lecturer is a navigation property of type Lecturer
                        Console.WriteLine(" lectured by: " + module.Lecturer.Name);
                    }
                }
            }

            return modules;
        }
    }
    
}
