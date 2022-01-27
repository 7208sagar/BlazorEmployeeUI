using BlazorEmployee.model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
   public interface IEmployeeServices
    {
       // IMongoCollection<EmployeeM> EmployeeC { get; }
        public EmployeeM Create(EmployeeM emp);
        public string Delete(string empId);
        public List<EmployeeM> GetEmployees();
        public EmployeeM GetEmployee(string _id);
        public void Update(EmployeeM emp);

    }
}
