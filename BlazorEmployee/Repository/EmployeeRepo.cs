using BlazorEmployee.IRepository;
using BlazorEmployee.model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmployee.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        //private MongoClient _mongoClient = null;
        //private IMongoDatabase _database = null;
        //private IMongoCollection<Employee> _employeeTable = null;

        //public EmployeeRepo()
        //{
        //    _mongoClient = new MongoClient("mongodb://127.0.0.1:27017");
        //    _database = _mongoClient.GetDatabase("EmployeeDB");
        //    _employeeTable = _database.GetCollection<Employee>("Employees");
        //}

       
        public string Delete(string employeeId)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel Get(string employeeId)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> Gets()
        {
            throw new NotImplementedException();
        }

        public EmployeeModel Save(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
