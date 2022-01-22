using BlazorEmployee.model;
using DataLayer.Data;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
   public class EmployeeServices : IEmployeeServices
    {
        public readonly IMongoDatabase db;
        public readonly IMongoCollection<Employee> table;

        public EmployeeServices(IOptions<Settings> options)
        {
            var Client = new MongoClient(options.Value.ConnectionString);
            db = Client.GetDatabase(options.Value.DatabaseName);
        }

        public IMongoCollection<Employee> Employee => db.GetCollection<Employee>("EmpBlazor");
        
        public Employee Create(Employee emp)
        {
            try
            {
                Employee.InsertOne(emp);
                return emp;
            }
            catch(Exception e)
            {
                throw e;
            }
       
        }
        public string Delete(string empId)
        {
            try
            {
                Employee.DeleteOne(x => x._id == empId);
                return empId;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public List<Employee> GetEmployees()
        {
            try
            {
                return Employee.Find(x => true).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public Employee GetEmployee(string _id)
        {
            try
            {
                var employee = Employee.Find(x => x._id == _id).FirstOrDefault();
                return employee;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Update(Employee emp)
        {
            try
            {
                var newEmp = Employee.Find(x => x._id == emp._id).FirstOrDefault();
                if (newEmp == null)
                {
                    Employee.InsertOne(emp);
                }
                else
                {
                    Employee.ReplaceOne(x => x._id == emp._id, emp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
