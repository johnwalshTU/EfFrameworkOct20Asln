using DatabaseLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ICollegeRepository repo = new SqlRepository();

            CollegeApp app = new CollegeApp(repo);


            app.InitApp();
            app.QueryApp();
        }
    }
}
