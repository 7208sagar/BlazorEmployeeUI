using BlazorEmployee.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmployee.IRepository
{
   public interface IEmployeeRepo
    {
        Employee Save(Employee employee);
        Employee Get(String employeeId);
        List<Employee> Gets();
        string Delete(string employeeId);

    }
}
