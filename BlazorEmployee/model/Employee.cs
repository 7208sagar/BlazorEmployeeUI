using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmployee.model
{
    public class EmployeeModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        [Required(ErrorMessage="Enter Name")]
        public string EmpName { get; set; }
        public string ProfileImage { get; set; }
        [Required(ErrorMessage = "Gender is Missing")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Select Department")]
        public string Department { get; set; }
        public string Salary { get; set; }
        public string StartDate { get; set; }
        public string Notes { get; set; }
    }
}
