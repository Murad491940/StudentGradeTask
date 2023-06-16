using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Student
    {
        public int Count { get; set; }
        public string Name { get; set; }

        public int Grade{ get; set; }
       
        

        public Student(int count,string name,int grade)
        {
            Count = count;
            Name = name;
            Grade = grade;
            
        }
        
    }
}
