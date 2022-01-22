using BlazorEmployee.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmployee.IRepository
{
   public interface IEmployeeRepo
    {
        EmployeeModel Save(EmployeeModel employee);
        EmployeeModel Get(String employeeId);
        List<EmployeeModel> Gets();
        string Delete(string employeeId);

    }
}
