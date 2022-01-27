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
        public readonly IMongoDatabase _db;
        public readonly IMongoCollection<EmployeeM> table;

        public EmployeeServices(IOptions<Settings> options)
        {
            var Client = new MongoClient(options.Value.ConnectionString);
            _db = Client.GetDatabase(options.Value.DatabaseName);
        }

        public IMongoCollection<EmployeeM> EmployeeC => _db.GetCollection<EmployeeM>("EmployeeBlazor");
        
        public EmployeeM Create(EmployeeM emp)
        {
            try
            {
                EmployeeC.InsertOne(emp);
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
                EmployeeC.DeleteOne(x => x._id == empId);
                return empId;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public List<EmployeeM> GetEmployees()
        {
            try
            {
                return EmployeeC.Find(x => true).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public EmployeeM GetEmployee(string _id)
        {
            try
            {
                var employee = EmployeeC.Find(x => x._id == _id).FirstOrDefault();
                return employee;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Update(EmployeeM emp)
        {
            try
            {
                var newEmp = EmployeeC.Find(x => x._id == emp._id).FirstOrDefault();
                if (newEmp == null)
                {
                    EmployeeC.InsertOne(emp);
                }
                else
                {
                    EmployeeC.ReplaceOne(x => x._id == emp._id, emp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
