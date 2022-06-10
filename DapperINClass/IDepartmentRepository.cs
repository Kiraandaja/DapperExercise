using System;
using System.Collections.Generic;

namespace DapperINClass
{
    public interface IDepartmentRepository
    {
       public IEnumerable<Department> GetAllDepartments();
    }
    
}
