using DatabaseLib.Models;
using DatabaseLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFrameworkApp
{
    public class CollegeApp
    {
        ICollegeRepository repo = null;

        public CollegeApp(ICollegeRepository repo)
        {
            this.repo = repo;
        }

        public void InitApp()
        {

            //Init lectures an
            //d module info
            Lecturer jw = new Lecturer() { Name = "jw", Phone = "2898" };
            Lecturer GC = new Lecturer() { Name = "GC", Phone = "2898" };


            repo.AddLecturer(jw);
            repo.AddLecturer(GC);

            Module oosdev1 = new Module() { Name = "OOSDEV1", Credits = 5, Lecturer = jw };
            Module oosdev2 = new Module() { Name = "EAD", Credits = 5, Lecturer = GC };
            repo.AddModule(oosdev1);
            repo.AddModule(oosdev2);

        }


        public void QueryApp()
        {
            var res = repo.DoModuleQuery();

            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
