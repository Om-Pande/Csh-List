using System;


namespace ConstructorChaining
{
   

    public class Employee
    {
        public int Id;
        public string Name;


        public Employee() : this(101, "Shreya")
        {
            Console.WriteLine("This is default constructor");
        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
           // Console.WriteLine("This constructor was called inside default constructor.");
            Console.WriteLine("EmployeeID:{0}\nEmployeeName:{1}",Id,Name);

        }

      
    }

    public class ProjectATeam : Employee
    {
        public ProjectATeam() : base(103, "Rajan")
        {
            Console.WriteLine("This is the default constructor of child class calling the base class cinstructor ");
        }

        static void Main(string[] args)
        {
            ProjectATeam e = new ProjectATeam();
        }
    }
}
