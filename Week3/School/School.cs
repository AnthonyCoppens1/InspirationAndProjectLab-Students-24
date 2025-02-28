using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Student: Person
    {
        public int StudentID { get; set; }
        public Student(string name, int age, int studentid): base(name, age)
        {
            StudentID = studentid;
        }
    }

    public class Teacher : Person
    {
        public Subject courseTheyTeach { get; set; }
        public Teacher(string name, int age, Subject coursetheyteach) : base(name, age)
        {
            courseTheyTeach = coursetheyteach;
        }
    }

    public enum Subject
    {
        Maths,
        Geography,
        Music,
        English,
        Dutch,
        French,
        Arts,
        History,
        Biology,
        Fysics,
        Chemistry
    }

    public class Course
    {
        public string Name { get; set; }
        public Teacher T { get; set; }
        public List<Student> Students { get; set; }

        public Course(string name, Teacher t)
        {
            Name = name;
            T = t;
            Students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }
    }


}
