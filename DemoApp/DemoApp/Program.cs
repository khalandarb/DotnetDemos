/*using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {

*/            /*int id;
            string name;
            char gender;
            double salary;

            Console.WriteLine("Enter employee details \n enter id \n enter name \n enter gender \n enter salary");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            gender = Convert.ToChar(Console.ReadLine());
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------\n");
            Console.WriteLine($"id={id} \n name={name} \n gender={gender} \n salary={salary}");*/

/* 
 * =======================================================================
 * int a;
 int b;
 Console.WriteLine("enter the value of a & b");
 a = Convert.ToInt32(Console.ReadLine());
 b = Convert.ToInt32(Console.ReadLine());

 if (a > b)
 {
     Console.WriteLine("A is greater than b");
 }
 else if(b > a)
 {
     Console.WriteLine("B is greater than a");
 }
 else
 {
     Console.WriteLine("A and B are same");
 }* =======================================================================*/

/*   ArrayDemo arrayDemo = new ArrayDemo();
   arrayDemo.display();*/

/* float avg = 4.5f;
 int expr = 10;
 string name = "harry potter";
 string[] instructorSkill = { "java", "react", "angular" };

 Instructor instructor = new Instructor(name, avg, expr, instructorSkill);
 if(instructor.validateEligibility() && instructor.checkSkill("python"))
 {
     Console.WriteLine("Instructor is eligible");
 }
 else
 {
     Console.WriteLine("instructor not eligible");
 }
*/
/*  long accNo=123;
  double bal = 10000;
  string[] payees= { "harry potter","ronald weasley"};
  long[] payeesAcc = { 123 };

  Account account = new Account(accNo, bal);
  new Account(accNo, bal, payees, payeesAcc);

  account.TransferMoney(accNo, 5000);

  account.TransferMoney("harry potter", 2000);
}
}
}*/
/*
using System;

namespace EmpAssignment
{
    class Employee
    {
        static void Main(string[] args)
        {
            int c = 1;
            while (c == 1)
            {
                Console.WriteLine("Enter employee name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter gender");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter date of birth");
                DateTime dob = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of dependents you wish to add");
                short nod = short.Parse(Console.ReadLine());
                Employee e = new Employee(name, dob, gender, nod);
                if (nod <= 3)
                {
                    for (int i = 0; i < nod; i++)
                    {
                        Console.WriteLine($"Enter dependent {i + 1} name");
                        string dname = Console.ReadLine();
                        int n = e.AddDependent(dname);
                        Console.WriteLine($"{n} dependent added");
                    }
                }
                else if (nod > 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Enter dependent {i + 1} name");
                        string dname = Console.ReadLine();
                        int n = e.AddDependent(dname);
                        Console.WriteLine($"{n} dependent added");
                    }
                }
                Console.WriteLine($"Employee details\nEmployee Id: {e.employeeId}\nName: {e.employeeName}\nGender: {e.gender}\nDate of birth: {e.dateOfBirth}");
                for (int i = 0; i < e.dependents.Length; i++)
                {
                    if (e.dependents[i] != null)
                    {
                        Console.WriteLine($"Dependent {i + 1}: {e.dependents[i]}");
                    }
                }
                Console.WriteLine("Do you want to update dependents?\n1.Yes\n2.No");
                int ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Enter dependent Id");
                    int did = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new name");
                    string uname = Console.ReadLine();
                    bool ur = e.UpdateDependents(uname, did);
                    if (ur)
                    {
                        Console.WriteLine("Dependent updated");
                        Console.WriteLine($"Employee details\nEmployee Id: {e.employeeId}\nName: {e.employeeName}\nGender: {e.gender}\nDate of birth: {e.dateOfBirth}");
                        for (int i = 0; i < e.dependents.Length; i++)
                        {
                            if (e.dependents[i] != null)
                            {
                                Console.WriteLine($"Dependent {i + 1}: {e.dependents[i]}");
                            }
                        }
                        Console.WriteLine("Do you want to add new employee\n1.Yes\n2.No");
                        int opt = int.Parse(Console.ReadLine());
                        if (opt == 2)
                        {
                            Console.WriteLine("Exiting");
                            c = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect dependent id");
                    }
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Do you want to add new employee\n1.Yes\n2.No");
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 2)
                    {
                        Console.WriteLine("Exiting");
                        c = 0;
                    }
                }

            }
        }

        DateTime dateOfBirth;
        string[] dependents;
        int employeeId;
        string employeeName;
        string gender;
        static int nextEmployeeNumber;
        short numberOfDependents;
        int AddDependent(string dependentName)
        {
            int result = 0;
            for (int i = 0; i < numberOfDependents; i++)
            {
                if (dependents[i] == null)
                {
                    dependents[i] = dependentName;
                    result = 1;
                    break;
                }
            }
            return result;
        }
        static Employee()
        {
            nextEmployeeNumber = 1001;
        }
        Employee()
        {
            this.employeeId = nextEmployeeNumber;
            this.dependents = new string[3];
            nextEmployeeNumber++;
        }
        Employee(string employeeName, DateTime dateOfBirth, string gender) : this()
        {

            this.employeeName = employeeName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }
        public Employee(string employeeName, DateTime dateOfBirth, string gender, short numberOfDependents) : this()
        {
            this.employeeName = employeeName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            if (numberOfDependents < 0)
            {
                this.numberOfDependents = 0;
            }
            else if (numberOfDependents > 3)
            {
                this.numberOfDependents = 3;
            }
            else
            {
                this.numberOfDependents = numberOfDependents;
            }
        }
        bool UpdateDependents(string dependentName, int dependentId)
        {
            bool result = false;
            if (0 <= dependentId - 1 && dependentId - 1 <= numberOfDependents)
            {
                dependents[dependentId - 1] = dependentName;
                result = true;
            }
            return result;
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ListDemo
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public long salary { get; set; }
        public string Location { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            
            
            employees.Add(new Employee { Id = 1, Name = "Harry potter", Gender = "Male", Designation = "Associate Developer", Location = "KA", salary = 90000 });
            employees.Add(new Employee { Id = 2, Name = "Ronald weasley", Gender = "Male", Designation = "Associate Developer", Location = "MP", salary = 70000 });
            employees.Add(new Employee { Id = 3, Name = "Draco Malfoy", Gender = "Male", Designation = "Testing", Location = "London", salary = 60000 });
            employees.Add(new Employee { Id = 4, Name = "Hermione Granger", Gender = "Female", Designation = "Associate Trainee", Location = "MH", salary = 125000 });
            employees.Add(new Employee { Id = 5, Name = "Luna lovegood", Gender = "Female", Designation = "Associate Trainee", Location = "MH", salary = 80000 });

            Console.WriteLine("-------- Female-------------");
            List<Employee> fem = employees.FindAll(emp => emp.Gender == "Female");
            foreach (var item in fem)
            {
                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Gender} \t {item.salary} \t {item.Designation}");
            }
            Console.WriteLine("-------- Male-------------");
            List<Employee> male = employees.FindAll(emp => emp.Gender == "Male");
            foreach (var item in male)
            {
                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Gender} \t {item.salary} \t {item.Designation}");
            }
            Console.WriteLine("-------- Designation Associate Developer-------------");
            List<Employee> desig = employees.FindAll(emp => emp.Designation == "Associate Developer");
            foreach (var item in desig)
            {
                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Gender} \t {item.salary} \t {item.Designation}");
            }

           /* Console.WriteLine("-------- Max Salary-------------");
            List<Employee> sal = employees.Max(emp => emp.salary);
            foreach (var item in sal)
            {
                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Gender} \t {item.salary} \t {item.Designation}");
            }*/

        }
    }
}

