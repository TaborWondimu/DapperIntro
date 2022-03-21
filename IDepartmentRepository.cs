using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperIntro
{
public  interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll(); // stubbed out methods no scope
    }

}
