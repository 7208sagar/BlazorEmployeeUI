using BlazorEmployee.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
   public interface IEmployeeServices
    {
        public Employee Create(Employee emp);
        public string Delete(string empId);
        public List<Employee> GetEmployees();
        public Employee GetEmployee(string _id);
        public void Update(Employee emp);

    }
}
