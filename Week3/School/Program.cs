namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Mr. Smith", 35, Subject.Maths);

            Course course = new Course("Algebra", teacher);

            Student student1 = new Student("Jane Doe", 18, 12345);
            Student student2 = new Student("John Doe", 19, 67890);
            Student student3 = new Student("Jim Smith", 17, 11111);

            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);

            Console.WriteLine("Teacher: " + teacher.Name + " (" + teacher.courseTheyTeach + ")");
            Console.WriteLine("Course: " + course.Name + " - " + course.Students.Count + " students enrolled");
        }
    }
}
