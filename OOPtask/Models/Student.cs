using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtask.Models
{
    public class Student
    {
        public string Name;
        public string Major;
        public double GPA;

        public string GetInfo(string name, string major, double gpa)
        {
            string result;
            result = $"Name: {name}, Major: {major}, GPA: {gpa}";
            return result;

        }
    }
}
