using System;
using System.Collections.Generic;

namespace DapperINClass
{
    public interface IDepartmentRepository
    {
    }
    IEnumerable<Department> GetAllDepartments();
}
