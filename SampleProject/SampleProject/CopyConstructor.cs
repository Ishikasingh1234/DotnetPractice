using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEAPP
{
    class CopyConstructor
    {
        public int Id;
        public string Name;
        public string Description;
        public double Salary;
        private double sal;
        private int v1;
        private string v2;

        // Copy Constructor
        public CopyConstructor(CopyConstructor obj)
        {
            Id = obj.Id;
            Name = obj.Name;
            Description = obj.Description;
            Salary = obj.Salary;
        }

      

        // Parameterized Constructor
        public CopyConstructor(int id, string name, string Description, double Salary)
        { Id = id; Name = name; Description = Description; Salary = sal; }
           
        static void Main(string[] args)
        {
            CopyConstructor original = new CopyConstructor(1, "joy","Enthusiastmic person",50000);

            CopyConstructor copy = new CopyConstructor(original);

            Console.WriteLine("Original Object: Id = {0}, Name = {1}", original.Id, original.Name,original .Description, original.Salary) ;
            Console.WriteLine("Copied Object: Id = {0}, Name = {1}", copy.Id, copy.Name ,copy.Description,copy.sal);
        }
    }
}

