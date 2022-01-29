using System;
using System.Collections;

namespace Project
{
    public interface IPerson
    {
        public int Id { get;  }

        public string Name { get; set; }

        public int Age { get; set; }

        void print();
        void print(int age);
        void print(string name);

    }

    class Person : IPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


        public Person(int _id, string _name = "No Name", int _age = 18)
        {
            Id = _id;
            Name = _name;
            Age = _age;
        }  

      
        public virtual void print()
        {
            Console.Write($" {Id} => name : {Name}  & age: {Age} ");
        }
        public virtual void print(string name)
        {
            Console.Write($"{Id} => name : {Name} ");
        }

         public virtual void print(int age)
        {
            Console.Write($"{Id} => age: {Age}");
        }  
       
      
    }

    class Student : Person
    {
       

        public Student(int _id,string _name = "No Name",int _age = 30, int _grade = 0):base(_id, _name, _age)
        {
            Grade = _grade;
        }

         private int grade;

        public int Grade
        {
            get { return grade; }
            set { 
                    if(value >= 0 && value <= 100) 
                        grade = value; 
                    else
                        Console.WriteLine("Fail to set grade => Invalid grade");
                }
        }

        public override void print()
        {
            Console.Write("Student ");
            base.print();
            Console.WriteLine($" & Grade : {Grade}\n");
        }     

          public override void print(string name)
        {
            Console.Write("Student ");
            base.print();           
        }       

           public override void print(int age )
        {
            Console.Write("Student ");
            base.print();           
        }     
    }

    class Teacher:Person
    {
        public int Salary { get; set; }

        public Teacher(int _id,string _name = "No Name",int _age = 30, int _salary = 3000):base(_id, _name, _age)
        {
            Salary = _salary;
        }
       
        public override void print()
        {
            Console.Write("Teacher ");
            base.print();
            Console.WriteLine($" & Salary : {Salary}\n");
        }    

          public override void print(string name)
        {
            Console.Write("teacher ");
            base.print();           
        }       

           public override void print(int age )
        {
            Console.Write("teacher ");
            base.print();           
        }     
    }


    class Program
    {
        static void Main(string[] args)
        {  
                  
            IPerson y = new Person(1, "Ali", 22);  
            y.print();
            Console.WriteLine();

            IPerson t = new Teacher(1, "Mostafa", 33, 9000);
            t.print();

            IPerson s = new Student(5, "Mohamed", 30, 110);
            s.print();        
            
        }
    }
}
